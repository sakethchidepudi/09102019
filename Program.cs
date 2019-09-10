using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How many years of experience do you have in professional programming?");
            
        
            
                
                int input = int.Parse(Console.ReadLine());


                if (input == 0)
                {
                    Console.WriteLine("Needslot of practice");
                }
                else if (input == 1)
                {
                    Console.WriteLine("looks like you have a lot of experience");
                }
                else if (input == 2)
                {
                    Console.WriteLine("Wow! you have been doing this for a little while");
                }
                else
                {
                    Console.WriteLine("expert");
                }
                           
                
               
        } // end of Main
    } // end of class
} // end of namespace