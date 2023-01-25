using System.Diagnostics;
using System.Security.AccessControl;

namespace demirogCSharp
{
    class Program
    {
        static void Main(string[] args)
        {


            /* integer variable
            int number = 2;
            Console.WriteLine("number is a : {0}",number);

            long
            long age = 104654654654;
            Console.WriteLine(age);

            bool
            bool cond = false;
            if (cond)
            {
                Console.WriteLine("cond is a true");
            }else
            {
                Console.WriteLine("cond is a false");
            }
            

            Console.WriteLine(" ad : ");
            string name = "batuhan";

            int age = 20;
            char gender = 'A';
            long phoneNumber = 05555555555;

            var message = name+" "+age + " "+gender + " " + phoneNumber;
            
            Console.WriteLine(message);

            switch (gender)
            {
                case 'E':
                    Console.WriteLine("erkek");
                    break;
                case 'K':
                    Console.WriteLine("kadin");
                    break;
                default: 
                    Console.WriteLine("hata");
                    break;
            }

            int toplam = sum(8, 2);
            Console.WriteLine(toplam);
            Console.WriteLine(sum(5,8,12));

            Console.WriteLine(SumWithParam(10+8+7+5+9+1));

            // arrays

            string[] students = {
                "batuhan",
                "emre",
                "can"
            };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            // multidimensional arrays

            int[,] matrix = new int[3,3];
            matrix[0,0] = 1;
            matrix[0,1] = 2;
            matrix[0,2] = 3;
            matrix[1,0] = 4;
            matrix[1,1] = 5;
            matrix[1,2] = 6;
            matrix[2,0] = 7;
            matrix[2,1] = 8;
            matrix[2,2] = 9;

            for(int i = 0; i<3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine(" ");
            }


            if (isPrime(4))
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }



        }

        public static bool isPrime(int number)
        {   
            if (number < 2)
            {
                return false;
            }else if (number == 2)
            {
                return true;
            }
            else {
                for (int i = 2; i<number-1; i++)
                {
                    if(number % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static int sum(int a = 1, int b=1)
        {
            return a + b;
        }
        
        // method overloading
        public static int sum(int a = 1, int b = 1, int c = 1)
        {
            return a + b+ c;
        }

        // params keyword - foreach
        public static int SumWithParam(params int[] numbers) {

            return numbers.Sum();

        }
            */

            /* 
            Console.WriteLine("yeni tema");
            CustomerManager customerManager = new CustomerManager("batuhan",21,5000);
            customerManager.getContent();
            */

            PersonManager personManager = new PersonManager();
            personManager.add(new Customer { name="batuhan", lastName="topcu" });
            personManager.add(new Student { name = "berat", lastName = "topcu" });
        }
    }
    
}
