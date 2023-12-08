namespace Lib;

public class BookGenrePubl:BookGenre {
    private string? publisher;
    public string Publisher {
    get { return publisher!; }
    set { 
            if (String.IsNullOrEmpty(value)) value = ""; 
            publisher = value; 
        }
    }

    public BookGenrePubl(string title, string authorName, int price, string genre, string publisher) : base(title, authorName, price, genre) {Publisher = publisher;}

    public override void Print() {
        base.Print();
        Console.WriteLine($"Издатель {Publisher}");
    }
}