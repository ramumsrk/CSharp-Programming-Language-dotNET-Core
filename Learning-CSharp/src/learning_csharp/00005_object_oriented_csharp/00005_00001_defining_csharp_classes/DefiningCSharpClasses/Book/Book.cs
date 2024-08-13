namespace Book;

/// <summary>
/// A book class
/// </summary>
public class Book
{
  // Data - Fields
  /// <summary>
  /// Title of a book
  /// </summary>
  private string? _bookTitle;
  /// <summary>
  /// Read-Write property of a book title
  /// </summary>
  public string? BookTitle
  {
    get => this._bookTitle;
    init => this._bookTitle = value;
  }
  /// <summary>
  /// Author of a book
  /// </summary>
  private string? _bookAuthor;
  /// <summary>
  /// Read-Write property of a book author
  /// </summary>
  public string? BookAuthor
  {
    get => this._bookAuthor;
    init => this._bookAuthor = value;
  }
  /// <summary>
  /// Number of pages in a book
  /// </summary>
  private int _numberOfPagesInBook;
  /// <summary>
  /// Read-Write property of number of pages in a book
  /// </summary>
  public int NumberOfPagesInBook
  {
    get => this._numberOfPagesInBook;
    init => this._numberOfPagesInBook = value;
  }
  // Behaviour - Constructor
  /// <summary>
  /// Default no-argument constructor
  /// </summary>
  public Book()
  {
    return;
  }
  // Behaviour - Instance methods
  /// <summary>
  /// Get a description of the book
  /// </summary>
  /// <returns>Book title and author</returns>
  public string BookDescription()
  {
    return $"'{BookTitle}' by '{BookAuthor}'";
  }
}
