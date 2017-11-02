using System;
using System.Collections.Generic;

namespace participantes
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            List<string> personas = new List<string>();
            Random aleatorio = new Random();
            int ganador;
            
            
            while (!nombre.Equals("jugar"))
            {
                
                Console.WriteLine("Escribe el nombre del participante y enter para añadir, escribe jugar y enter para empezar el sorteo:  ");
                nombre = Console.ReadLine();
                Console.WriteLine();
                if (nombre.Equals("jugar"))
                {
                    break;
                }
                personas.Add(nombre);
            }
            Console.WriteLine();
            Console.WriteLine("Personas Inscritas");
            Console.WriteLine("------------------");
            foreach (string persona in personas)
            {
                Console.WriteLine(persona);
            }
            Console.ReadKey(); 
            Console.WriteLine();
            ganador = aleatorio.Next(0,personas.Count);
            //Console.WriteLine($"numero aleatorio {ganador}");
            Console.WriteLine("El ganador es " + personas[ganador]);

            Console.ReadKey();
            
            
        }
    }
}
