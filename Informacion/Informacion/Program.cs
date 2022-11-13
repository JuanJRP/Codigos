using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Informacion
{
    internal class Program
    {

        static void N_Serial()
        {
            
        }

        static void Main(string[] args)
        {
            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_ComputerSystem").Get()) 
            { 
                Console.WriteLine("Number Of Physical Processors: {0} ", item["NumberOfProcessors"]);
                Console.ReadLine();
            }
        }
    }
}
