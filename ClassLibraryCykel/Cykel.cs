using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ClassLibraryCykel
{
    public class Cykel
    {
        private string _farve;
        private double _pris;
        private int _gear;

        public Cykel() { }

        public Cykel(int id, string farve, double pris, int gear)
        {
            try
            {
                Id = id;
                Farve = farve;
                Pris = pris;
                Gear = gear;
            }
            catch (Exception e)
            {
                throw new ArgumentException($"Cykelkonstruktør lever ikke op til krav: {e}");
            }
        }


        public int Id { get; set; }

        public string Farve
        {
            get { return _farve; }
            set
            {
                if (value.Length < 1)
                    throw new ArgumentException("Farve skal være minimum et tegn.");
                else
                    _farve = value;
            }
        }

        public double Pris
        {
            get { return _pris; }
            set
            {
                if (value > 0)
                    _pris = value;
                else
                    throw new ArgumentException("Pris skal være positivt.");
            }
        }

        public int Gear
        {
            get { return _gear; }
            set
            {
                if (value >= 3 && value <= 32)
                    _gear = value;
                else
                    throw new ArgumentOutOfRangeException("Gear skal være mellem 3 og 32 (inklusiv).");
            }
        }
    }
}
