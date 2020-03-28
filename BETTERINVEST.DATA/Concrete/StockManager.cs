using AutoMapper;
using BETTERINVEST.DATA.Contracts;
using BETTERINVEST.SHARED;
using BETTERINVEST.SHARED.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BETTERINVEST.DATA.Concrete
{
    public class StockManager : IStockManager
    {
        private readonly IDapperManager _dapperManager;

        public StockManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public Task<int> Create(StockModel stock)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Symbol", stock.Symbol, DbType.String);
            dbPara.Add("Shares", stock.Shares, DbType.Decimal);
            dbPara.Add("TotalCost", stock.TotalCost, DbType.Decimal);
            dbPara.Add("Dividend", stock.Dividend, DbType.Decimal);
            dbPara.Add("Frequency", stock.Frequency, DbType.Int32);
            dbPara.Add("Month01", stock.Month01, DbType.Boolean);
            dbPara.Add("Month02", stock.Month02, DbType.Boolean);
            dbPara.Add("Month03", stock.Month03, DbType.Boolean);
            dbPara.Add("Month04", stock.Month04, DbType.Boolean);
            dbPara.Add("Month05", stock.Month05, DbType.Boolean);
            dbPara.Add("Month06", stock.Month06, DbType.Boolean);
            dbPara.Add("Month07", stock.Month07, DbType.Boolean);
            dbPara.Add("Month08", stock.Month08, DbType.Boolean);
            dbPara.Add("Month09", stock.Month09, DbType.Boolean);
            dbPara.Add("Month10", stock.Month10, DbType.Boolean);
            dbPara.Add("Month11", stock.Month11, DbType.Boolean);
            dbPara.Add("Month12", stock.Month12, DbType.Boolean);
            var stockId = Task.FromResult(_dapperManager.Insert<int>("[dbo].[SP_Add_Stock]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return stockId;
        }

        public Task<StockModel> GetById(int id)
        {
            var result = Task.FromResult(_dapperManager.Get<Stock>($"select * from [Stock] where ID = {id}", null, commandType: CommandType.Text));
            var stock = Task.FromResult(Mapper.Map<StockModel>(result));

            return stock;
        }

        public Task<int> Delete(int id)
        {
            var deleteStock = Task.FromResult(_dapperManager.Execute($"Delete [Stock] where ID = {id}", null,
                    commandType: CommandType.Text));
            return deleteStock;
        }

        public Task<int> Count()
        {
            var totStock = Task.FromResult(_dapperManager.Get<int>($"select COUNT(*) from [Stock]", null,
                    commandType: CommandType.Text));
            return totStock;
        }

        public Task<List<StockModel>> ListAll()
        {
            var result = Task.FromResult(_dapperManager.GetAll<Stock>($"SELECT * FROM [Stock];", null, commandType: CommandType.Text));
            var stocks = Task.FromResult(Mapper.Map<List<StockModel>>(result));

            return stocks;
        }

        public Task<int> Update(StockModel stock)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Id", stock.ID);
            dbPara.Add("Symbol", stock.Symbol, DbType.String);
            dbPara.Add("Shares", stock.Shares, DbType.Decimal);
            dbPara.Add("TotalCost", stock.TotalCost, DbType.Decimal);
            dbPara.Add("Dividend", stock.Dividend, DbType.Decimal);
            dbPara.Add("Frequency", stock.Frequency, DbType.Int32);
            dbPara.Add("Month01", stock.Month01, DbType.Boolean);
            dbPara.Add("Month02", stock.Month02, DbType.Boolean);
            dbPara.Add("Month03", stock.Month03, DbType.Boolean);
            dbPara.Add("Month04", stock.Month04, DbType.Boolean);
            dbPara.Add("Month05", stock.Month05, DbType.Boolean);
            dbPara.Add("Month06", stock.Month06, DbType.Boolean);
            dbPara.Add("Month07", stock.Month07, DbType.Boolean);
            dbPara.Add("Month08", stock.Month08, DbType.Boolean);
            dbPara.Add("Month09", stock.Month09, DbType.Boolean);
            dbPara.Add("Month10", stock.Month10, DbType.Boolean);
            dbPara.Add("Month11", stock.Month11, DbType.Boolean);
            dbPara.Add("Month12", stock.Month12, DbType.Boolean);

            var updateStock = Task.FromResult(_dapperManager.Update<int>("[dbo].[SP_Update_Stock]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateStock;
        }
    }
}
