using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using travellerinfoAPI.IServices;
using travellerinfoAPI.Models;

namespace travellerinfoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravellersDetailsController : ControllerBase
    {
        private readonly ITravellerService travellerService;
        public TravellersDetailsController(ITravellerService traveller)
        {
            travellerService = traveller;
        }
        [HttpGet]
        public IEnumerable<TravellersDetails> GetTravellers()
        {
            return travellerService.GetTravellersDetails();
        }
        [HttpPost]
        public TravellersDetails AddTravellers(TravellersDetails Tdetails)
        {
            return travellerService.AddTravellers(Tdetails);
        }
        [HttpPut]
        public TravellersDetails UpdateTravellers(TravellersDetails Tdetails)
        {
            return travellerService.UpdateTravellers(Tdetails);
        }
        [HttpDelete]
        public TravellersDetails DeleteTravellers(int id)
        {
            return travellerService.DeleteTravellers(id);
        }
    }
}
