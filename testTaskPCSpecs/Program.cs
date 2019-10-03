using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace testTaskPCSpecs {
    class Program {
        static void Main() {
            PCSpecs PC = new PCSpecs();

            Console.WriteLine( "PC Name: " + PC.Name );
            Console.WriteLine( "Manufacturer: " + PC.Manufacturer );
            Console.WriteLine( "ListOfUsers:" );
            foreach( var item in PC.ListOfUsers ) {
                Console.WriteLine( " -" + item );
            }

            var performanceCounterCategories = PerformanceCounterCategory.GetCategories()

            .FirstOrDefault( category => category.CategoryName == "Memory" );

            var performanceCounters = performanceCounterCategories.GetCounters();

            Console.WriteLine( "Displaying performance counters for Memory category:--\n" );

            foreach( PerformanceCounter performanceCounter in performanceCounters ) {

                Console.WriteLine( performanceCounter.CounterName );

            }

            Console.ReadLine();
        }
    }
}
