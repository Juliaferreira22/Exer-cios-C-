using System;

namespace ListaExercicio
{

    class Exe01
    {

        public static void Renderizar()

        {

            Console.WriteLine("Digite a altura:");
            int altrura = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura:");
            int largura = Convert.ToInt32(Console.ReadLine());

            int area = altrura*largura;

            Console.WriteLine("Área: " + area); 
            
        }
    }
}