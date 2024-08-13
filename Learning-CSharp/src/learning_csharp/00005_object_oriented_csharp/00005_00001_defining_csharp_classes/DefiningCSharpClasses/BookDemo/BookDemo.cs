namespace BookDemo
{
  /// <summary>
  /// Demo the behaviour of a Book class
  /// </summary>
  class BookDemo
  {
    /// <summary>
    /// C# program execution starts from built-in
    /// <code>System.Main</code> method
    /// </summary>
    static void Main()
    {
      BookDemo bookDemo = new BookDemo();
      // Object initializer
      Book.Book firstBook = new Book.Book()
      {
        BookTitle =  "War and Peace",
        BookAuthor = "Leo Tolstoy",
        NumberOfPagesInBook = 825,
      };
      // Object initializer
      Book.Book secondBook = new Book.Book()
      {
        BookTitle = "The Grapes of Wrath",
        BookAuthor = "John Steinbeck",
        NumberOfPagesInBook = 464,
      };
      
      System.Console.WriteLine("{0}{1}",System.Environment.NewLine,firstBook.BookDescription());
      System.Console.WriteLine("{0}{1}",System.Environment.NewLine,secondBook.BookDescription());      
      return;
    }
  }
}