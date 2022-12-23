using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Application.ViewModel;

namespace UrnaEletronica.Application.Interfaces
{
    public interface ICandidatoService
    {
        Task<IEnumerable<CandidatoViewModel>> GetAllAsync();
    }
}
