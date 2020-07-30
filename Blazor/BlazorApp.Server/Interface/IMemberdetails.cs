using BlazorApp.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp.Server.Interface
{
    public interface IMemberdetails
    {
        Task<IEnumerable<IatcindiaMMemberdetailsTest>> GetIatcindiaMMemberdetails();
    }
}
