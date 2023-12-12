using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    public class Person
    {
        public Name Name { get; set; }
        public Hair Hair { get; set; }
        public Gender Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string EyeColour { get; set; }



        public Person(Gender gender, Hair hair, DateTime birthday, string eyeColour, Name name)
        {
            Gender = gender;
            Hair = hair;
            Birthday = birthday;
            EyeColour = eyeColour;
            Name = name;
        }
        public override string ToString()
        {
            return $"\nName: {Name.FirstName} {Name.LastName} " +
                    $"\nGender: {Gender}" +
                    $"\nHair Length: {Hair.HairLength} Centimeters" +
                    $"\nHair Color: {Hair.HairColour}" +
                    $"\nBirthday: {Birthday:dd,MM,yyyy}" +
                    $"\nEye Colour: {EyeColour}";
        }






    }
}
