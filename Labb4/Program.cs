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
                
                Console.WriteLine("Invalid gender input. Valid inputs are Male,Female,NonBinary and Other.");
                return;
            }
            Name name = new Name();
            try
            {
                Console.WriteLine("What is the first name of the person you wish to Input?:");
                name.FirstName = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            Console.WriteLine("What is the last name of the person you wish to Input?: ");
            name.LastName = Console.ReadLine();

            Console.WriteLine($"Entered name: {name.FirstName} {name.LastName}  ");


            Hair hair = new Hair();

            Console.WriteLine("Enter person hair colour: ");
            hair.HairColour = Console.ReadLine();
            
            
             try
            {
                Console.WriteLine("Thanks! how long (in cm) is the hair?:  ");
                hair.HairLength = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Invalid hair length input. Valid inputs are numbers.");
                return;
            }



            Console.WriteLine($"Entered Hair: {hair.HairColour} {hair.HairLength} cm");
            DateTime birthday = new DateTime();
            try
            {
                Console.WriteLine("Okay! what is the birthday? Enter as dd,MM,yyyy : ");
                birthday = DateTime.Parse(Console.ReadLine());
                Console.WriteLine($"Entered birthday: {birthday:dd,MM,yyyy}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
                return;
            }

            Console.WriteLine("Okay! what is the eye colour?: ");
            string eyeColour = Console.ReadLine();
            Console.WriteLine($"Entered eye colour: {eyeColour}");
            
           Person person = new Person(gender, hair, birthday, eyeColour, name);
                       personList.Add(person);
            Console.WriteLine("Person added!");
            


            
            
        }
        }
    }
 
    
