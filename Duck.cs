using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Duck 
    {
        public int Id;
        public Duck(){
            Random rnd = new Random();
        Id = rnd.Next(1, 6);
        }
        
       
        void Voice(){
            Console.WriteLine("Quack!");
        }
        void Fly(){
            Console.WriteLine("Fly, fly");
        }
        void Die(){
            Console.WriteLine("You shoted me, noooo!");
        }
        public static void Ducks(){
            Duck  duckForShot = new Duck();

            Console.WriteLine(duckForShot.Id);
        }
    }
}