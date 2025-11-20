using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; 

namespace Pokedex
{
    public class ResourceChecker
    {
        public void CheckStats()
        {
        private static readonly List<string> itemlist = new List<string>() { "Ram", "CPU", "Storage" };
        private static readonly PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% ProcessorTime", "_total");
        private static readonly PerformanceCounter ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
        private static readonly PerformanceCounter storageCounter = new PerformanceCounter("PhysicalDisk", "% Disk Time", "GB used.");

        Dictionary<string, PerformanceCounter> assets = new Dictionary<string, PerformanceCounter>()
        
        public ResourceChecker()
        {
            try
            {
                cpuCounter.NextValue();
                ramCounter.NextValue();
                storageCounter.NextValue();
            }
        }
      
    }


    


}


