using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FlyweightConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Precio de comidas de buenas recetas--------- ");
            //Console.ReadKey();

            int i = 0;
            List<int> Peruana = new List<int>();
            List<int> Americana = new List<int>();
            List<int> Italiana = new List<int>();

            List<int> Ensaladas = new List<int>();
            List<int> Carnes = new List<int>();
            List<int> Sopas = new List<int>();

            List<int> Rapida = new List<int>();

            FactoryFlyweight f = new FactoryFlyweight();
            i = f.Adiciona("Hamburguesa");
            Americana.Add(i);
            Carnes.Add(i);
            Rapida.Add(i);

            i = f.Adiciona("Pizza");
            Italiana.Add(i);
            Rapida.Add(i);

            i = f.Adiciona("Caldo de Gallina");
            Peruana.Add(i);
            Sopas.Add(i);

            i = f.Adiciona("Wiscomsin Cheese");
            Ensaladas.Add(i);
            Americana.Add(i);

            i = f.Adiciona("Pollo asado");
            Rapida.Add(i);
            Peruana.Add(i);
            Carnes.Add(i);

            i = f.Adiciona("Ensalada de palta");
            Ensaladas.Add(i);
            Peruana.Add(i);

            i = f.Adiciona("Causa Rellena");
            Carnes.Add(i);
            Peruana.Add(i);
            //procesando las Rapidas
            Console.WriteLine("Comida Rapida:");
            foreach (int item in Rapida)

            {
                
                Receta recetita = (Receta)f[item];
                recetita.CalcularCosto();
                recetita.Mostrar();
                
            }
            Console.WriteLine("*****--------------*****");
            Console.ReadKey();

            Console.WriteLine("Comida Peruana:");
            foreach (int item in Peruana)
            {
                
                Receta recetita = (Receta)f[item];
                recetita.CalcularCosto();
                recetita.Mostrar();
            }
            Console.WriteLine("*****--------------*****");
            Console.ReadKey();

            Console.WriteLine("Comida Americana:");
            foreach (int item in Americana)
            {

                Receta recetita = (Receta)f[item];
                recetita.CalcularCosto();
                recetita.Mostrar();
            }
            Console.WriteLine("*****--------------*****");
            Console.ReadKey();

            Console.WriteLine("Ensaladas:");
            foreach (int item in Ensaladas)
            {
                Receta recetita = (Receta)f[item];
                recetita.CalcularCosto();
                recetita.Mostrar();
            }
            Console.WriteLine("*****--------------*****");
            Console.ReadKey();

            //Console.WriteLine("Añadir comida ya registrada:");
            //i = f.Adiciona("Pollo asado");
            //Console.WriteLine("*****--------------*****");
            //Console.ReadKey();

            //Console.WriteLine("Todos los aperitivos de la casa:");
            //int d = 0;
            //for (d= 0; d < f.Conteo; d++)
            //{
            //    Receta recetota = (Receta)f[d];
            //    //recetota.CalcularCosto();
            //    recetota.Mostrar();

            //}
            //Console.WriteLine("*****--------------*****");
            //Console.ReadKey();
        }
    }
}
