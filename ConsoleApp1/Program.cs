using System;

namespace ConsoleApp1
{
    class Program
    {

        public static Program instance;
        
        static void Main(string[] args)
        {
            instance = new Program();
            
            Console.WriteLine("Please enter the binary code to translate ! ");
            String str = Console.In.ReadLine();
            
            Console.WriteLine(Program.instance.fromBinaryToDecimal(int.Parse(str)));
        }


        public int fromBinaryToDecimal(int binary)
        {
            return Convert.ToInt32(binary.ToString(), 2);
            
        }
        
    }
}
    