namespace csharp_properties_you_need_to_know;
class csharp_properties_everything_you_need_to_know
{
  static void Main(string[] args)
  {
      User.User _firstUser = new()
      {
        FirstName = "Shailendra",
        LastName = "Chauhan"
      };
      System.Console.WriteLine($"{Environment.NewLine}First name of the user is '{_firstUser.FirstName}'");
      System.Console.WriteLine($"{Environment.NewLine}Last name of the user is '{_firstUser.LastName}'");
      System.Console.WriteLine($"{Environment.NewLine}Fullname of the user is '{_firstUser.FullName}'");
    return;
  }
}