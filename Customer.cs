using System;

public class Customer
{
    public Customer()
    {

    public int Id { get; set; }
    public string? CustomerReference { get; set; }
    public string? CustomerInternalGuid { get; set; }
    public int CustomerKYCLevel { get; set; }
    public string? CustomerInternalStatus { get; set; }
    public string? CustomerInternalColor { get; set; }
    public string? CustomerInternalComment { get; set; }
    public ScreeningResultModel? ScreeningResult { get; set; }
    public PlatformModel? Platform { get; set; }
    public CountryModel? Country { get; set; }
    public CustomerInformationModel? CustomerInformation { get; set; }
    public virtual ICollection<BankAccountDetailModel>? BankAccountDetails { get; set; } = new List<BankAccountDetailModel>();
}
}
