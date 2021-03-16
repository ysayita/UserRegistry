namespace UserDataContext.ViewModels
{
    public class MetaVM
    {
        public PaginationVM Pagination { get; set; }
    }

    public class PaginationVM
    {
        public int total { get; set; }
        public int pages { get; set; }
        public int page { get; set; }
        public int limit { get; set; }
    }
}