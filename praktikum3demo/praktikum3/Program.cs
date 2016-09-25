using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum04
{
    public class Auto : Mootorsoiduk
    {
        private bool _uksedAvatud = false;

        public Auto() : base(100)
        {

        }

        public void AvaUksed()
        {
            base.Stop();
            _uksedAvatud = true;
        }

        public void SulgeUksed()
        {
            _uksedAvatud = false;
        }

        public override void Kiirenda(int kiirus)
        {
            if (_uksedAvatud == false)
            {
                base.Kiirenda(kiirus);
            }
        }

        public override void Kiirenda()
        {
            this.Kiirenda(10);
        }

        public override string HetkeSeis()
        {
            if (_uksedAvatud)
            {
                return "Sõiduk seisab ja uksed on avatud";
            }

            return base.HetkeSeis();
        }

        public override string ToString()
        {
            return HetkeSeis();
        }
    }
}
