using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statements
{
     class statements
    {
       
        public void first() //if-else statement
        {
            int n = Convert.ToInt32(Console.ReadLine());
            
            if(n%2==0)
            {
                Console.WriteLine("n is even number");
            }
            else
            {
                Console.WriteLine("n is not even number");

            }

        }
        public void second() //if-else if ladder
        {
            int val = Convert.ToInt32(Console.ReadLine());

            if (val==1)
            {
                Console.WriteLine("n is one");
            }
            else if(val==2)
            {
                Console.WriteLine("n is two");

            }
            else if(val==3)
            {
                Console.WriteLine("n is three");
            }
            else
            {
                Console.WriteLine("more than three");
            }

        }
        public void four() //switch statement
        {
            int n = 3;
            switch (n)
            {

                case 1:
                    Console.WriteLine("number is 1");
                    break;
                case 2:
                    Console.WriteLine("number is 2");
                    break;
                case 3:
                    Console.WriteLine("number is 3");
                    break;
                case 4:
                    Console.WriteLine("number is 4");
                    break;
                default:
                    Console.WriteLine("no number is matched");
                    break;

            }
        }


    }
    class loops
    {
        
        public void third() //do-while loop
        {

            int i = Convert.ToInt32(Console.ReadLine());

            do
            {
                
                Console.WriteLine(i);
                i++;
            } while (i <10);
            

            
        }
        public void fifth()//while
        {

            int i = Convert.ToInt32(Console.ReadLine());

            while (i < 20) 
            {

                Console.WriteLine(i);
                i++;
            } 



        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            statements state = new statements();//object creation for statements class
            state.first();
            state.second();
            loops obj = new loops();//object creation for loops class
            obj.third();
            state.four();
            obj.fifth();
            Console.ReadKey();
        }
    }
}
