namespace Site.Model.Infrastructure.Input
{
    public interface IPagerInputModel
    {
        int PageNumber { get; set; }
        int PageSite { get; set; }
        string SortColumn { get; set; }
        bool SortDescending { get; set; }
    }
}