using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using BarcodeLib.BarcodeReader;

namespace ReadbarCodeDesktop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] results = BarcodeReader.read("c:/hsbc.jpg", BarcodeReader.INTERLEAVED25);

            var z = results;
        }
    }
}
