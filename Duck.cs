using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Duck 
    {
        public int Id;
        public Duck(int id){
            Id = id;
        }
        
       
        public void Voice(){
            Console.WriteLine("Quack!");
        }
        public void Fly(){
            Console.WriteLine("You missed me Fly, fly");
        }
        public void Die(){
            Console.WriteLine($"Duck {Id }:You shoted me, noooo!");
        }
        
    }
}