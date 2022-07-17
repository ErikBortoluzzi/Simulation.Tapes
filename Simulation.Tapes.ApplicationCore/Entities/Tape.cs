using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation.Tapes.ApplicationCore.Entities
{
    public class Tape : EntityBase<int>
    {
        public int Speed { get; set; }
        public int ?Consume { get; set; }
        public DateTime Date { get; set; }
        public int IdSection { get; set; }

    }
}
