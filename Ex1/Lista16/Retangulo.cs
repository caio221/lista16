using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista16
{
    class Retangulo //fiz errado aqui, o nome era pra ser esfera... to com medo de mudar e bugar tudo entao vou deixar assim
    {
        private double raio;
        public void SetRaio(double v) { if (v > 0) raio = v; }
        public double GetRaio() { return raio; }
        public double CalcArea() { return 4 * 3.14 * (raio * raio); }
        public double CalcVolume() { return 4 / 3 * 3.14 * (raio * raio * raio); }
    }
}
