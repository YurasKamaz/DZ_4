using Lib;
namespace bookTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void CreateBook()
    {
        string title = "123";
        string authorName = "321";
        int price = 1000;
        Book book = new Book(title, authorName, price);

        Assert.AreEqual(title, book.Title);
        Assert.AreEqual(authorName, book.AuthorName);
        Assert.AreEqual(price, book.Price);
    }

    [TestMethod]
    public void CreateBookWithGenre()
    {
        string title = "123";
        string authorName = "321";
        string genre = "555";
        int price = 1000;
        BookGenre book = new BookGenre(title, authorName, price, genre);

        Assert.AreEqual(title, book.Title);
        Assert.AreEqual(authorName, book.AuthorName);
        Assert.AreEqual(price, book.Price);
        Assert.AreEqual(genre, book.Genre);
    }

    [TestMethod]
    public void CreateBookWithPublisher()
    {
        string title = "123";
        string authorName = "321";
        string genre = "555";
        string publisher = "777";
        int price = 1000;
        BookGenrePubl book = new BookGenrePubl(title, authorName, price, genre, publisher);

        Assert.AreEqual(title, book.Title);
        Assert.AreEqual(authorName, book.AuthorName);
        Assert.AreEqual(price, book.Price);
        Assert.AreEqual(genre, book.Genre);
        Assert.AreEqual(publisher, book.Publisher);
    }
}