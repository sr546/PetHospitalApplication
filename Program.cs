using System;
using System.IO;

namespace PetsHospitalApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalHospital animal = new AnimalHospital("name");
             StreamWriter file = new StreamWriter("Log.txt"); 
            

            Console.WriteLine("::Pets Hospital Application:: \n" +
                                "*******************************");


            int taskno=0;
            do
            {
                Console.WriteLine(" 1. Search by Pet name \n 2. Search by Owner name \n 3. Search by date \n 4.Exit \n ( * --> mandatory )");
                Console.WriteLine("*Please enter the task number you want to perform:");

                try
                {
                    taskno = Convert.ToInt32(Console.ReadLine());


                    Console.ReadLine();

                    if (taskno == 1)
                    {
                        Console.Write("*Name of pet: ");
                        string petName = Console.ReadLine();
                        animal.PrintPetInfoByName(petName);
                        //PetTypeChoice(input.GetChoice("Enter choice"));
                    }
                    else if (taskno == 2)
                    {
                        Console.Write("*Name of the owner: ");
                        string ownerName = Console.ReadLine();
                        animal.PrintPetInfoByOwner(ownerName);
                    }
                    else if (taskno == 3)
                    {
                        Console.Write("*Enter day");
                        int day = Convert.ToInt32(Console.ReadLine());
                        Console.Write("*Enter Month");
                        int month = Convert.ToInt32(Console.ReadLine());
                        Console.Write("*Enter year");
                        int year = Convert.ToInt32(Console.ReadLine());
                        animal.PrintPetsBoarding(month, day, year);
                    }
                    else if (taskno == 4)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Write("\n\n Please enter valid task number..Press any key to return");
                        Console.ReadKey(true);
                    }
                }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Entered Invalid option...!!!!!");
                        file.WriteLine(e.Source);
                        Console.ReadKey();
                    }
                finally
                {
                  //nocode
                }


                } while (taskno != 4);
        }
                
    }
}