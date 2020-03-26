using System;

namespace conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = "";
            string MiddleName = "";
            string LastName = "";
            string Gender = "";
            int Age = 0;
            int BloodPressure = 0;
            int Temperature = 0;

            Console.Write("Please enter First Name: ");
            FirstName = Console.ReadLine();

            Console.Write("Please enter Middle Name: ");
            MiddleName = Console.ReadLine();

            Console.Write("Please enter Last Name: ");
            LastName = Console.ReadLine();

            Console.Write("Please what is your Gender: ");
            Gender = Console.ReadLine();

            Console.Write("Welcome To Royal Care Hospital!, Enter your Age: ");
            Age = int.Parse(Console.ReadLine());

            Console.Write("Enter your Blood Pressure: ");
            BloodPressure = int.Parse(Console.ReadLine());

            Console.Write("Enter your Temperature: ");
            Temperature = int.Parse(Console.ReadLine());

            if (Age <= 50 && BloodPressure <= 130 && Temperature <= 37)
            {
                Console.WriteLine(LastName + " " + FirstName + " " + MiddleName + " " + "You are Healthy");
            }
            else if(Age >= 50 && BloodPressure >= 130 && Temperature >= 37)
            {
                Console.WriteLine(LastName + " " + FirstName + " " + MiddleName + " " + "You will need to take some medication to keep you well");
            } 
            else
            {
                Console.WriteLine(LastName +" " + FirstName +" " + MiddleName +" " + "Your Health is in a Critical state, We will have to admit you immediately");
            }
        }
        
    }
}
