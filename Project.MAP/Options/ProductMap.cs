﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class ProductMap : BaseMap<Product>
    {
        public ProductMap()
        {
            ToTable("Urunler");
            Property(x => x.ProductName).HasColumnName("Urun Ismi").IsRequired();
            Property(x => x.UnitPrice).HasColumnName("Urun Fiyatı").HasColumnType("money");
            Property(x => x.UnitsInStock).HasColumnName("Urun Stok Sayısı");
        }
    }
}
