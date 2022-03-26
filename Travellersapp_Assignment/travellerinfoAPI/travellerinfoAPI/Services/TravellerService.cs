using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using travellerinfoAPI.IServices;
using travellerinfoAPI.Models;

namespace travellerinfoAPI.Services
{
    public class TravellerService : ITravellerService
    {
        TravellerinfoContext dbContext;
        public TravellerService(TravellerinfoContext db)
        {
            dbContext = db;
        }

        public TravellersDetails AddTravellers(TravellersDetails Tdetails)
        {
            dbContext.TravellersDetails.Add(Tdetails);
            dbContext.SaveChanges();
            return Tdetails;
        }

        public TravellersDetails DeleteTravellers(int id)
        {
            var res = dbContext.TravellersDetails.Find(id);
            dbContext.TravellersDetails.Remove(res);
            dbContext.SaveChanges();
            return res;
        }

        public IEnumerable<TravellersDetails> GetTravellersDetails()
        {
            return dbContext.TravellersDetails.ToList();
        }

        public TravellersDetails UpdateTravellers(TravellersDetails Tdetails)
        {
            dbContext.Entry(Tdetails).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return Tdetails;
        }
    }
}
