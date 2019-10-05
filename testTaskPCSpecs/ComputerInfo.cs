using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;

namespace PCInfo {
    public class ComputerInfo {
        public string Name { get; private set; }
        public string Manufacturer { get; private set; }
        public int CpuLoad { get; private set; }
        public int RamLoad { get; private set; }
        public string[] ListOfUsers {
            get {
                int usersCount = listOfUsers.Count;
                string[] list = new string[ usersCount ];
                for( int i = 0; i < usersCount; i++ ) {
                    list[ i ] = listOfUsers[ i ];
                }
                return list;
            }
        }

        List<string> listOfUsers;

        public ComputerInfo() {
            UpdateComputerInfo();
        }

        public void UpdateComputerInfo() {
            Name = gatherName();
            Manufacturer = gatherManufacturer();
            CpuLoad = gatherCpuLoad();
            RamLoad = gatherRamLoad();
            listOfUsers = gatherListOfUsers();
        }

        string gatherName() {
            return Environment.MachineName;
        }

        string gatherManufacturer() {
            string manufacturer = "unknown";
            ManagementClass managementClass = new ManagementClass( "Win32_ComputerSystem" );
            ManagementObjectCollection moc = managementClass.GetInstances();
            foreach( ManagementBaseObject item in moc ) {
                manufacturer = item[ "Manufacturer" ].ToString();
            }
            return manufacturer;
        }

        int gatherCpuLoad() {
            var cpuCounter = new PerformanceCounter( "Processor" , "% Processor Time" , "_Total" );

            // без этого часто выдает 0
            cpuCounter.NextValue();
            System.Threading.Thread.Sleep( 1000 );

            return Convert.ToInt32( cpuCounter.NextValue() );
        }

        int gatherRamLoad() {
            int ramLoad = 0;
            ManagementClass managementClass = new ManagementClass( "Win32_OperatingSystem" );
            ManagementObjectCollection moc = managementClass.GetInstances();
            foreach( var item in moc ) {
                var totalMemorySize = Convert.ToInt32( item[ "TotalVisibleMemorySize" ] );
                var freeMemorySize = Convert.ToInt32( item[ "FreePhysicalMemory" ] );
                // /1024 to covert in MBytes
                ramLoad = ( totalMemorySize - freeMemorySize ) / 1024;
            }
            return ramLoad;
        }

        List<string> gatherListOfUsers() {
            List<string> list = new List<string>();
            ManagementClass managementClass = new ManagementClass( "Win32_UserAccount" );
            ManagementObjectCollection moc = managementClass.GetInstances();
            foreach( var item in moc ) {
                list.Add( item[ "Name" ].ToString() );
            }
            return list;
        }
    }
}
