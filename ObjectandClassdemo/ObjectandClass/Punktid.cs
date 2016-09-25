using System;
using System.Diagnostics.Eventing.Reader;

namespace ObjectandClass
{
    public class Punktid
    {
        private double _x;
        private double _y;


        public Punktid(double x, double y)
        {
            _x = x;
            _y = y;



        }

        public double kaugusteisestPunktist(Punktid teine)
        {
            double xVal = Math.Pow(teine._x - this._x, 2);
            double yVal = Math.Pow(teine._y - this._y, 2);
            return Math.Sqrt(xVal + yVal);
        }

        public double kaugusNullPunktist()
        {
            return kaugusteisestPunktist(new Punktid(0, 0));
        }

        public string teataAndmed()
        {
            string tulemus = string.Format("({0};{1})", _x, _y);
            return tulemus;
        }

        public bool kasOnAlgusPunkt()
        {
            if (_x == 0 && _y == 0)
            {
                return true;
            }
            return false;
        }
    }
}