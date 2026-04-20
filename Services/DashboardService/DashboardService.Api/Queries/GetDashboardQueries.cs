using DashboardService.Api.Queries.Dtos;

namespace DashboardService.Api.Queries;

public class GetTotalSalesQuery
{
    public string? ProductCode { get; set; }
    public DateTime SalesDateFrom { get; set; }
    public DateTime SalesDateTo { get; set; }
}

public class GetTotalSalesResult
{
    public SalesTotalDto Total { get; set; } = new();
    public IDictionary<string, SalesTotalDto> PerProductTotal { get; set; } = new Dictionary<string, SalesTotalDto>();
}

public class GetAgentsSalesQuery
{
    public DateTime SalesDateFrom { get; set; }
    public DateTime SalesDateTo { get; set; }
}

public class GetAgentsSalesResult
{
    public IDictionary<string, SalesTotalDto> PerAgentTotal { get; set; } = new Dictionary<string, SalesTotalDto>();
}

public class GetSalesTrendsQuery
{
    public DateTime SalesDateFrom { get; set; }
    public DateTime SalesDateTo { get; set; }
    public TimeUnit Unit { get; set; } = TimeUnit.Month;
}

public class GetSalesTrendsResult
{
    public IList<SalesTrendPeriodDto> PeriodsSales { get; set; } = new List<SalesTrendPeriodDto>();
}
