using System;

namespace week4 {
    class Program {
        static void Main(string[] args) {
            int result = geefWillekeurigGetal();
            uitvoerenFibonacci(result);
        }
        
        static int geefWillekeurigGetal() {
            Console.WriteLine("lengte reeks fibonacci?");
            int lengte = Convert.ToInt32((Console.ReadLine()));
            return lengte;
        }

        static void uitvoerenFibonacci(int result) {
            int[] a = new int[result];
            a[0] = 0;
            a[1] = 1;
            for (int i = 2; i < result; i++) {
                a[i] = a[i - 1] + a[i - 2];
            }
            int teller = 0;
            foreach(int j in a) {
                Console.WriteLine(a[teller]);
                teller++;
            } 
        }
    }
}