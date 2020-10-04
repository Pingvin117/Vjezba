using static System.Console;
using System;


namespace Tajmer_Za_mlijeko
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=10;i>=0;i--){
                if(i==0){
                    Console.WriteLine("Mlijeko je gotovo");
                    break;
                }
                else{
                    Console.WriteLine($"Mlijeko ce biti gotovo za {i} sekundi");
                }
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
