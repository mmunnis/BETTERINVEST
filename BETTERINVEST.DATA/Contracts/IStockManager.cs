using BETTERINVEST.SHARED.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BETTERINVEST.DATA.Contracts
{
    public interface IStockManager
    {
        Task<int> Create(StockModel stock);
        Task<int> Delete(int Id);
        Task<int> Count();
        Task<int> Update(StockModel stock);
        Task<StockModel> GetById(int Id);
        Task<List<StockModel>> ListAll();
    }
}
