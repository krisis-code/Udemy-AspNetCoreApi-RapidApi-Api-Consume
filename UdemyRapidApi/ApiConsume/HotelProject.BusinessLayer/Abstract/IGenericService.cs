using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IGenericService <T> where T : class
    {
        Task TInsertAsync(T t);
        Task TUpdateAsync(T t);
        Task TDeleteAsync(T t);
        Task<List<T>> TGetListAsync();
        Task<T> TGetByIdAsync(int id);
    }
}
