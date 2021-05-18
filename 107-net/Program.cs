using System;

namespace _107_net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            // p.Exc1();
            decimal mayor=p.mayor(1.25m,5.6m,10.58m);
            Console.WriteLine("Mayor:"+mayor);
        }

        decimal mayor(decimal v1, decimal v2, decimal v3){
            if(v1 > v2 && v1> v3)
                return v1;
            if(v2 > v1 && v2> v3)
                return v2;
            if(v3 > v1 && v3> v2)
                    return v3;
            return v1;
        }

        void Exc1()
        {
            for(int i=0; i<14;i++)
            {
               if(i!=7)
               Console.WriteLine(i); 
               
            }
        }
        void testVariable()
        {
            //data_type name;
            string name="Francisco Cardenas";
            int age=28;
            decimal total=99.34m;
            float average =342.344f;
            bool found=true;
        
        }

        string SayHello(){
            Console.WriteLine("HEllo there!");
            return "Hi";
        }
    }
}
