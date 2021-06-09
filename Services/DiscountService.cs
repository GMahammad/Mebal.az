using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DiscountService
    {
        private ApplicationDbContext _context;
        public DiscountService(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Discount> GetDiscounts()
        {
            return _context.Discounts.ToList();
        }
    }
}
