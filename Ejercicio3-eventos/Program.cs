using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_eventos
{
    public class AutoEventArgs : EventArgs 
    {
        public string mensaje { get; set; }
    }

    public class Auto
    {
        private bool Encendido { get; set; }
        private int VelocidadActual { get; set; }
        private int VelocidadMaxima { get; set; }

        public EventHandler evento;

        public bool Encender()
        {
            if (Encendido == false)
            {
                Encendido = true;
                return true;
            }
            return false;
        }

        public void Apagar()
        {

        }

        public void SubirVelocidad(int velocidad)
        {
            VelocidadActual += velocidad;
            if (VelocidadActual>VelocidadMaxima)
            {
                this.evento(this, new AutoEventArgs() { mensaje = "Velocidad maxima de {} ha sido sobrepasada"});
            }
        }

        public void BajarVelocidad(int velocidad)
        {
            VelocidadActual -= velocidad;
        }

    }


    public class Program
    {
        public delegate void ModificarVelocidad(int velocidad);
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            
            
        }
    }
}
