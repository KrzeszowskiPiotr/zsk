using System;
using System.Collections.Generic;

// Klasa bazowa dla osoby
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Konstruktor inicjalizujący pola FirstName i LastName
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

// Klasa reprezentująca autora, dziedziczy po klasie Person
public class Author : Person
{
    public List<Book> BooksList { get; set; }

    // Konstruktor inicjalizujący pola FirstName, LastName oraz pustą listę książek
    public Author(string firstName, string lastName) : base(firstName, lastName)
    {
        BooksList = new List<Book>();
    }

    // Metoda dodająca książkę do listy książek autora
    public void AddBook(Book book)
    {
        BooksList.Add(book);
    }
}

// Klasa reprezentująca książkę
public class Book
{
    public string Title { get; set; }
    public Author Author { get; set; }
    public int PublicationYear { get; set; }

    // Konstruktor inicjalizujący pola Title, Author oraz PublicationYear
    public Book(string title, Author author, int publicationYear)
    {
        Title = title;
        Author = author;
        PublicationYear = publicationYear;
    }
}

// Klasa reprezentująca czytelnika, dziedziczy po klasie Person
public class Reader : Person
{
    public List<Book> BorrowedBooksList { get; set; }

    // Konstruktor inicjalizujący pola FirstName, LastName oraz pustą listę wypożyczeń
    public Reader(string firstName, string lastName) : base(firstName, lastName)
    {
        BorrowedBooksList = new List<Book>();
    }

    // Metoda dodająca książkę do listy wypożyczeń
    public void BorrowBook(Book book)
    {
        BorrowedBooksList.Add(book);
        Console.WriteLine($"Czytelnik {FirstName} {LastName} wypożyczył książkę: {book.Title}");
    }
}

// Klasa reprezentująca bibliotekę
public class Library
{
    public List<Book> BooksList { get; set; }
    public List<Reader> ReadersList { get; set; }
    public List<Author> authorList { get; set; }

    // Konstruktor inicjalizujący pustą listę książek i czytelników
    public Library()
    {
        BooksList = new List<Book>();
        ReadersList = new List<Reader>();
        authorList = new List<Author>();
    }

    // Metoda dodająca książkę do listy książek
    public void AddBook(Book book)
    {
        BooksList.Add(book);
        Console.WriteLine($"Dodano książkę: {book.Title}");
    }

    // Metoda dodająca czytelnika do listy czytelników
    public void AddReader(Reader reader)
    {
        ReadersList.Add(reader);
        Console.WriteLine($"Dodano czytelnika: {reader.FirstName} {reader.LastName}");
    }
    public void AddAuthor(Author author)
    {
        authorList.Add(author);
    }
    public void DisplayAuthorsTable()
    {
        Console.WriteLine("Lista autorów");
        Console.WriteLine("ID\timie\tnazwisko");
        for(int i = 0; i < authorList.Count;i++)
        {
            Console.WriteLine($"{i + 1} {authorList.FirstName}\t{authorList.LastName}");
        }
    }
    // Metoda umożliwiająca wypożyczenie książki przez czytelnika
    public void BorrowBook(Reader reader, Book book)
    {
        if (BooksList.Contains(book))
        {
            reader.BorrowBook(book);
            BooksList.Remove(book);
            Console.WriteLine($"Książka {book.Title} została wypożyczona przez {reader.FirstName} {reader.LastName}");
        }
        else
        {
            Console.WriteLine($"Książka {book.Title} nie jest dostępna w bibliotece");
        }
    }
}

// Przykładowe użycie
class Program
{
    static void Main(string[] args)
    {
        // Tworzenie autora
        Author author = new Author("Adam", "Mickiewicz");
        // Tworzenie książki
        Book book = new Book("Pan Tadeusz", author, 1834);
        // Dodawanie książki do listy książek autora
        author.AddBook(book);

        // Tworzenie czytelnika
        Reader reader = new Reader("Jan", "Kowalski");
        // Tworzenie biblioteki
        Library library = new Library();
        // Dodawanie książki do biblioteki
        library.AddBook(book);
        // Dodawanie czytelnika do biblioteki
        library.AddReader(reader);

        // Wypożyczanie książki przez czytelnika
        library.BorrowBook(reader, book);

        bool exit = false;
        while(!exit)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Dodaj autora:");
            Console.WriteLine("2. Dodaj książke:");
            Console.WriteLine("3. Dodaj czytelnika:");
            Console.WriteLine("8. Wyjście:");
            Console.WriteLine("Wybierz opcje:");

            string choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    Console.WriteLine("Podaj imie autora:");
                    string authorfirstname = Console.ReadLine();
                    Console.WriteLine("Podaj nazwisko autora:");
                    string authorLastName = Console.ReadLine();
                    library.AddAuthor(new Author (authorfirstname, authorLastName));
                    break;
                case "2":
                    library.DisplayAuthorTable();
                    Console.WriteLine("Podaj numer autora: ");
                    int authorIndex = int.Parse(Console.ReadLine()) - 1;
                    if(authorIndex >= 0 && authorIndex < library.authorList.Count)
                    {
                        //dokonczyc
                    }
                    else
                    {
                        Console.WriteLine("nieprawidlowy numer autora");
                    }
                    break;
            }
        }
        Console.ReadKey();
    }
}