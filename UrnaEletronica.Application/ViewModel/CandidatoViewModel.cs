using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Domains.ValueObjects;

namespace UrnaEletronica.Application.ViewModel
{
   public class CandidatoViewModel
    {
        public Guid Id { get; private set; }
        public Nome Nome { get; private set; }
        public Idade Idade { get; private set; }
        public Partido Partido { get; private set; }
    }
}
