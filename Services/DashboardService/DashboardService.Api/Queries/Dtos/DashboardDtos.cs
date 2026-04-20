namespace DashboardService.Api.Queries.Dtos;

public enum TimeUnit
{
    Day = 0,
    Week = 1,
    Month = 2,
    Year = 3
}

public class SalesTotalDto
{
    public decimal PremiumAmount { get; set; }
    public long PoliciesCount { get; set; }
}

public class SalesTrendPeriodDto
{
    public string Period { get; set; } = string.Empty;
    public SalesTotalDto Sales { get; set; } = new();
}
