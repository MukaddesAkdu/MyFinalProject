using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        //soyut nesneyle bağlantı kuracağız. ne InMemory ne de EntityFramework ismi geçecek.
        public List<Product> GetAll()
        {
            //buraya iş kodlarını yazıyoruz.
            //InMemoryProductDal inMemoryProductDal = new InMemoryProductDal();
            return _productDal.GetAll();
        }
    }
}
