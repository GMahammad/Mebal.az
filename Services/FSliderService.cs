using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class FSliderService
    {
        public ApplicationDbContext _context;

        public FSliderService(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<FirstSlider> GetSlider()
        {
            return _context.FirstSliders.ToList();
        }
    }
}
