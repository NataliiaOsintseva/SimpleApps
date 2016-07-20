using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance
{
    class Converter
    {

        private double usd, eur, pound;

        public Converter(double usd, double eur, double pound) {
            this.usd = usd;
            this.eur = eur;
            this.pound = pound;
        }

        public void ToUSD(double uah) {
            Console.WriteLine("\nAmount in USD is {0} ", uah/usd);
        }

        public double FromUSD(double sum) {
            return sum * usd;
        }

        public double ToEUR(double uah) {
            return uah / eur;
        }

        public double FromEUR(double sum) {
            return sum * eur;
        }

        public double ToPound(double uah) {
            return uah / pound;
        }

        public double FromPound(double sum) {
            return sum * pound;
        }
    }
}
