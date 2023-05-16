using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormPersonas
{
    public class Munieco
    {
        //atributos de instancias: de objetos Munieco
        private string nombre;
		private int energia;
        private static int contador = 0; // variable de CLASE y va a ser compartida por todos los objetos
                                        // de la clase 
		public int Energia
		{
			get { return energia;  }
			set { energia = value; }
		}

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public Munieco(string nombre)
		{
            this.nombre = nombre;
            energia = 100;
            contador++;
		}  

        public static int Contador()
        {
            return contador;
        }

        public void Jugar(int t)
        {
            energia -= t;
        }

        public void Comer()
        {
            energia += 3;
        }

        public override string ToString()
        {
            return nombre + "[" + energia + "]";
        }
    }
}
