using System;

namespace ListaExercicio
{

    class Exe02
    {

        public static void Renderizar()

        {
            
            int idade = Convert.ToInt32(Console.ReadLine());


            if (idade <= 13)

            {
                Console.WriteLine("Criança"); 
            }

            else  if (idade <= 18)
            {
                Console.WriteLine("Adolecente"); 
            }

             else  if (idade <= 60)
            {
                Console.WriteLine("Adulto"); 
            }

             else  if (idade > 60 )
            {
                Console.WriteLine("Idoso"); 
            }
            
        }
    }
}