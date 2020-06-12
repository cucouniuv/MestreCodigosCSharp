using System;
using System.Collections.Generic;
using System.Text;

namespace Questao4POO
{
    class ControleRemoto
    {
        private readonly Televisao _televisaoSincronizada;

        public ControleRemoto(Televisao televisao)
        {
            _televisaoSincronizada = televisao;
        }

        public void AumentarVolume()
        {
            _televisaoSincronizada.AumentarVolume();
        }

        public void DiminuirVolume()
        {
            _televisaoSincronizada.DiminuirVolume();
        }

        public string AumentarNumeroCanal()
        {
            _televisaoSincronizada.AumentarNumeroCanal();
            return _televisaoSincronizada.InfoNumeroCanal();
        }

        public string DiminuirNumeroCanal()
        {
            _televisaoSincronizada.DiminuirNumeroCanal();
            return _televisaoSincronizada.InfoNumeroCanal();
        }

        public string ConsultarInfoVolumeCanal()
        {
            return "Volume " + _televisaoSincronizada.Volume.ToString() + 
                " - " + _televisaoSincronizada.InfoNumeroCanal();
        }

        public string InformarNumeroCanal(int numero)
        {
            _televisaoSincronizada.NumeroCanal = numero;
            return _televisaoSincronizada.InfoNumeroCanal();
        }
    }
}
