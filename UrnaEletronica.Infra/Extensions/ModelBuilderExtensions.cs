using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Domains.Entities;
using UrnaEletronica.Infra.Data.Mappings;

namespace UrnaEletronica.Infra.Data.Extensions
{
    public class ModelBuilderExtensions
    {
        public static ModelBuilder ConfigureMappings(this ModelBuilder builder)
        {
            #region Mapping Entities
            builder.ApplyConfiguration(new CandidatoMap());
       
            #endregion

            return builder;
        }
    }
}
