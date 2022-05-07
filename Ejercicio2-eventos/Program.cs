using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_eventos
{
    public class Parrafo
    {
        public EventHandler evento;

        public void escribirParrafo()
        {

        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Parrafo parrafo = new Parrafo();
            parrafo.evento += handler;

            Console.WriteLine("Escribir texto: ");

            while (true)
            {
                
            }
            

            Console.ReadKey();

        }

        static void handler(object sender, EventArgs args)
        {
            
        }
    }
}
