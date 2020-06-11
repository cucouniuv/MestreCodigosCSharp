using System;
using System.Collections.Generic;
using System.Text;

namespace Questao4POO
{
    class Televisao
    {
        private int _volume;
        private int _numeroCanal;

        public int Volume
        {
            get { return _volume; }
            set { if ((value >= 0) || (value <= 100)) { _volume = value; } }
        }

        public int NumeroCanal
        {
            get { return _numeroCanal; }
            set { if ((value >= 0) || (value <= 100)) { _numeroCanal = value; } }
        }

        public string InfoNumeroCanal()
        {
            var encontrado = (ListaCanal.Find(x => x.Numero == NumeroCanal));
            if (encontrado == null)
            {
                return "Canal " + NumeroCanal.ToString() + " não encontrado";
            }

            return "Canal " + encontrado.Numero.ToString() + " - " + encontrado.Nome;
        }

        public void AumentarVolume()
        {
            Volume += 1;
        }

        public void DiminuirVolume()
        {
            Volume -= 1;
        }

        public void AumentarNumeroCanal()
        {
            NumeroCanal += 1;
        }

        public void DiminuirNumeroCanal()
        {
            NumeroCanal -= 1;
        }

        public List<Canal> ListaCanal = new List<Canal>();
        public void SintonizarCanais()
        {
            ListaCanal.Add(new Canal(13, "TV Globo"));
            ListaCanal.Add(new Canal(21, "SBT"));
            ListaCanal.Add(new Canal(36, "Rede Vida"));
            ListaCanal.Add(new Canal(40, "Canal do Boi"));
            ListaCanal.Add(new Canal(66, "Multishow"));
        }

        public Televisao()
        {
            SintonizarCanais();
            Volume = 50;
        }
    }
}
