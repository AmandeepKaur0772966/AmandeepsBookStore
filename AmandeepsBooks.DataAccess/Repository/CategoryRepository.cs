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
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public object Name { get; private set; }
        public int Id { get; private set; }

        public void Update(CategoryRepository category)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = (string)category.Name;
                _db.SaveChanges();
            }
        }
    }
}
