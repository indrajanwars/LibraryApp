namespace LibraryApp
{
    public static class ErrorHandler
    {
        public static void HandleInvalidInput()
        {
            Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
        }

        public static void HandleInvalidYear()
        {
            Console.WriteLine("Tahun terbit tidak valid.");
        }

        public static void HandleBookNotFound()
        {
            Console.WriteLine("Buku tidak ditemukan dalam katalog.");
        }
    }
}