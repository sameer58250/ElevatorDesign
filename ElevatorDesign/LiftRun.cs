using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ElevatorDesign
{
    class LiftRun: ILiftRun
    {
        public bool IsStopped { get; set; }
        public bool IsDoorOpen {get;set;}
        public List<Floor> FloorList { get; set; }
        public bool IsGoingUp { get; set; }
        public bool IsGoingDown { get; set; }
        public Floor CurrentFloor { get; set; }
        public int CurrentWeight { get; set; }
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
            Thread.Sleep(5000);
            for (int i = 0; i < FloorList.Count; i++)
            {
                if (FloorList[i].FloorNo > CurrentFloor.FloorNo && FloorList[i].IsSelected)
                {
                    Stop(FloorList[i]);
                }
            }
        }

        public void GoDown()
        {
            IsGoingUp = false;
            IsGoingDown = true;
            Thread.Sleep(5000);
            for (int i = FloorList.Count-1; i >=0; i--)
            {
                if (FloorList[i].FloorNo < CurrentFloor.FloorNo && FloorList[i].IsSelected)
                {
                    Stop(FloorList[i]);
                }
            }
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
    }
}
