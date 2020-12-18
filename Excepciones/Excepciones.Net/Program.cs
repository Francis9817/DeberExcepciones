using System;

namespace Excepciones.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Borracho oBorracho = new Borracho() { Nombre = "Pepito", NumeroDeCervezasQueHaTomado = 0 };
                oBorracho.NumeroDeCervezasQueHaTomado = 14;

                if (oBorracho.NumeroDeCervezasQueHaTomado >= 10)
                {
                    throw new Exception("Ocurrio un desastre");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("El borracho salio del bar");
            }     
        }
        
        
        public class Borracho
        {
            public string Nombre { get; set; }
            public int NumeroDeCervezasQueHaTomado { get; set; }

        }

    }


}
