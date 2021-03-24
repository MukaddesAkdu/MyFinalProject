using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
//yukarıdakiler bu classın içinde kullanacağım class isimleridir. "using bloğu" buna işaretleme denir.
namespace Entities.Concrete
{
    public class Product: IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
