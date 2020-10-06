using System;
using System.IO;
using System.Timers;

namespace Questao1POO_Interfaces
{
    class Coisa: IDisposable
    {
        private readonly Timer _timer = new Timer();
        private readonly StreamWriter _stream;

        public Coisa()
        {
            _timer.Interval = 2000;

            string diretorio = @"C:\questao_dispose";

            if (!Directory.Exists(diretorio))
                Directory.CreateDirectory(diretorio);

            _stream = new StreamWriter(diretorio + @"\arquivo.txt");
            _stream.WriteLine("Primeira linha");
            _stream.WriteLine("Segunda linha");
            _stream.WriteLine("Terceira linha");
        }

        public void Dispose()
        {
            _timer.Dispose();
            _stream.WriteLine("Realizando dispose");
            _stream.Dispose();
        }
    }
}
