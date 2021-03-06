using Dapper;
using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace AmandeepsBooks.DataAccess.Repository.IRepository
{
    public interface ISP_Call : IDisposable
    {
        T Single<T>(string procedurename, DynamicParameters param = null);
        void Execute(string procedurename, DynamicParameters param = null);
        T OneRecord<T>(string procedurename, DynamicParameters param = null);
        IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null);
        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null);
        //void Execute(object proc_CoverType_Delete, DynamicParameters parameter);
        //object OneRecord<T>(object proc_CoverType_Get, DynamicParameters parameter);
        //object List<T>(object proc_CoverType_GetAll, object p);
        //void Execute(object proc_CoverType_Update, DynamicParameters parameter);
        //void Execute(object proc_CoverType_Create, DynamicParameters parameter);
    }
}
