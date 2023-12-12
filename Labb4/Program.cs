using System;

namespace Labb4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Person> person = new List<Person>();

                




            while (true)
            {
                // Att göra lägg till exeption handling till detta
                Console.WriteLine("Meny");
                Console.WriteLine("1. Add Person");
                Console.WriteLine("2. Print Saved People");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1-3): ");
                string choice = Console.ReadLine();

                }


        }



        static void addPerson()
        {
            Console.Write("Enter First Name: ");
            string firstNameInput = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastNameInput = Console.ReadLine();
            Console.Write("Enter one of these gender options (Male, Female, NonBinary, Other): ");
            string genderInput = Console.ReadLine();
            Console.Write("Enter Hair Colour");
            string hairColourInput = Console.ReadLine();
            Console.Write("Enter Hair Length");
            string hairLengthInput = Console.ReadLine();
            Console.Write("Enter Eye Colour");
            string eyeColourInput = Console.ReadLine();
            Console.Write("Enter Birthday (yyyy, 11, 10 : ");
            string birthdayInput = Console.ReadLine();




        }







    }
 }
    
