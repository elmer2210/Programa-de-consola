using System;

namespace tarea
{
    class DescripcionPersonal
    {
        static void Main(string[] args)
        {
            if(args.Length>0){
                Console.WriteLine(args[0]);
            }else{
                Console.WriteLine("No existen argumentos");
            }
            Console.WriteLine("Escribe tu nombre:");
            string nombre =  Console.ReadLine();
            Console.WriteLine("Carrera:");
            string carrera =  Console.ReadLine();
            Console.WriteLine($"Hola mi nombre es {nombre}, y estudio en la facultad {carrera}");
            Console.ReadKey(); 
        }
    }
}
