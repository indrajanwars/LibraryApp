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
                            AddBook();
                            break;

                        case 2:
                            break;

                        case 3:
                            break;

                        case 4:
                            break;

                        case 5:
                            Console.WriteLine("\nKeluar dari aplikasi.");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                }
                Console.ReadLine();
            }
        }

        static void AddBook()
        {
            Console.Clear();
            Console.WriteLine("== Tambah Buku ==\n");

            Console.Write("Judul: ");
            string title = Console.ReadLine();

            Console.Write("Penulis: ");
            string author = Console.ReadLine();

            Console.Write("Tahun Terbit: ");
            if (int.TryParse(Console.ReadLine(), out int publicationYear))
            {
                BookLib book = new(title, author, publicationYear);
                catalog.AddBook(book);
                Console.WriteLine("Buku berhasil ditambahkan ke katalog.");
            }
            else
            {
                Console.WriteLine("Tahun terbit tidak valid.");
            }
        }
    }
}
