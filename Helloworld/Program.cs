﻿namespace Ejercicios{
    class Program{
        static void Main(string[] args){
            
            /*Positive Power: 
            Solicita al usuario un número.
            Eleva este número al cuadrado solo si es positivo. */ 
         
         Console.WriteLine("POSITIVE POWER");       
           Console.WriteLine("Digite un número");
           if (int.TryParse(Console.ReadLine(), out int numero)) 
           {
           
               if (numero > 0)
               {
               int resultado = numero * numero;
               Console.WriteLine ("El número " + numero + " elevado al cuadrado es " + resultado);
               }

               else if (numero < 0)
               {
               Console.WriteLine (" El número es negativo");
               } 
              
               else 
               {
               Console.WriteLine(" Entrada no válida. Ingresa un número válido.");
               }
            } 

            else { Console.WriteLine(" Entrada no válida. Ingresa un número válido.");}



         /*Double or Triple:
          Solicita al usuario dos números. Si el primero es mayor, devuelva 
          su doble, de lo contrario devuelva el triple del segundo.*/ 
          
          Console.WriteLine();
          Console.WriteLine("DOUBLE OR TRIPLE");
           Console.WriteLine("Ingresa el primer número: ");
           if (int.TryParse(Console.ReadLine(), out int numero1)) 
           {
            Console.Write("Ingresa el segundo número: ");
          if (int.TryParse(Console.ReadLine(), out int numero2))
          {

            int resultado;

            if (numero1 > numero2)
                    {
                        resultado = numero1 * 2;
                    }
                    else
                    {
                        resultado = numero2 * 3;
                    }

                    Console.WriteLine("Resultado: " + resultado);
                }
                 else
                {
                    Console.WriteLine("Entrada no válida para el segundo número.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida para el primer número.");
            }







            












        }

    } 
}
