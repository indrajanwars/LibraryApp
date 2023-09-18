namespace LibraryApp
{
    class LibraryApp
    {
        private static LibraryCatalog catalog = new();

        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("== Aplikasi Katalog Perpustakaan ==\n");
                Console.WriteLine("1. Tambah Buku");
                Console.WriteLine("2. Hapus Buku");
                Console.WriteLine("3. Cari Buku Berdasarkan Judul");
                Console.WriteLine("4. Tampilkan Semua Buku");
                Console.WriteLine("5. Keluar");
                Console.Write("\nPilihan: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            BookAdd();
                            break;

                        case 2:
                            BookRemove();
                            break;

                        case 3:
                            BookFind();
                            break;

                        case 4:
                            BookAll();
                            break;

                        case 5:
                            Console.WriteLine("\nKeluar dari aplikasi.");
                            Environment.Exit(0);
                            break;

                        default:
                            ErrorHandler.HandleInvalidInput();
                            break;
                    }
                }
                else
                {
                    ErrorHandler.HandleInvalidInput();
                }
                Console.ReadLine();
            }
        }

        static void BookAdd()
        {
            Console.Clear();
            Console.WriteLine("== Tambah Buku ==\n");

            Console.Write("Judul: ");
            string title = Console.ReadLine();

            Console.Write("Penulis: ");
            string author = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
            {
                ErrorHandler.HandleInvalidInput("Judul dan Penulis tidak boleh kosong.");
                return;
            }

            if (catalog.FindBook(title) != null)
            {
                Console.WriteLine("Buku dengan judul yang sama sudah ada dalam katalog.");
                return;
            }

            Console.Write("Tahun Terbit: ");
            if (int.TryParse(Console.ReadLine(), out int publicationYear))
            {
                if (publicationYear < 1900 || publicationYear > DateTime.Now.Year)
                {
                    ErrorHandler.HandleInvalidYear();
                    return;
                }

                BookLib book = new(title, author, publicationYear);
                catalog.AddBook(book);
                Console.WriteLine("Buku berhasil ditambahkan ke katalog.");
            }
        }

        static void BookRemove()
        {
            Console.Clear();
            Console.WriteLine("== Hapus Buku ==\n");

            catalog.HandleEmptyCatalog();

            Console.Write("Judul Buku yang Ingin Dihapus: ");
            string title = Console.ReadLine();

            BookLib bookToRemove = catalog.FindBook(title);

            if (bookToRemove != null)
            {
                catalog.RemoveBook(bookToRemove);
                Console.WriteLine("Buku berhasil dihapus dari katalog.");
            }
            else
            {
                ErrorHandler.HandleBookNotFound();
            }
        }

        static void BookFind()
        {
            Console.Clear();
            Console.WriteLine("== Cari Buku Berdasarkan Judul ==\n");

            catalog.HandleEmptyCatalog();

            Console.Write("Judul Buku yang Dicari: ");
            string title = Console.ReadLine();

            BookLib foundBook = catalog.FindBook(title);

            if (foundBook != null)
            {
                Console.WriteLine($"\nBuku ditemukan:\n\nJudul: {foundBook.Title}\nPenulis: {foundBook.Author}\nTahun Terbit: {foundBook.PublicationYear}");
            }
            else
            {
                ErrorHandler.HandleBookNotFound();
            }
        }

        static void BookAll()
        {
            Console.Clear();
            Console.WriteLine("== Semua Buku dalam Katalog ==\n");

            catalog.HandleEmptyCatalog();
            catalog.ListBook();
        }
    }
}
