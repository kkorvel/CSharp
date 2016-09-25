using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectandClass
{

    public class Ristkylik
    {

        private int _pikkus;

        private int _laius;

        public Ristkylik(int pikkus, int laius)
        {
            _laius = laius;
            _pikkus = pikkus;

        }

        public int Pindala()
        {
            return _laius * _pikkus;
        }

        public int Ymberm66T()
        {
            return 2*(_laius + _pikkus);
        }

        public Boolean kasOnVordsed(Ristkylik vajalikRistkylik)
        {
            if (_laius == vajalikRistkylik._laius && _pikkus == vajalikRistkylik._pikkus)

            {
                return true;
            }
            else
            {
                return false;
            }
     
            }

        public Boolean kasOnRuut(Ristkylik vajalikRistkylik)
        {
            if (_laius == _pikkus)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        }
           

    }

