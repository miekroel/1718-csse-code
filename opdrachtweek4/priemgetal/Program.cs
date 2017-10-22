using System;

namespace week4
{
    class Program
    {

        static void Main(string[] args){
            int number = GeefGetal();
            if (number < 100){
                //Console.WriteLine(IsPriemgetal(GeefGetal()));
                for(int i = 0; i < (number+1); i++){
                    Console.WriteLine(i + IsPriemgetal(i));
                }
            }
            else{
                Console.WriteLine("het getal is niet kleiner dan 100");
            }
        }

        static int GeefGetal ()
        {
            Console.WriteLine("geef een getal in kleiner dan 100");
            int getal = Convert.ToInt32((Console.ReadLine()));
            return getal;
        }    

        static string IsPriemgetal(int getal){
            int tllr = 0;
            for (int i = 1; i < (getal+1); i++){
                if((getal%i) == 0){
                    //Console.WriteLine("{0} is deelbaar door: {1}", getal, i);
                    tllr++;
                }
            }
            if(tllr == 2){
                return " is een priemgetal";
            }else{
                return " is geen priemgetal";
 
            }
            
        }
    }
}
