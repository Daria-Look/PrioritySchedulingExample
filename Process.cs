using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityScheduling
{
    internal class Process
    {
        public int idProcess;
        public int timeArrivalProcess;
        public int priorityProcess;
        public int timeCpuProcess;
        public Process(int id, int timeCpu, int priority, int timeArrival) 
        { 
            idProcess = id;
            timeArrivalProcess = timeArrival;
            priorityProcess = priority;
            timeCpuProcess = timeCpu;
        }

    }
}
