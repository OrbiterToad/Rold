using System;
using System.Diagnostics;

namespace Rold
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Constants.application = Process.GetProcessById(7988).ProcessName;
            
            var memoryAddress = new MemoryAddress(0x003B300C);

            
            
            
            Console.WriteLine(memoryAddress.getValue());
           
            memoryAddress.setValue(20);
            
            Console.WriteLine(memoryAddress.getValue());
        }
    }
}
