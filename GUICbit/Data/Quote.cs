namespace GUICbit.Data
{
    public class Quote
    {
        public int Id { get; set; }
        public string SettlementCurrency { get; set; }
        public string CollectionCurrency { get; set; }
        public double collectionAmount { get; set; }
        public double SettlementAmount { get; set; }
        public string Status { get; set; }
        public string CustomerRef { get; set; }
    }
}
