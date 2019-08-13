using System;
using System.Collections.Generic;

namespace URI_1021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número de testes: ");
            int n = int.Parse(Console.ReadLine());
            string valorLed;
            List<string> list = new List<string>();
            int sumLed = 0;

            for (int i = 0; i < n; i++)
            {
                valorLed = Console.ReadLine();
                list.Add(valorLed);
            }

            for (int i = 0; i < n; i++)
            {
                var test = list[i].ToCharArray();
                for (int j = 0; j < test.Length; j++)
                {
                    if (test[j] == '1')
                    {
                        sumLed += 2;
                    }
                    else if (test[j] == '2')
                    {
                        sumLed += 5;
                    }
                    else if (test[j] == '3')
                    {
                        sumLed += 5;
                    }
                    else if (test[j] == '4')
                    {
                        sumLed += 4;
                    }
                    else if(test[j] == '5')
                    {
                        sumLed += 5;
                    }
                    else if (test[j] == '6')
                    {
                        sumLed += 6;
                    }
                    else if (test[j] == '7')
                    {
                        sumLed += 3;
                    }
                    else if (test[j] == '8')
                    {
                        sumLed += 7;
                    }
                    else if (test[j] == '9')
                    {
                        sumLed += 6;
                    }
                    else if (test[j] == '0')
                    {
                        sumLed += 6;
                    }
                }
                Console.WriteLine(sumLed + " Leds");
                sumLed = 0;
            }
        }
    }
}
