using Dapper;
using Microsoft.Extensions.Configuration;
using Simulation.Tapes.ApplicationCore.Entities;
using Simulation.Tapes.ApplicationCore.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation.Tapes.Infrastructure.Repository
{
    public class SectionRepository : ISectionRepository
    {
        private readonly IConfiguration _configuration;

        public SectionRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Section> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Section>> GetAll()
        {
            string query = @"SELECT [id]
                          ,[description]
                      FROM [dbo].[Sections]";
            string connectionString = _configuration.GetConnectionString("connection");
            using (var con = new SqlConnection(connectionString))
            {
                await con.OpenAsync();
                var result = con.Query<Section>(query);
                await con.CloseAsync();
                return result;
            }
        }

        public Task<IEnumerable<Section>> GetAllById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Insert(Section entity)
        {
            string query = @"INSERT INTO [dbo].[Sections]
           ([id]
           ,[description])
     VALUES
           (@Id
           ,@Description)";
            string connectionString = _configuration.GetConnectionString("connection");
            using (var con = new SqlConnection(connectionString))
            {
                await con.OpenAsync();
                con.Execute(query, param: entity);
                await con.CloseAsync();
            }
        }

        public Task Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
