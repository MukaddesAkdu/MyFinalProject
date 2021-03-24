using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //bunlar bizim iş katmanında kullanacağımız service operasyonlarıdır.
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
