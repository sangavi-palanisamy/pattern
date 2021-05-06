using System;


namespace pattern
{

     class pattern
    {
        public void star1()
        {
            int i, j;
            int n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for(j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
        public void star2()
        {
            int i, j,l;
            int n = Convert.ToInt32(Console.ReadLine());
           for (i = n; i >=1; i--)
            {
                for (j = 1; j <i; j++)
                {
                    Console.Write(" ");
                }
                for(l=n;l>=i;l--)
                {
                    Console.Write("*");

                }
               
                Console.WriteLine();
            }
          
            

        }
       public void star3()
        {
            int i, j, l=0;
             int n = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                for(j=1;j<=(n-i);j++)
                {
                    Console.Write(" ");
                }
                for(l=1;l<i*2;l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            

            
        }
        
    }
    class Program
    {
       

        static void Main(string[] args)
        {
            pattern obj = new pattern();
            obj.star1();
            obj.star2();
            obj.star3();
            Console.ReadKey();


        }
    }
}
