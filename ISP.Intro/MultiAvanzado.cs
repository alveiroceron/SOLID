using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Intro
{
    internal class MultiAvanzado: IMultifuncional
    {
        public void Escanear()
        {
            Console.WriteLine("Estoy escaneando un documento");
        }

        public void Faxear()
        {
            Console.WriteLine("Envio un fax");
        }

        public void Imprimir()
        {
            Console.WriteLine("imprimo tu reporte");
        }

        public void Telefono()
        {
            Console.WriteLine("Te marco a un teléfono");
        }
    }
}
