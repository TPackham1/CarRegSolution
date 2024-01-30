
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;
using System.Text;
using System.IO;


namespace CarRegSolution

{

    internal class Program
    {
        
        static void Main(string[] args)
        {


            string carRegAnswer = "-1";
            int carYearAnswer = -1;


            carRegAnswer = CarRegASW();

          /*  Console.WriteLine(hasCarReg);

            year = CarAge();
            Console.WriteLine(year);*/

        }


        static string CarRegASW()
        {
            string temp;
            Console.WriteLine("Does your car have a registration number? y/n");
            string input = Console.ReadLine();
                     
            while (true)
            {
                if (input == "n")
                {
                    temp =  "-1";
                    break;
                }

                else if (input == "y")
                {
                    temp = input;
                    break;
                }
                else
                {
                    Console.WriteLine("Please answer with y or n");
                    input = Console.ReadLine();
                }

            }

            return temp;
               
        }
        static bool CarAge()
        {

            return false;

        }

       
    }
    } 


