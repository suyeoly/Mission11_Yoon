namespace Mission11_Yoon.Models.ViewModels
{
    public class PaginationInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerpage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalNumPages => (int) (Math.Ceiling((decimal)TotalItems / ItemsPerpage)); 
    }
}
