using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Domain.Core;
using UrnaEletronica.Infra.Data.Context;
using UrnaEletronica.Shared.Entites;

namespace UrnaEletronica.Infra.Data.Repositories.Core
{

    public class RepositoryAsync<TEntity> : IRepositoryAsync<TEntity> where TEntity : Entity
    {
        protected readonly UrnaEletronicaContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public RepositoryAsync(UrnaEletronicaContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var query = _dbSet.AsNoTracking();
            return await query.ToListAsync();
        }
    }
}
