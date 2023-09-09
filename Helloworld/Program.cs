using System.Diagnostics.CodeAnalysis;
using System.Xml.Schema;

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
          
          Console.ReadLine();
          Console.Clear();
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
         Console.ReadLine();
           
           
        
           Console.Clear();
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
         Console.ReadLine();

           Console.Clear();
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

          /*Midweek Day: 
         Solicita al usuario un número entre 1 y 7 y muestra el día de la 
         semana correspondiente, pero solo considerando los días laborables*/ 
         Console.ReadLine();
          
          Console.Clear();
          Console.WriteLine("MIDWEEK DAY");       
          Console.Write("Ingresa un número del 1 al 7: ");
          if (int.TryParse(Console.ReadLine(), out int dia))
          {
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;

                default:
                    Console.WriteLine("Número fuera del rango laboral");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida.");
        }

         /*Tax Calculator:
         Solicita al usuario su salario anual y, si este excede los 12000, 
         muestra el impuesto a pagar que es el 15% del excedente. */ 
         Console.ReadLine();
            
            Console.Clear();
            Console.WriteLine("TAX CALCULATOR");  
            Console.Write("Ingresa tu salario anual: ");
           if (decimal.TryParse(Console.ReadLine(), out decimal salarioAnual))
            {
            decimal salarioMinimo = 12000;

            if (salarioAnual > salarioMinimo)
            {
                decimal excedente = salarioAnual - salarioMinimo;
                decimal impuesto = 0.15m * excedente;

                Console.WriteLine("Tu salario anual excede los 12000 en: " + excedente);
                Console.WriteLine("Impuesto a pagar: " + impuesto);
            }
            else
            {
                Console.WriteLine("Tu salario anual no excede los 12000. No tienes que pagar impuesto.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida");
        }

         /*Remainder Finder:
         Solicita dos números y muestra el residuo de la división del 
         primero entre el segundo.*/
         Console.ReadLine();

          Console.Clear();
          Console.WriteLine("REMAINDER FINDER");
           Console.WriteLine("Ingresa el primer número: ");
           if (double.TryParse(Console.ReadLine(), out double numero4)) 
           {
               Console.Write("Ingresa el segundo número: ");
               if (double.TryParse(Console.ReadLine(), out double numero5))
               {
                  if (numero4 != 0)
                  {
                    double residuo = numero4 % numero5;
                    Console.WriteLine($"El residuo de {numero4} entre {numero5} es: {residuo}");
                  }
                 
                  else{                  
                    Console.WriteLine(" Ingresa un segundo número diferente de cero.");
                  } }
                
                  else
                  {
                  Console.WriteLine("Entrada no válida para el segundo número. Ingresa un valor numérico.");
                  }
                }
               else
                {
               Console.WriteLine("Entrada no válida para el primer número. Ingresa un valor numérico.");
                }

                
         /*Sum of events:
          Calcula y muestra la suma de los números pares entre 1 y 50. */
          Console.ReadLine();

          Console.Clear();
          Console.WriteLine("SUM OF EVENS");
          int suma = 0;
          for (int i = 2; i <=50; i+= 2)
          {
            suma +=i;
          }

          Console.WriteLine("La suma de los números pares entre 1 y 50 es: "+ suma);

          /*Fraction Difference:  
          Solicita al usuario los valores para dos fracciones y
          muestra la diferencia entre esas fracciones.*/
          Console.ReadLine();
          Console.Clear();

          Console.WriteLine();
          Console.WriteLine("FRACTION DIFFERENCE");

              {
                Console.Write("Ingresa el numerador de la primera fracción: ");
                if (int.TryParse(Console.ReadLine(), out int num1))
               {
                Console.Write("Ingresa el denominador de la primera fracción (distinto de cero): ");
                if (int.TryParse(Console.ReadLine(), out int den1) && den1 != 0)
              {
                Console.Write("Ingresa el numerador de la segunda fracción: ");
                 if (int.TryParse(Console.ReadLine(), out int num2))
                {
                    Console.Write("Ingresa el denominador de la segunda fracción (distinto de cero): ");
                    if (int.TryParse(Console.ReadLine(), out int den2) && den2 != 0)
                    {
                        // Calcular la diferencia de fracciones
                        int nuevoDenominadorComun = den1 * den2;
                        int nuevoNumerador1 = num1 * den2;
                        int nuevoNumerador2 = num2 * den1;

                        int diferenciaNumerador = nuevoNumerador1 - nuevoNumerador2;

                        Console.WriteLine($"La diferencia de las fracciones {num1}/{den1} y {num2}/{den2} es : {diferenciaNumerador}/{nuevoDenominadorComun}");
                    }
                    else
                    { Console.WriteLine("El denominador de la segunda fracción debe ser un número válido y distinto de cero.");}
                   }
                  else
                  { Console.WriteLine("El numerador de la segunda fracción debe ser un número válido."); }
                 }
                 else
                { Console.WriteLine("El denominador de la primera fracción debe ser un número válido y distinto de cero.");}
                }
                else
                 { Console.WriteLine("El numerador de la primera fracción debe ser un número válido.");}

            Console.ReadLine();
                 }


          /*String Length 
          Pide una palabra al usuario y muestra la longitud de esa palabra.*/
          Console.ReadLine();

         Console.Clear();
         Console.WriteLine("STRING LENGTH");
         Console.WriteLine("Introduce una palabra");
          string? palabra = Console.ReadLine();

            if (!string.IsNullOrEmpty(palabra))
            {
                int longitud = palabra.Length;
                Console.WriteLine($"Resultado: {longitud}");
            }
            else
            {
                Console.WriteLine("La entrada no puede estar vacía.");
            }

         /* Average of Four: 
          Pide al usuario cuatro números y muestra el promedio.*/
          Console.ReadLine();
         
         Console.Clear();
         Console.WriteLine("AVAREGE OF FOUR");

           Console.WriteLine("Digite el primer numero");
           double numeroA = double.Parse(Console.ReadLine());
           
            Console.WriteLine("Digite el Segundo numero");
           double numeroB = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el tercer numero");
           double numeroC = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el cuerto numero");
           double numeroD = double.Parse(Console.ReadLine());

            

            double promedio = (numeroA + numeroB + numeroC + numeroD) / 4;

            Console.WriteLine($"El promedio de los números ingresados es: {promedio}");


            /* Smallest of Five: 
          Pide al usuario cinco números y muestra el más pequeño. */
          Console.ReadLine();
         
         Console.Clear();
         Console.WriteLine("SMALLEST OF FIVE");

         double minimo = double.MaxValue;

         for (int i = 1; i <= 5; i++)
         {
          Console.Write($"Número {i}: ");
          double numeroq = double.Parse(Console.ReadLine());
          minimo = Math.Min(minimo, numeroq);
          }
           Console.WriteLine($"El número más pequeño es: {minimo}");

           /*Vowel Counter 
           Pide una palabra al usuario y devuelve el número de vocales en 
           esa palabra*/
           Console.ReadLine();
           Console.Clear();
           Console.WriteLine("VOWEL COUNTER");

           Console.WriteLine("Por favor, ingresa una palabra:");
           string text = Console.ReadLine().ToLower(); 
            int contadorVocales = 0;

            foreach (char letra in text)
          {
            if ("aeiou".Contains(letra))
            {
                contadorVocales++;
            }
           }

          Console.WriteLine($"El número de vocales en la palabra \"{text}\" es: {contadorVocales}");

    

         /*Factorial Flinder
           Pide un número al usuario y devuelve el factorial de ese número.*/
           Console.ReadLine();
           Console.Clear();
           Console.WriteLine("FACTORIAL FLINDER");

           if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
          {
            Console.WriteLine(n < 0 ? "El factorial no está definido para números negativos." : "Entrada no válida. Por favor, ingrese un número entero válido.");
            
            }

           long factorial = 1;

            for (int i = 2; i <= n; i++)

             factorial *= i;

              Console.WriteLine($"El factorial de {n} es: {factorial}");

           /*InRange Validator
          Pide un número al usuario y verifica si está en el rango de 10 a 20 
           (ambos incluidos). */

           Console.ReadLine();
           Console.Clear();
           Console.WriteLine("INRAGE VALIDATOR");

          Console.Write("Ingresa un número para verificar si está en el rango de 10 a 20: ");
         if (int.TryParse(Console.ReadLine(), out int numeroRango))
         {
           if (numeroRango >= 10 && numeroRango <= 20)
           {
           Console.WriteLine("Resultado: Está en el rango.");
           }
          else
           {
           Console.WriteLine("Resultado: Fuera del rango.");
            }
            }
          else
          {
          Console.WriteLine("Ingresa un número entero válido.");
          }
    







          







           







        }

    } 
}
