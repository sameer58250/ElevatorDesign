using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorDesign
{
    class ManageLifts
    {
        List<ILiftRun> liftList;
        DataModal liftData;
        public ManageLifts()
        {
            liftList = new List<ILiftRun>();
            liftData = DataModal.getLiftData();
        }

        public void addLiftToList(ILiftRun lift)
        {
            liftList.Add(lift);
        }

        public void SelectFloorDown(Floor floor)
        {
            SelectFloor(floor, true);
        }

        public void SelectFloorUp(Floor floor)
        {
            SelectFloor(floor, false);
        }

        private void SelectFloor(Floor floor,bool DownOrUp)
        {
            for (int i = 0; i < liftData.ListOfFloor.Count; i++)
            {
                if (floor.FloorNo == liftData.ListOfFloor[i].FloorNo && liftData.ListOfFloor[i].IsActive)
                    liftData.ListOfFloor[i].IsDown = DownOrUp;
            }
        }
    }
}
