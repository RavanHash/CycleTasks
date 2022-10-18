namespace CycleTasks
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Cycles23();
        }

        private static int GetIntegerFromConsole()
        {
            int number;

            Console.Write("Enter integer number: ");

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
            }

            return number;
        } 
        
        private static double GetDoubleFromConsole()
        {
            double number;

            Console.Write("Enter integer number: ");

            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
            }

            return number;
        }

        // Первые пять задач решил в универе 

        private static void Cycles6()
        {
            Console.WriteLine("User gives 1 number a. Output a-th number of Fibonacci’s series. (F.e. : 1 1 2 3 5 8 13 21 …)");


            int n = GetIntegerFromConsole();

            int num1 = 1;
            int num2 = 1;
            int num3 = 1;

            for (int i = 2; i < n; i++)
            {
                num3 = num1 + num2;

                num1 = num2;
                num2 = num3;
            }

            Console.WriteLine(num3);
        }
        
        private static void Cycles7()
        {
            Console.WriteLine("User gives 2 numbers. Find out their greatest common divisor using Euclid’s algorithm.)");

            int a = GetIntegerFromConsole();
            int b = GetIntegerFromConsole();

            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }

            Console.WriteLine(a);
        }

        private static void Cycles8()
        {
            Console.WriteLine("User gives a positive number that is power of another number to 3. Find out that number using half division method.");

            int n = GetIntegerFromConsole();

            int a = 1;
            int temp = n;
            int m = n / 2;

            while (n != m * m * m)
            {
                Console.WriteLine("a= " + a + ", b= " + temp + ", m= " + m);

                if (n > m * m * m) 
                    a = m;
                else 
                    temp = m;

                m = (a + temp) / 2;
            }
            Console.WriteLine(m);
        }

        private static void Cycles9()
        {
            Console.WriteLine("User gives 1 number. Find out amount of odd digits in this number.");

            int n = GetIntegerFromConsole();

            int odd = 0;

            while(n != 0)
            {
                if(n % 2 != 0)
                {
                    odd++;
                }

                n /= 10;
            }

            Console.WriteLine(odd);
        }
        
        private static void Cycles10()
        {
            Console.WriteLine("User gives 1 number. Find out mirrored number to that one");

            int n = GetIntegerFromConsole();

            int rev = 0;

            while(n != 0)
            {
                rev *= 10;
                rev += n % 10;

                n /= 10;
            }

            Console.WriteLine(rev);
        }

        // Есть ли более хорошее решение?
        private static void Cycles12()
        {
            Console.WriteLine("User gives 2 numbers. Find out if there are similar digits in those numbers.");

            int a = GetIntegerFromConsole();
            int b = GetIntegerFromConsole();

            int c = b;
            while(a != 0)
            {
                int temp = a % 10;

                while(b != 0)
                {
                    if (b % 10 == temp)
                    {
                        Console.WriteLine("YES");
                        a = 0;
                        break;
                    }
                    else
                    {
                        b /= 10;
                    }
                }

                if(b == 0)
                {
                    Console.WriteLine("NO");
                    break;
                }

                a /= 10;
                b = c;
            }
        }

        // 13, 14, 15 похожи 
        private static void Cycles14_2()
        {
            Console.WriteLine("User gives х, and positive n. Calculate: 2) x/ 1! + x^2 / 2! +...+ x^n / n!");

            double x = GetDoubleFromConsole();
            double n = GetDoubleFromConsole();

            double t = x;
            double sum = 0;


            for (int i = 1; i < n; i++)
            {
                x *= t;

                sum += x / (i * (i + 1));
            }

            sum += t;


            Console.WriteLine(sum);
        }

        // Не понял условие
        private static void Cycles16()
        {

        }

        // 17, 18, 19, 20 похожи
        private static void Cycles20()
        {
            int sum = 0;

            int number = GetIntegerFromConsole();

            int n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("Entered number is a perfect number");
            }
            else
            {
                Console.WriteLine("Entered number is not a perfect number");
            }
        }

        // 21, 22, 23 похожи, а 6 и 23 одно и тоже
        private static void Cycles23()
        {
            Console.WriteLine("User gives 1 number a. Output a-th number of Fibonacci’s series. (F.e. : 1 1 2 3 5 8 13 21 …)");


            int n = GetIntegerFromConsole();

            int num1 = 1;
            int num2 = 1;
            int num3 = 1;

            for (int i = 2; i < n; i++)
            {
                num3 = num1 + num2;

                num1 = num2;
                num2 = num3;
            }

            Console.WriteLine(num3);
        }
    }
}