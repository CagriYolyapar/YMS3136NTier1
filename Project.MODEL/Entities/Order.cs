﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Order:BaseEntity
    {
        public string ShippedAddress { get; set; }
        public int AppUserID { get; set; }
        public int ShipperID { get; set; }

        //Relational Properties begin...

        public virtual AppUser AppUser { get; set; }
        public virtual Shipper Shipper { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }

    }
}
