using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightConsole
{
    class Receta: IFlyweight
    {
        private string nombre;
        private double costo;
        private double venta;

        public void CalcularCosto()
        {
            foreach (var item in nombre)
            {
                costo += (int)item;
                venta = costo * 1.30;
            }
                
            
        }

        public void ColocarNombre( string pNombre)
        {
            nombre = pNombre;   
        }

        public void Mostrar()
        {
            Console.WriteLine("{0} cuesta: {1}",nombre,venta);
            //Console.ReadKey();
        } 
        public string obtenerNombre()
        {
            return nombre;
        }
    }
}
