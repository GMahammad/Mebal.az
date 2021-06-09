using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Detail
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string HostNumber { get; set; }
        public string HostWhatsapp { get; set; }
        public string HostAdress { get; set; }
        public string HostName { get; set; }
        public string AdInfo { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Lenght { get; set; }
        public decimal Depth { get; set; }
        public string Material { get; set; }
        public bool IsNew { get; set; }
        public int AdvertisementID { get; set; }
    }
}
