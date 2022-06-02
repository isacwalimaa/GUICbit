namespace GUICbit.Data
{
    public class Customer
    {
        public int Id { get; set; }
        public string? CustomerReference { get; set; }
        public string? CustomerInternalGuid { get; set; }
        public int CustomerKYCLevel { get; set; }
        //public ScreeningResult? ScreenResult { get; set; }
        //public Platform Platform { get; set; } = default!;
       // public Country? Country { get; set; }
    }
}
