using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Linq;

namespace Labb4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Person> personList = new List<Person>();
            
                




            while (true)
            {
                // Att göra lägg till exeption handling till detta
                Console.WriteLine("Meny");
                Console.WriteLine("1. Add Person");
                Console.WriteLine("2. Print Saved People");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1-3): ");
                string choice = Console.ReadLine();


                switch (choice)
                {

                    case "1":
                        addPerson(personList);


                        break;


                        case "2":
                        foreach (Person person in personList)
                        {
                            Console.WriteLine(person);
                        }
                        break;

                        case "3":
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;



                }


                }


        }



        static void addPerson(List<Person> personList)
        {

            Gender gender = new Gender();
            Console.Write("Enter a gender (Male, Female, NonBinary, Other): ");
            if (Enum.TryParse(Console.ReadLine(), true, out gender))
            {
                
                Console.WriteLine($"Inputed gender: {gender}");
            }
            else
            {

                // Failed to parse the gender
                
                Console.WriteLine("Invalid gender input.");
                return;
            }
            Name name = new Name();

            Console.WriteLine("Okay! and what the first name?: ");
            name.FirstName = Console.ReadLine();
            Console.WriteLine("Thanks! and what is the last name?: ");
            name.LastName = Console.ReadLine();

            Console.WriteLine($"Entered name: {name.FirstName} {name.LastName}  ");


            Hair hair = new Hair();

            Console.WriteLine("Okay! what colour is the hair?: ");
            hair.HairColour = Console.ReadLine();
            Console.WriteLine("Thanks! how long (in cm) is the hair?:  ");
            hair.HairLength = int.Parse(Console.ReadLine());
            Console.WriteLine($"Entered Hair: {hair.HairColour} {hair.HairLength} cm");
            DateTime birthday = new DateTime();
            Console.WriteLine("Okay! what is the birthday? Enter as dd,MM,yyyy : ");
            birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Entered birthday: {birthday:dd,MM,yyyy}");
            Console.WriteLine("Okay! what is the eye colour?: ");
            string eyeColour = Console.ReadLine();
            Console.WriteLine($"Entered eye colour: {eyeColour}");
            
           Person person = new Person(gender, hair, birthday, eyeColour, name);
                       personList.Add(person);
            Console.WriteLine("Person added!");
            


            
            
        }
        }
    }
 
    
