using Simulation.Tapes.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation.Tapes.ApplicationCore.Interfaces.Service
{
    public interface ISectionService
    {
        public Task<IEnumerable<Section>> GetAll();
        public Task<Section> GetSectionById(int id);
        public Task InsertSection(Section section);
        public Task UpdateSection(int id);
        public Task DeleteSection(int id);
    }
}
