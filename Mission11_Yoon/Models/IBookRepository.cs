namespace Mission11_Yoon.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
