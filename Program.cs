using System;

namespace hospitalAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            //unKnown values
            string FirstName;
            string MiddleName;
            string LastName;
            string Gender;
            int Age;
            int BloodPressure;
            int Temperature;

            //Known values
            //these declared values represent the values we know such as the age, bloodpressur(bp) and tempreture(temp)'s limit.
            //it is declared here so the parameters could easily be changed
            int ageMargin = 50;
            int bpMargin = 130;
            int tempMargin = 37;

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

            //removed the equal sign here because i have reason to belive it is a bug
            // the first argument that is equal or lesser than in line 49 and is greater than or equal in line 57
            // it wouldn't test line 57 if line 47 is true
            if (Age < ageMargin && BloodPressure < bpMargin && Temperature < tempMargin)
            {
                Console.WriteLine("Patient Diagnosis...");
                Console.WriteLine("Name: " + LastName + " " + FirstName + " " + MiddleName + " ");
                Console.WriteLine("Age: " + Age + "yrs old");
                Console.WriteLine("Gender: " + Gender);
                Console.WriteLine("Status: You are Healthy");
            }
            else if(Age >= ageMargin && BloodPressure >= bpMargin && Temperature >= tempMargin)
            {
                Console.WriteLine("Patient Diagnosis...");
                Console.WriteLine("Name: " + LastName + " " + FirstName + " " + MiddleName + " ");
                Console.WriteLine("Age: " + Age + "yrs old");
                Console.WriteLine("Gender: " + Gender);
                Console.WriteLine("Your Health is in a Critical state, We will have to admit you immediately");
            } 
            else
            {
                Console.WriteLine("Patient Diagnosis...");
                Console.WriteLine("Name: " + LastName + " " + FirstName + " " + MiddleName + " ");
                Console.WriteLine("Age: " + Age + "yrs old");
                Console.WriteLine("Gender: " + Gender);
                Console.WriteLine("You will need to take some medication to keep you well");
            }
        }
    }
}

