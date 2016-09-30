namespace Praktikum05wpf
{
    public class Inimene
    {
        private string _eesnimi;
        private string _perenimi;
        private int _pikkus;


        public string Eesnimi
        {
            get { return _eesnimi; }
            set { _eesnimi = value; }
        }

        public string Perenimi
        {
            get { return _perenimi; }
            set { _perenimi = value; }
        }

        public int Pikkus
        {
            get { return _pikkus; }
            set { _pikkus = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", _eesnimi, _perenimi);
        }
    }
}