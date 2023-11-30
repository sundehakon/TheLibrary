public class BasketService
{
    public List<Book> Books { get; } = new List<Book>();

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

}
