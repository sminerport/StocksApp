namespace StocksApp.ServiceContracts;

public interface IFinnhubService
{
    Task<Dictionary<string, object>?> GetStockDataAsync(string symbol);
}
