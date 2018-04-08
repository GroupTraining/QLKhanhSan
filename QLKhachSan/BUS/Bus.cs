using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class Bus
    {
        DataDiagramDataContext data = new DataDiagramDataContext();

        public object get_Hdtt()
        {
            var hddt = from a in data.HDThanhToans select a;
            return hddt;
        }
    }
}
