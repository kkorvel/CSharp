using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectandClass
{
    public class Kompleksarv
    {
        private double _reaalosa;
        private double _imaginaarosa;


        public Kompleksarv(double reaalosa, double imaginaarosa)
        {
            this._reaalosa = reaalosa;
            this._imaginaarosa = imaginaarosa;
        }

        public Kompleksarv liida(Kompleksarv teine)
        {
            double imaginaarosa = this._imaginaarosa + teine._imaginaarosa;
            double reaalosa = this._reaalosa + teine._reaalosa;
            return new Kompleksarv(reaalosa, imaginaarosa);
        }
    }
}
