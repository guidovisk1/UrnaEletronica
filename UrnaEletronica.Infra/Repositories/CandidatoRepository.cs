using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Domain.Core;
using UrnaEletronica.Domains.Entities;
using UrnaEletronica.Domains.Interfaces;
using UrnaEletronica.Infra.Data.Context;
using UrnaEletronica.Infra.Data.Repositories.Core;

namespace UrnaEletronica.Infra.Data.Repositories
{
    public class CandidatoRepository : RepositoryAsync<Candidato>, ICandidatoRepository
    {
        public CandidatoRepository(UrnaEletronicaContext context) : base(context) { }

        
    }
    
}
