using Simulation.Tapes.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation.Tapes.ApplicationCore.Interfaces.Service
{
    public interface ITapeService
    {
        public Task<IEnumerable<Tape>> GetAll();
        public Task<IEnumerable<Tape>> GetAllById(int id);
        public Task<Tape> GetTapeById(int id);
        public Task InsertTape(Tape tape);
        public Task UpdateTape(int id);
        public Task DeleteTape(int id);
    }
}
