using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AM.ApplicationCore.Domain
{
    public class plane

    {


        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneType { get; set; }
    }
    plane plane = new AM.ApplicationCore.Domain.plane();
    public plane(PlaneType pt, int capacity, DateTime date)
    {
        planeType = planeType;
        capacity = capacity;
        ManufactureDate = ManufactureDate;



    }
}