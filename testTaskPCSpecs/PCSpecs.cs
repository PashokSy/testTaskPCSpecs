using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;

namespace testTaskPCSpecs {
    class PCSpecs {
        public string Name { get; private set; }
        public string Manufacturer { get; private set; }
        public List<string> ListOfUsers { get; private set; } = new List<string>();
        public int CpuLoad {
            get {
                var cpuPerformanceCounter = new PerformanceCounter( "Processor" , "% Processor Time" , "_Total" );
                cpuPerformanceCounter.NextValue();
                System.Threading.Thread.Sleep( 1000 );
                return Convert.ToInt32( cpuPerformanceCounter.NextValue() );
            }
        }
        public int RamLoad { get; set; }

        public PCSpecs() {
            Name = Environment.MachineName;
            getManufacturer();
            getListOfUsers();
        }

        void getManufacturer() {
            ManagementClass managementClass = new ManagementClass( "Win32_ComputerSystem" );
            ManagementObjectCollection win32CS = managementClass.GetInstances();
            foreach( var item in win32CS ) {
                Manufacturer = item[ "Manufacturer" ].ToString();
            }
        }

        void getListOfUsers() {
            ManagementClass managementClass = new ManagementClass( "Win32_UserAccount" );
            ManagementObjectCollection win32UA = managementClass.GetInstances();
            foreach( var item in win32UA ) {
                ListOfUsers.Add( item[ "Name" ].ToString() );
            }
        }

        public void getRamLoad() {
            ManagementClass managementClass = new ManagementClass( "Win32_OperatingSystem" );
            ManagementObjectCollection win32OS = managementClass.GetInstances();
            foreach( var item in win32OS ) {
                var totalMemorySize = Convert.ToInt32( item[ "TotalVisibleMemorySize" ] );
                var freeMemorySize = Convert.ToInt32( item[ "FreePhysicalMemory" ] );
                // /1024 to covert in MBytes
                RamLoad = ( totalMemorySize - freeMemorySize ) / 1024;
            }
        }
    }
}