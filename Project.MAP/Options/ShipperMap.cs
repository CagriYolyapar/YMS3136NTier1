using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class ShipperMap : BaseMap<Shipper>
    {
        public ShipperMap()
        {
            ToTable("Kargo Firmalai");
            Property(x => x.CompanyName).HasColumnName("Sirket Ismi").IsRequired();
            Property(x => x.Phone).HasColumnName("Telefon");
        }
    }
}
