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

namespace Simulation.Tapes.Infrastructure
{
    public class TapeRepository : ITapeRepository
    {
        private readonly IConfiguration _configuration;

        public TapeRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Tape> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Tape>> GetAll()
        {
            string query = @"SELECT [id]
                          ,[speed]
                          ,[consume]
                          ,[date]
                          ,[idSection]
                      FROM [dbo].[Tapes]";
            string connectionString = _configuration.GetConnectionString("connection");
            using (var con = new SqlConnection(connectionString))
            {
                await con.OpenAsync();
                var result = con.Query<Tape>(query);
                await con.CloseAsync();
                return result;
            }
        }

        public async Task<IEnumerable<Tape>> GetAllById(int id)
        {
            string query = @"SELECT [id]
                          ,[speed]
                          ,[consume]
                          ,[date]
                          ,[idSection]
                      FROM [dbo].[Tapes] WHERE [dbo].[Tapes].idSection=@id";
            string connectionString = _configuration.GetConnectionString("connection");
            using (var con = new SqlConnection(connectionString))
            {
                await con.OpenAsync();
                var result = con.Query<Tape>(query, new { id = id });
                await con.CloseAsync();
                return result;
            }
        }

        public async Task Insert(Tape entity)
        {
            string query = @"INSERT INTO [dbo].[Tapes]
           ([id]
           ,[speed]
           ,[consume]
           ,[date]
           ,[idSection])
     VALUES
           (@Id,
            @Speed,
            @Consume,
            @Date,
            @IdSection)";
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
