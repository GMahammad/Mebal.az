using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DetailService
    {
        private ApplicationDbContext _context;
        public DetailService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Detail GetDetails(int id)
        {
            return _context.Details.FirstOrDefault(x => x.AdvertisementID == id);
        }
        
    }
}
