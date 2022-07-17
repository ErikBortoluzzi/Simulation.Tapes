using Simulation.Tapes.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation.Tapes.ApplicationCore.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity, TPrimaryKey>
      where TEntity : EntityBase<TPrimaryKey>
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> GetAllById(int id);
        Task<TEntity> Get(TPrimaryKey id);
        Task Insert(TEntity entity);
        Task Update(int id);
        Task Delete(TPrimaryKey id);

    }
}
