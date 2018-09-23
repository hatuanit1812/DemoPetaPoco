using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPetaPoco.Mapping
{
    [PetaPoco.PrimaryKey("Id", AutoIncrement =true)]
    public partial class M01_Item
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string UnitName { get; set; }
        public string Description { get; set; }
        
    }
}
