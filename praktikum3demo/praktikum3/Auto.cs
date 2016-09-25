using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum04
{
    public class Mootorsoiduk
    {
        private int _kiirus = 0;
        private int _maxKiirus = 20;

        /// <summary>
        /// Määratakse maksimumkiirus mootorsõidukile
        /// </summary>
        /// <param name="maxKiirus">Mootorsõiduki maksimumkiirus</param>
        public Mootorsoiduk(int maxKiirus)
        {
            _maxKiirus = maxKiirus;
        }

        public virtual void Kiirenda()
        {
            Kiirenda(10);
            //_kiirus = _kiirus + 10;
            //if (_kiirus > _maxKiirus)
            //{
            //    _kiirus = _maxKiirus;
            //}
        }

        public virtual void Kiirenda(int kiirus)
        {
            _kiirus = _kiirus + kiirus;
            if (_kiirus > _maxKiirus)
            {
                _kiirus = _maxKiirus;
            }
        }

        public void Stop()
        {
            _kiirus = 0;
        }

        public virtual string HetkeSeis()
        {
            if (_kiirus == 0)
            {
                return "Sõiduk seisab";
            }
            return string.Format("Sõiduk sõidab {0} km/h", _kiirus);
        }

        public override string ToString()
        {
            return HetkeSeis();
        }
    }
}
