using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Service_Demo_App
{
    class ShiftCollection
    {
        private List<ShiftData> shiftList;

        public List<ShiftData> ShiftList { get => shiftList; set => shiftList = value; }
    }
}
