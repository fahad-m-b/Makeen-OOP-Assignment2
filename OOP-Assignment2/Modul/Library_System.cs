enum BookStatus
{
    Available,
    CheckedOut,
    Reserved
}
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public BookStatus Status { get; set; }

    public Book(string title, string author, BookStatus status = BookStatus.Available)
    {
        Title = title;
        Author = author;
        Status = status;
    }

    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}, Status: {Status}";
    }
}

class Library
{
    private List<Book> books = new List<Book>();

    public Book this[string title]
    {
        get
        {
{
                foreach (Book b in books)
                {
                    if (b.Title.ToLower() == title.ToLower())
                        return b;
                }
                return null;
            }

        }
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void ChangeStatus(string title, BookStatus status)
    {
        Book book = this[title];
        if (book != null)
        {
            book.Status = status;
            Console.WriteLine($"Status of '{title}' changed to {status}");
        }
        else
        {
            Console.WriteLine($"Book '{title}' not found!");
        }
    }

    public void ShowBooksByStatus(BookStatus status)
    {
        var filteredBooks = books.Where(b => b.Status == status);
        Console.WriteLine($"Books with status {status}:");
        foreach (var book in filteredBooks)
        {
            Console.WriteLine(book);
        }
    }
}