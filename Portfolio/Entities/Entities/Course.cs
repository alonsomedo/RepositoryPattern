using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Level { get; set; }

        public float FullPrice { get; set; }
    
    }
}
