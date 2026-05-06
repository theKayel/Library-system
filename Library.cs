using LibrarySystem;
using System.Collections.Generic;
using System.IO;

public class Library
{
    public List<Book> Books = new List<Book>();

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void SaveToFile()
    {
        using (StreamWriter sw = new StreamWriter("books.txt"))
        {
            foreach (var b in Books)
            {
                sw.WriteLine($"{b.Title},{b.Author},{b.IsBorrowed}");
            }
        }
    }

    public void LoadFromFile()
    {
        if (!File.Exists("books.txt")) return;

        string[] lines = File.ReadAllLines("books.txt");

        Books.Clear();

        foreach (var line in lines)
        {
            var parts = line.Split(',');

            Book b = new Book(parts[0], parts[1]);
            b.IsBorrowed = bool.Parse(parts[2]);

            Books.Add(b);
        }
    }
}