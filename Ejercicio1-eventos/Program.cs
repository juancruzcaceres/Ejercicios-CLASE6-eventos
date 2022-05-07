using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_eventos
{
    public class GeneradorEventArgs : EventArgs
    {
        public List<int> numeros { get; set; }
    }

    public class Generador
    {
        public static List<int> Numeros = new List<int>();

        public EventHandler<GeneradorEventArgs> evento;

        public void generarNumero()
        {
            Random random = new Random();
            int numero = random.Next(0, 100);
            Numeros.Add(numero);
            int promedio = (int)(Numeros.Count > 0 ? Numeros.Average() : 0);
            if (numero < promedio)
                this.evento(this, new GeneradorEventArgs() { numeros = Numeros });
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Generador generador = new Generador();
            generador.evento += handler;
        ini:
            Console.Write("1. Generar numero: ");
            if (Console.ReadLine() == "1")
                generador.generarNumero();
            goto ini;
        }

        static void handler(object sender, GeneradorEventArgs args)
        {
            Dictionary<int, int> Diccionario = new Dictionary<int, int>();
            foreach (var numero in args.numeros)
            {
                if (Diccionario.ContainsKey(numero))
                {
                    //Si existe le sumamos una repetición más.
                    Diccionario[numero] = Diccionario[numero] + 1;
                }
                else
                {
                    //Si no, la agregamos al diccionario con valor 1. 
                    Diccionario.Add(numero, 1);
                }
            }

            string output = "";
            foreach (KeyValuePair<int, int> kvp in Diccionario)
            {
                output += string.Format("Numero = {0}, Repetido = {1} veces", kvp.Key, kvp.Value);
                output += "\n";
            }
            Console.Clear();
            Console.WriteLine(output);
        }
    }
}
