using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Timers;

namespace Questao1POO_Interfaces
{
    class Coisa: IDisposable
    {
        private Timer _timer = new Timer();
        private StreamWriter _stream;

        public Coisa()
        {
            _timer.Interval = 2000;
            _stream = new StreamWriter(@"C:\teste\arquivo.txt");
            _stream.WriteLine("primeira linha");
            _stream.WriteLine("segunda linha");
            _stream.WriteLine("terceira linha");
        }

        public void Dispose()
        {
            _timer.Dispose();
            _stream.Dispose();
        }
    }
}
