 double n1;
            double n2; //variables that the numbers will be typed
            string calculation;

            Console.WriteLine("Type a number: ");
            calculation = Console.ReadLine();
            n1 = int.Parse(calculation);

            Console.WriteLine("Type another number: ");
            calculation = Console.ReadLine();
            n2 = int.Parse(calculation);

            double result;

            //performs the sum and prints to the console
            result = n1 + n2;
            Console.WriteLine("Sum: " + result);

            //performs the subtraction and prints to the console
            result = n1 - n2;
            Console.WriteLine("Subtraction: " + result);

            //performs the multiplication and prints to the console
            result = n1 * n2;
            Console.WriteLine("Multiplication: " + result);

            //performs the division and prints to the console
            result = n1 / n2;
            Console.WriteLine("Division: " + result);
