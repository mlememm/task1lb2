using System;
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public decimal Price { get; set; }
    public Book(string title, string author, decimal price)
    {
        Title = title;
        Author = author;
        Price = price;
    }
    public void DisplayBookInfo()
    {
        Console.WriteLine($"Назва: {Title}");
        Console.WriteLine($"Автор: {Author}");
        Console.WriteLine($"Ціна: {Price:C}");
        Console.WriteLine("--------------------");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Створення книги за введеними даними користувача.");
        Console.WriteLine("--------------------------------------------------");
        string title;
        string author;
        decimal price;
        bool isValidPrice = false;
        Console.Write("Назва книги: ");
        title = Console.ReadLine();
        Console.Write("Автор книги: ");
        author = Console.ReadLine();
        do
        {
            Console.Write("Ціна книги: ");
            string priceInput = Console.ReadLine();
            isValidPrice = decimal.TryParse(priceInput, out price);
            if (!isValidPrice)
            {
                Console.WriteLine("Некоректний формат ціни. Будь ласка, введіть числове значення.");
            }
        } while (!isValidPrice);
        Book userBook = new Book(title, author, price);

        Console.WriteLine("\nІнформація про створену книгу:");
        userBook.DisplayBookInfo();

        Console.WriteLine("--------------------------------------------------");
    }
}