// Caitlin Sheeran
// 2/12/2025


namespace ThePasswordValidator

{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool passwordValid = false;

            // Tells the user the requirements for a password
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Please select a password that is:");
            Console.WriteLine("---------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Between 6 - 13 characters\nHas at least 1 Uppercase and 1 Lowercase letter\n1 Number\nNo Uppercase T\nNo Ammpersand (T)");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---------------------------------------------");



            while (passwordValid == false)
            {
                // Tells the user to write a password and then sends it to the class PasswordValidator
                Console.ForegroundColor= ConsoleColor.White;
                Console.Write("Enter your password: ");
                string userAnswer = Console.ReadLine();
                PasswordValidator newUser = new PasswordValidator(userAnswer);


                // Checks if the password is valid or not valid. The while loop breaks if the password is valid
                if (newUser.PasswordChecker(userAnswer))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("The password is valid!");
                    Console.WriteLine("---------------------------------------------");
                    passwordValid = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Password is not valid. Try again");
                    Console.WriteLine("---------------------------------------------");
                }
            }






            Console.ReadKey();
        }
    }
    public class PasswordValidator
    {
        //fields
        private string password = "n/a";

        //gets and sets
        public string Password
        {
            get { return this.password; }
            set {
                if (value.Length >= 6 && value.Length <= 13) this.password = value; 
            }
        }

        // constructor
        public PasswordValidator(string aPassword)
        {
            this.password = aPassword;
        }

        // Checks if the password is valid
        public bool PasswordChecker(string aPassword)

        {
            // counters for checking the password
            int lowerCaseCounter = 0;
            int upperCaseCounter = 0;
            int numberCounter = 0;


            foreach (char c in aPassword)
            {
                if (c.ToString() != "T" && c.ToString() != "&") // Makes sure these characters are not in the password
                {
                    // adds to the variables each time a upper, lower, or number is read
                    if (char.IsUpper(c)) upperCaseCounter++; 
                    else if (char.IsLower(c)) lowerCaseCounter++;
                    else if (char.IsDigit(c)) numberCounter++;
                }
                else return false;
 
            }

            // checks to make sure at least one of each requirement is met
            if (lowerCaseCounter >= 1 && upperCaseCounter >= 1 && numberCounter >= 1)
            {
                return true;
            }
            else return false;

        }





    }
}
