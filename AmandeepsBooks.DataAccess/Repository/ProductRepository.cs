using AmandeepsBooks.DataAccess.Repository.IRepository;
using AmandeepsBooks.Models;
using AmandeepsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace AmandeepsBooks.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public object Name { get; private set; }
        public int Id { get; private set; }
        public object ImageUrl { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string ISBN { get; private set; }
        public string Author { get; private set; }
        public double ListPrice { get; private set; }
        public int CategoryId { get; private set; }
        public int CoverTypeId { get; private set; }

        public void Update(ProductRepository product)
        {
            var objFromDb = _db.Products.FirstOrDefault(s => s.Id == product.Id);
            if (objFromDb != null)
            {
                if (product.ImageUrl != null)
                {
                    objFromDb.ImageUrl = (string)product.ImageUrl;
                }
                objFromDb.Title = product.Title;
                objFromDb.Description = product.Description;
                objFromDb.ISBN = product.ISBN;
                objFromDb.Author = product.Author;
                objFromDb.ListPrice = product.ListPrice;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.CoverTypeId = product.CoverTypeId;
            }
        }
    }
}
