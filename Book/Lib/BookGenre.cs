namespace Lib;

public class BookGenre:Book {
    private string? genre;
    public string Genre {
    get { return genre!; }
    set { 
            if (String.IsNullOrEmpty(value)) value = ""; 
            genre = value; 
        }
    }

    public BookGenre(string title, string authorName, int price, string genre) : base(title, authorName, price) {Genre = genre;}

    public override void Print() {
        base.Print();
        Console.WriteLine($"Жанр {Genre}");
    }
}   