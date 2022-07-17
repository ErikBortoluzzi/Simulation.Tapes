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
    public class SectionService : ISectionService
    {
        private readonly ISectionRepository _sectionRepository;
        private readonly IConfiguration _configuration;

        public SectionService(ISectionRepository sectionRepository, IConfiguration configuration)
        {
            _sectionRepository = sectionRepository;
            _configuration = configuration;
        }
        public Task DeleteSection(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Section>> GetAll()
        {
            return await _sectionRepository.GetAll();
        }

        public Task<Section> GetSectionById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task InsertSection(Section section)
        {
            await _sectionRepository.Insert(section);
        }

        public Task UpdateSection(int id)
        {
            throw new NotImplementedException();
        }
    }
}
