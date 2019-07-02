using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorDesign
{
    class Lift:ILift
    {
        public ILiftRun liftRun;
        private ILiftFloor liftFloor;
        private ILiftDoor liftDoor;
        public Lift(List<Floor> floorList)
        {
            liftRun = new LiftRun(floorList);
            liftFloor = new LiftFloor(liftRun);
            liftDoor = new LiftDoor(liftRun);
        }
        public void SelectFloor(Floor floor)
        {
            if (!floor.IsSelected)
                liftFloor.SelectFloorInLift(floor);
            else
                liftFloor.DeselectFloorInLift(floor);
            liftDoor.CloseDoor();
        }

        public void OpenDoor()
        {
            liftDoor.OpenDoor();
            liftDoor.CloseDoor();
        }

        public void CloseDoor()
        {
            liftDoor.CloseDoor();
        }
    }
}
