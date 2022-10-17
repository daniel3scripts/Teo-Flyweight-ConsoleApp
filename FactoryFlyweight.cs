using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightConsole
{
    class FactoryFlyweight
    {
        private List<IFlyweight> flyweights = new List<IFlyweight>();    
        private int conteo = 0; 

        public int Conteo { get => conteo; set => conteo = value; }  
        
        public int Adiciona( string pNombre)
        {
            bool existe = false;
            foreach (IFlyweight fly in flyweights)
            {
                if (fly.obtenerNombre() == pNombre)
                    existe = true;
            }
            if (existe)
            {
                Console.WriteLine("La comida ya existe , no se ha añadido");
                return -1;
            }
            else
            {
                Receta mireceta = new Receta();
                mireceta.ColocarNombre(pNombre);
                flyweights.Add(mireceta);
                conteo = flyweights.Count;
                return conteo -1;
            }
           
        }
        public IFlyweight this[int index]
        {
            get { return flyweights[index]; }
        }
    }
}
