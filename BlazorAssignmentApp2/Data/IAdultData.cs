using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorAssignmentApp2.Models;

namespace BlazorAssignmentApp2.Data
{
    public interface IAdultData
    {
        /*IList<Adult> getAdults();*/
        Task <IList<Adult>> GetAdults( string name);
        Task<Adult> AddAdult(Adult adult);
        Task<Adult> AddAdultAsync(Adult adult);
    }
}