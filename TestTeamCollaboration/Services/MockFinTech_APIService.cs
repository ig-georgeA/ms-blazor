using TeamCollaboration.Models.FinTech_API;

namespace TeamCollaboration.FinTech_API
{
    public class MockFinTech_APIService : IFinTech_APIService
    {
        public Task<List<Stock>> GetStockList()
        {
            return Task.FromResult<List<Stock>>(new());
        }

        public Task<List<StockData>> GetStockDataList(string? symbol)
        {
            return Task.FromResult<List<StockData>>(new());
        }
    }
}
