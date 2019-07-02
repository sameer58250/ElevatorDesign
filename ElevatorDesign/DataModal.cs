using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorDesign
{
    public sealed class DataModal
    {
        public List<Floor> ListOfFloor;

        private static readonly Lazy<DataModal> liftData = new Lazy<DataModal>(() => new DataModal());

        private DataModal()
        {
            ListOfFloor = new List<Floor>();
        }

        public void setFloorList(List<Floor> list)
        {
            this.ListOfFloor = list;
        }

        public static DataModal getLiftData()
        {
            return liftData.Value;
        }
    }
}
