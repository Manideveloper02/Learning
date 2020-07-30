using BlazorApp.Server.Interface;
using BlazorApp.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp.Server.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMemberdetails _objmemberdetails;

        public MemberController(IMemberdetails objmemberdetails)
        {
            _objmemberdetails = objmemberdetails;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<IatcindiaMMemberdetailsTest>> Index()
        {
            return await _objmemberdetails.GetIatcindiaMMemberdetails();
        }
    }
}
