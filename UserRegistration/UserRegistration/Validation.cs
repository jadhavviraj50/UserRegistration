using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    public class Validation
    {


        public void ValidateFirstName()
        {

            Console.WriteLine("Enter First Name : ");
            string name = Console.ReadLine();

            string FIRSTNAME_REGEX = "^[A-Z]{1}[a-zA-Z]{2,}$";
            Regex reg = new Regex(FIRSTNAME_REGEX);

            if (reg.IsMatch(name))
            {
                Console.WriteLine("First Name is valid");
            }
            else
            {
                Console.WriteLine("Verify First Name Again");
            }
        }
        public void ValidateLastName()
        {
            Console.WriteLine("Enter Last Name : ");
            string Name = Console.ReadLine();

            string LastName = "^[A-Z]{1}[a-zA-Z]{2,}$";
            Regex reg = new Regex(LastName);

            if (reg.IsMatch(Name))
            {
                Console.WriteLine("Last Name is valid");
            }
            else
            {
                Console.WriteLine("Verify Last Name Again");
            }
        }
    }
}