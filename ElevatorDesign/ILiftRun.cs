using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorDesign
{
    public interface ILiftRun
    {
        bool IsStopped { get; set; }
        bool IsDoorOpen { get; set; }
        List<Floor> FloorList { get; set; }
        bool IsGoingUp { get; set; }
        bool IsGoingDown { get; set; }
        Floor CurrentFloor { get; set; }
        int CurrentWeight { get; set; }
        void GoUp();
        void GoDown();
        void Stop(Floor floor);
        bool RingOverLoadAlarm();
    }
}
