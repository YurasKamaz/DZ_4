namespace Lib;

public class Book
{
    private string? title;
    public string Title {
    get { return title!; }
    set { 
            if (String.IsNullOrEmpty(value)) value = ""; 
            title = value; 
        }
    }

    private string? authorName;
    public string AuthorName {
    get { return authorName!; }
    set { 
            if (String.IsNullOrEmpty(value)) value = ""; 
            authorName = value; 
        }
    }

    private int price;
    public int Price {
    get { return price; }
    set { 
            if (value < 0) value = 0; 
            price = value; 
        }
    }

    public Book(string title, string authorName, int price) {
        Title = title;
        AuthorName = authorName;
        Price = price;
    }

    public virtual void Print() => Console.WriteLine($"Название {Title} Имя автора {AuthorName} Цена {Price}");
}
