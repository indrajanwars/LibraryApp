namespace LibraryApp
{
    public static class ErrorHandler
    {
        public static void HandleInvalidInput(string message = "Pilihan tidak valid. Silakan coba lagi.")
        {
            Console.WriteLine(message);
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