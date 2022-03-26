using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using travellerinfoAPI.Models;

namespace travellerinfoAPI.IServices
{
    public interface ITravellerService
    {
        IEnumerable<TravellersDetails> GetTravellersDetails();
        TravellersDetails AddTravellers(TravellersDetails Tdetails);
        TravellersDetails UpdateTravellers(TravellersDetails Tdetails);
        TravellersDetails DeleteTravellers(int id);
    }
}
