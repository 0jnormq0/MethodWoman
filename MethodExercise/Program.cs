using System;

namespace MethodExercise
{
    class Program
    {
        public static void personQandA()
        {
                        //Asking for name and receiving an answer from user
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            //Ask for fav color
            Console.WriteLine("What is your favorite color? ");
            //Allow for input of user response
            string favColor = Console.ReadLine();

            //Ask for fav animal
            Console.WriteLine("What is your favorite animal?");
            //Allow for input of user response
            string favAnimal = Console.ReadLine();

            //Ask for fav band
            Console.WriteLine("What is your favorite band?");
            //Allow for input of user response
            string favBand = Console.ReadLine();

            Console.WriteLine
                ($"Once upon a time, there was a strange, yet fascinating person named {userName}. " +
                $"Everything this lovely creature owned had to be a shade of their favorite color {favColor}. " +
                $"Even their favorite animal, a {favAnimal} named Ziggy Stardust, had a dyed coat of {favColor}. " +
                $"Whenever {userName} would listen to their favorite band {favBand}, " +
                $"they would pet their {favAnimal} and dream of shooting into space and floating weightless and peaceful in eternity." +
                $"The End.");                

        }

        //Addition Method
        public static int Add(int int1, int int2)
        {
            return int1 + int2;
        }

        //Bonus addition method
        public static int Sum(params int[] list)
        {
            int sum = 0;
            for(int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }

            return sum;
        }

        //Subtraction method
        public static int Subtract(int int1, int int2)
        {
            return int1 - int2;
        }
        //Multiplication method
        public static int Multiply(int int1, int int2)
        {
            return int1 * int2;
        }

        //Division method
        public static int Divide(int int1, int int2)
        {
            return int1 / int2;
        }

        //Modulus method
        public static int Mod(int int1, int int2)
        {
            int a = int1;
            int n = int2;
            double d = a / n;
            int wholeRemainder = a / n;
            double remainder = d - wholeRemainder;
            
            return (int)(remainder * n);

        }
        static void Main(string[] args)
        {
            personQandA();

            //Math Section//
            Console.WriteLine("Now it's time to do some Math!");
            //Addition
            Console.WriteLine("Enter a whole number: ");
            int int1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another whole number to add to the first one: ");
            int int2 = int.Parse(Console.ReadLine());

            //Add the two numbers
            int sum = Add(int1, int2);

            Console.WriteLine($"The sum is: {sum}!");

            //Updated Addition with extra number entry
            Console.WriteLine("Enter another number to add: ");
            int int3 = int.Parse(Console.ReadLine());
            int sumB = Sum(int1, int2, int3);

            Console.WriteLine($"The sum of the three numbers is: {sumB}!");

            Console.WriteLine("How about another number?");
            int int4 = int.Parse(Console.ReadLine());

            Console.WriteLine("And another!");
            int int5 = int.Parse(Console.ReadLine());

            int sumC = Sum(int1, int2, int3, int4, int5);

            Console.WriteLine("The sum of all five numbers is...");
            Console.WriteLine("Drum roll please....");
            Console.WriteLine($"{sumC}");

            //Subtraction

            Console.WriteLine("Enter a whole number: ");
            int intSub1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another whole number to subtract from the first: ");
            int intSub2 = int.Parse(Console.ReadLine());

            //Subtract the two numbers
            int difference = Subtract(intSub1, intSub2);

            Console.WriteLine($"The difference is: {difference}!");

            //Multiply
            Console.WriteLine("Enter a whole number: ");
            int intMult1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another whole number to multiply with the first: ");
            int intMult2 = int.Parse(Console.ReadLine());

            //Add the two numbers
            int product = Multiply(intMult1, intMult2);

            Console.WriteLine($"The product is: {product}!");

            //Divide
            Console.WriteLine("Enter a whole number: ");
            int intDiv1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another whole number to divide by the first: ");
            int intDiv2 = int.Parse(Console.ReadLine());

            //Add the two numbers
            int quotient = Divide(intDiv1, intDiv2);

            Console.WriteLine($"The quotient is: {quotient}!");

            //Modulus
            Console.WriteLine("Enter a whole number: ");
            int intMod1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another whole number to calculate the modulus: ");
            Console.WriteLine("Who's ever heard of a modulus?...");
            int intMod2 = int.Parse(Console.ReadLine());

            //Add the two numbers
            int remainder = Divide(intMod1, intMod2);

            Console.WriteLine($"The remainder is: {remainder}!");

        }

        

    }
}
