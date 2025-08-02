namespace AmoSave.Broking.UI.ViewModels
{
    public class OrderViewModel
    {
        public string TradingSymbol { get; set; } = string.Empty;
        public string SymbolToken { get; set; } = string.Empty;
        public string Exchange { get; set; } = string.Empty;
        public string TransactionType { get; set; } = string.Empty;
        public string OrderType { get; set; } = string.Empty;
        public string ProductType { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string Quantity { get; set; } = string.Empty;
        public string? ErrorMessage { get; set; }
        public bool IsLoading { get; set; }
        public bool IsSuccess { get; set; }
        public string? OrderId { get; set; }
    }
}
