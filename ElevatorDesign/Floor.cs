using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorDesign
{
    public class Floor
    {
        public int FloorNo { get; set; }
        public bool IsActive { get; set; }
        public bool IsSelected { get; set; }
        public bool IsDown { get; set; }
    }
}
