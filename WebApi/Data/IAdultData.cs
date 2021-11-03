using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Data
{
    public interface IAdultData
    {
        IList<Adult> getAdults();
        /*Task <IList<Adult>> GetAdults( string name);*/
        Task<Adult> AddAdult(Adult adult);
    }
}