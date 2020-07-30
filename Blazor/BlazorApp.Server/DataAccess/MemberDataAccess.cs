using BlazorApp.Server.Interface;
using BlazorApp.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Server.DataAccess
{
    public class MemberDataAccess : IMemberdetails
    {
        IATC_INDIAContext db = new IATC_INDIAContext();
        public async Task<IEnumerable<IatcindiaMMemberdetailsTest>> GetIatcindiaMMemberdetails()
        {
            return await db.IatcindiaMMemberdetailsTest.ToListAsync();
        }
    }
}
