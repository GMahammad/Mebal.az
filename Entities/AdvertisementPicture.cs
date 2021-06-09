using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class AdvertisementPicture
    {
        public int ID { get; set; }
        public int PictureID { get; set; }
        public int AdvertID { get; set; }
        public virtual Picture Picture { get; set; }
        public Advertisement Advertisement { get; set; }


    }
}
