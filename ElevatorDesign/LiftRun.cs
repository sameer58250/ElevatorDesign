using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorDesign
{
    class LiftRun:ILiftRun
    {
        bool IsStopped { get; set; }
        bool IsDoorOpen{get;set;}
        List<Floor> FloorList;
        bool IsGoingUp { get; set; }
        bool IsGoingDown { get; set; }
        Floor CurrentFloor { get; set; }
        int CurrentWeight { get; set; }
        DataModal liftData;

        public LiftRun(List<Floor> floorList)
        {
            IsStopped = false;
            IsDoorOpen = false;
            IsGoingUp = false;
            IsGoingDown = false;
            CurrentFloor = new Floor() { FloorNo = 0, IsActive = true, IsSelected = false };
            CurrentWeight = 0;
            FloorList = floorList;
            liftData = DataModal.getLiftData();
        }
        public void GoUp()
        {
            IsGoingUp = true;
            IsGoingDown = false;
        }

        public void GoDown()
        {
            IsGoingUp = false;
            IsGoingDown = true;
        }


        public void Stop(Floor floor)
        {
            CurrentFloor = floor;
            IsStopped = true;
            for (int i = 0; i < FloorList.Count; i++)
            {
                if (floor.FloorNo == FloorList[i].FloorNo)
                    FloorList[i].IsSelected = false;
            }
        }

        public bool RingOverLoadAlarm()
        {
            bool res = false; ;
            return res;
        }

        bool ILiftRun.IsStopped()
        {
            return IsStopped;
        }

        bool ILiftRun.IsDoorOpen()
        {
            return IsDoorOpen;
        }

        public List<Floor> getFloorList()
        {
            return FloorList;
        }

        bool ILiftRun.IsGoingUp()
        {
            return IsGoingUp;
        }

        bool ILiftRun.IsGoingDown()
        {
            return IsGoingDown;
        }

        Floor ILiftRun.CurrentFloor()
        {
            return CurrentFloor;
        }

        int ILiftRun.CurrentWeight()
        {
            return CurrentWeight;
        }

        public void OpenDoor()
        {
            IsDoorOpen = true;
        }

        public void CloseDoor()
        {
            IsDoorOpen = false;
        }

        public void setCurrentFloor(Floor floor)
        {
            CurrentFloor = floor;
        }
    }
}
