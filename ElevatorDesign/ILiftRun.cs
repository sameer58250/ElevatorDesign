using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorDesign
{
    public interface ILiftRun
    {
        bool IsStopped();
        bool IsDoorOpen();
        List<Floor> getFloorList();
        bool IsGoingUp();
        bool IsGoingDown();
        Floor CurrentFloor();
        int CurrentWeight();
        void setCurrentFloor(Floor floor);
        void OpenDoor();
        void CloseDoor();
        void GoUp();
        void GoDown();
        void Stop(Floor floor);
        bool RingOverLoadAlarm();
    }
}
