using AmandeepsBooks.DataAccess.Repository.IRepository;
using AmandeepsBooks.Models;
using AmandeepsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
//using System.Linq;
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
    }
}
