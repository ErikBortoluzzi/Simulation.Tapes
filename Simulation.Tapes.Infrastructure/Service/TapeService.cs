using Microsoft.Extensions.Configuration;
using Simulation.Tapes.ApplicationCore.Entities;
using Simulation.Tapes.ApplicationCore.Interfaces.Repository;
using Simulation.Tapes.ApplicationCore.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation.Tapes.Infrastructure.Service
{
    public class TapeService : ITapeService
    {
        private readonly ITapeRepository _tapeRepository;
        private readonly IConfiguration _configuration;
        public TapeService(ITapeRepository tapeRepository, IConfiguration configuration)
        {
            _tapeRepository = tapeRepository;
            _configuration = configuration;
        }

        public Task DeleteTape(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Tape>> GetAll()
        {
            return await _tapeRepository.GetAll();
        }

        public async Task<IEnumerable<Tape>> GetAllById(int id)
        {
            return await _tapeRepository.GetAllById(id);
        }

        public Task<Tape> GetTapeById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task InsertTape(Tape tape)
        {
            await _tapeRepository.Insert(tape);
        }

        public Task UpdateTape(int id)
        {
            throw new NotImplementedException();
        }
    }
}
