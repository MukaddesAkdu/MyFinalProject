using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;         //bir ürün listesi
        public InMemoryProductDal()
        {
            //oracle,sql server,postgres,mongoDb vs gibi bir veritabanından geliyor gibi simüle ettik.
            _products = new List<Product> { 
                new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15},
                new Product{ProductId=2, CategoryId=1, ProductName="Kaşık", UnitPrice=500, UnitsInStock=3},
                new Product{ProductId=3, CategoryId=2, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2},
                new Product{ProductId=4, CategoryId=2, ProductName="Kulaklık", UnitPrice=150, UnitsInStock=65},
                new Product{ProductId=5, CategoryId=2, ProductName="Hoparlör", UnitPrice=85, UnitsInStock=1},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            /*Product productToDelete;
            foreach (var p in _products)
            {
                if (product.ProductId == p.ProductId)
                {
                    productToDelete = p;
                }
            } kendim bir product oluşturup referansı ona atıyorum.
            _products.Remove(productToDelete); */

            /*Product productToDelete = null;
            productToDelete = _products.SingleOrDefault(p=> p.ProductId == product.ProductId); */
            //productToDelete'e referans numarasını eşitliyoruz.
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        //parametreyi camelCase yazıyoruz.
        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
            //parantez için istediğimiz kadar yeni koşul ekleyebiliriz.  && ile birlikte
        }

        public void Update(Product product)
        {
            //benim güncellenecek referansı bulmam lazım.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            //normalde bunu bizim için yapan EntityFramework, NHibernate, Dapper gibi teknolojileri kullanırız.
        }
    }
}
