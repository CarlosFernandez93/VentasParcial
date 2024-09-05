using System.Collections.Generic;
using System.Threading.Tasks;
using VentasParcial.Models;

namespace VentasParcial.Repository.Interface
{
    public interface IVentaRepository
    {
        Task<IEnumerable<Venta>> GetAll();
        Task<Venta> GetById(int id);
        Task Add(Venta venta);
        Task Update(Venta venta);
        Task Delete(int id);
        Task<bool> Exists(int id);
    }

}
