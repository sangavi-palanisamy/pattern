using System;


namespace Acess_specifiers
{
    
   
    
    class sum
    {
        protected  int x =10,y=2,z;
    }
     class PublicTest:sum
   
    
    {
        int a = 10, b = 40, c,d;
     
        public void addition()
        { 
            c = a + b;
            
            Console.WriteLine(c);
        }
        public void mul()
        {
            z = x * y;
            Console.WriteLine(z);
        }
        public void div()
        {
            int i,n=5;
          
            for(i=0;i<n;)
            {
                Console.WriteLine("c#");
                i++;
                
            }
        }
       
        
    }
    class Program
    {
       public static void Main(string[] args)
        {
            PublicTest obj = new PublicTest();
            obj.addition();
            obj.mul();
            obj.div();
            Console.ReadKey();
        }
    }
}
