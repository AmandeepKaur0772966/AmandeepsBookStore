using AmandeepsBooks.Models;
using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace AmandeepsBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
       // void Update(CategoryRepository category);
       void Update(Category category);
    }
}
