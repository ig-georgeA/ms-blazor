using TeamCollaboration.Models.FinTech_API;

namespace TeamCollaboration.FinTech_API
{
    public interface IFinTech_APIService
    {
        Task<List<Stock>> GetStockList();
        Task<List<StockData>> GetStockDataList(string? symbol = "UNH");
    }
}
