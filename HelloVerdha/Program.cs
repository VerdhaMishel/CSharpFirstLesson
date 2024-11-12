using System;

namespace HelloVerdha
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Note
            Console.WriteLine("Hello Verdha");
            Console.WriteLine("I am a girl");

            // Variables (Container which stores values of data types)
            //String within commas (Data Type)
            string myName;
            myName = "Verdha";
            string firstName = "Verdha";
            string lastName = "Mishel";
            Console.WriteLine(firstName + lastName);//without space
            Console.WriteLine(firstName + " " + lastName);//with space, string concatination
            Console.WriteLine($"First Name: {firstName} ");// string interpolation
            Console.WriteLine($"Last Name: {lastName}");

            //integars int(whole numbers) (Data type)
            int myNum = 15;// declred and initialized the variable same time
            Console.WriteLine(myNum);
            int myNumber;// declared variable separately
            myNumber = 20;// initialized the above variable
            Console.WriteLine($"My Number : {myNumber} ");

            int x = 5;
            int y = 10;
            int z = 20;
            Console.WriteLine($"Addition: {(x + y + z)}");
            Console.WriteLine(x - y - z);
            Console.WriteLine(x * y * z);
            Console.WriteLine(x / y / z);

            //Double (Data type)
            double myDoubleNumber = 5.9D;
            Console.WriteLine(myDoubleNumber);

            //Character (Data Type)
            char myLetter = 'V';
            Console.WriteLine(myLetter);

            //Boolean (Data Type)
            bool isCSharpFun = true;
            Console.WriteLine(isCSharpFun);

            bool isLondonBeautiful = false;
            Console.WriteLine(isLondonBeautiful);

            //Constant (keyword) (constant value is unchangeable, only readable)
            const int year = 2024;

            //Date, time, year
            Console.WriteLine("Today is " + DateTime.Now); 
            Console.WriteLine("Year is " + DateTime.Now.Year);














        }
    }
}