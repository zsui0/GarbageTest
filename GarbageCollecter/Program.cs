using System;
using System.Collections.Generic;

namespace GarbageCollecter
{
    class Garbage {
        static int Counter = 0;
        public Garbage() {
            Counter++;
            Console.WriteLine("Példányok száma: {0}",Counter);
        }
        ~Garbage(){
            Counter--;
            Console.WriteLine("Példányok száma: {0}", Counter);
        }
    }
    
    class Program
    {
        
        static void Main(string[] args)
        {

            while (true) {
                Garbage seged = new Garbage(); // 172115
            }
        }
    }
}
