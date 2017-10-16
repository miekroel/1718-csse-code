using System;
using System.Collections.Generic;
using System.Collections;



namespace opdracht_tafels
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //getal opvragen
            Console.WriteLine("geef een eerste getal in");
            int getal = Convert.ToInt32((Console.ReadLine()));
            // uitschrijven vermenigvuldigingstal
            Console.WriteLine("vermenigvuldigingstal: {0}", getal);
            //nieuwe array aanmaken met 10 plaatsen
            int[] a = new int[11];
            //nieuwe list aanmaken 
             List <int> lijst = new List <int>();

            //nieuwe hashtable aanmaken
            Hashtable tafels = new Hashtable();
                    

            //loopen voor de tafels tot *10
            for (int i = 0; i < 11; i++){
                //de tafel resultaten opslaan in de array
                a[i]= getal*i;
                //resultaten opslaan in een lijst
	            lijst.Add(i*getal);

                //resultaten opslaan in hashtable
               tafels.Add(i,i*getal);
	
               //Console.WriteLine("{0}*x{1}={2}",i, getal, getal*i);
            }
            Console.WriteLine("array");
            //uitschrijven van waarden in array
            int teller = 0;
            foreach(int j in a){
                Console.WriteLine("{0}x{1}={2}",teller, getal, j);
                teller++;
            }

            Console.WriteLine("list");
            //uitschrijven list
            teller = 0;
            foreach(int j in lijst){
                Console.WriteLine("{0}x{1}={2}",teller, getal, j);
                teller++;
            }

            Console.WriteLine("hashtable");
            //uitschrijven hashtable
            for(int i=0; i<11; i++){
                Console.WriteLine("{0}x{1}={2}",i, getal, tafels[i]);
            }
          
        }
    }
}
