using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Meter
    {
        public int MeterId { get; set; }
        public int SerialNumber { get; set; }
        public Meter ParentId { get; set; }
        public SupplyType SupplyType { get; set; }
        public ReadingFrequency ReadingFrequencyId { get; set; }
        public MeterType MeterTypeId { get; set; }
        public Unit UnitId { get; set; }
    }
}