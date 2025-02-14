using BitfinexConnector.Core.Enums;
using BitfinexConnector.Core.Models;

namespace BitfinexConnector.Core.Abstractions;

public interface IRestClient
{
    Task<IEnumerable<Trade>> GetTradesAsync(string pair, int? limit = null, SortOrder? sort = null, long? start = null,
        long? end = null);

    Task<IEnumerable<Candle>> GetCandlesAsync(string pair, TimeFrame timeFrame, SortOrder? sort = null,
        long? start = null, long? end = null, int? limit = null);
}