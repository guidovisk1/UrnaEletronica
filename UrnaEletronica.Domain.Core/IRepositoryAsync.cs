using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Shared.Entites;

namespace UrnaEletronica.Domain.Core
{
    public interface IRepositoryAsync<TEntity> where TEntity : Entity 
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
