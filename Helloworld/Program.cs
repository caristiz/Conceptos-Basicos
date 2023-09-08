namespace Ejercicios{
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


         /*Root or Square:
         Pide al usuario un número. Si es positivo, devuelve su raíz
         cuadrada, de lo contrario, devuelve su cuadrado */
           
           
        
           Console.WriteLine();
           Console.WriteLine("ROOT OR SQUARE");       
           Console.WriteLine("Digite un número");
           if (double.TryParse(Console.ReadLine(), out double numero3)) 
           {

             if (numero3 > 0)
               {
               double resultado = Math.Sqrt(numero3);
               Console.WriteLine ("La raiz cuadrad del número " + numero3 + " es " + resultado);
               }

              else
              {
                double resultado = numero3 * numero3;
                Console.WriteLine ("El número " + numero3 + " elevado al cuadrado es " + resultado);
              }
           }
        
          else 
          {
             Console.WriteLine("Entrada no válida.");
           }   


         /*Circle Perimeter:
         Pide al usuario el radio de un círculo y calcula su perímetro.*/

           Console.WriteLine();
           Console.WriteLine("CIRCLE PERIMETER");       
           Console.WriteLine("Digite el radio de la circunferencia");
           if (double.TryParse(Console.ReadLine(), out double radio))
            {
                if (radio > 0)
                {
                    double perimetro = Math.PI * radio * 2;
                    Console.WriteLine( "El perímetro es: " + perimetro);
                }
                else
                {
                    Console.WriteLine("Radio no válido. Debe ser mayor que 0.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida");
            }














           







        }

    } 
}
