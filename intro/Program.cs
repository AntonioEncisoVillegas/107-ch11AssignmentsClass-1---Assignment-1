using System;

namespace intro
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            p.Exc1();
            
            float res = p.sum(123.334f, 345.12f);
            Console.WriteLine(res);
            
            string a = p.GetTheAnswer();
            Console.WriteLine("The answer to life, universe and everything is: " + a);

            string b = p.GetMostExpensive();
            Console.WriteLine(" This number are the most expensive " + b);

               // get the mos expensive of thre products prices
             decimal exp = p.GetMostExpensive(0987.23m,123400.097m,-089342m);
             Console.WriteLine(exp);
        }

        string GetMostExpensive()
        {
            return "123400.097m";
        }

        string GetTheAnswer()
        {
            return "23";
        }
        float sum(float n1, float n2)
        {
            return n1 + n2;
        }
        void Exc1(){
            // Print numbers  Print numbers  1 to 14
            //except 7 
            for(int i=1; i <=14; i++)
            {
                if(i !=7 && i !=13)
                {
                   Console.WriteLine(i); 
                }
            }
        }


        void TestVariables()
        {
            // data_type 
            string name = "Antonio Enciso";
            int age =23;
            decimal total = 99.34m;
            float average=345.334f;
            bool found = false;

           
        }

        // return_type (params)
        string SayHello()
        {
            Console.WriteLine("Hello There!");
            int age= 17;

            if(age > 18) {
               return "Hi!"; 
            }
            
            return "";
        }
    }
}
