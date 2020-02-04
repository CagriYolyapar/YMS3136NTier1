﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class OrderMap : BaseMap<Order>
    {
        public OrderMap()
        {
            Property(x => x.ShippedAddress).HasColumnName("Gonderim Adresi");
            ToTable("Siparisler");
        }
    }
}
