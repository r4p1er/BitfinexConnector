using BitfinexConnector.Core.Enums;
using BitfinexConnector.Core.Models;

namespace BitfinexConnector.Core.Abstractions;

public interface IWebsocketClient
{
    event Action<Trade> TradeExecuted;

    event Action<Trade> TradeUpdated;

    void SubscribeTrades(string pair);
    
    void UnsubscribeTrades(string pair);
    
    event Action<Candle> CandleReceived; 
    
    void SubscribeCandles(string pair, TimeFrame timeFrame);
    
    void UnsubscribeCandles(string pair, TimeFrame timeFrame);
}