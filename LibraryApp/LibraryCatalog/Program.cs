namespace LibraryApp
{
    public class LibraryCatalog
    {
        private List<BookLib> bookscatalog = new();

        public void AddBook(BookLib book)
        {
            bookscatalog.Add(book);
        }

        public void RemoveBook(BookLib book)
        {
            bookscatalog.Remove(book);
        }

        public BookLib FindBook(string title)
        {
            foreach (var book in bookscatalog)
            {
                if (string.Equals(book.Title, title, StringComparison.OrdinalIgnoreCase))
                {
                    return book;
                }
            }
            return null;
        }

        public void ListBook()
        {
            foreach (var book in bookscatalog)
            {
                Console.WriteLine($"Judul: {book.Title}");
                Console.WriteLine($"Penulis: {book.Author}");
                Console.WriteLine($"Tahun Terbit: {book.PublicationYear}");
                Console.WriteLine("---------------------------");
            }
        }

        public int BookCount()
        {
            return bookscatalog.Count;
        }

        public void HandleEmptyCatalog()
        {
            if (BookCount() == 0)
            {
                Console.WriteLine("Data buku masih kosong. Segera tambahkan buku.");
            }
        }

    }
}
