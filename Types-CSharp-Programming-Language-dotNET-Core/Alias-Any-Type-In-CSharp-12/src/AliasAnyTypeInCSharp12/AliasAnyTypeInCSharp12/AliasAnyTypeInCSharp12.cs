using System;

using static System.Console;
using static System.Environment;

using PersonName = (string firstName, string lastName);

namespace AliasAnyTypeInCSharp12
{
  class AliasAnyTypeInCSharp12
  {
    /// <summary>
    /// C# program execution starts from
    /// built-in <code>System.Main</code>
    /// method
    /// </summary>
    static void Main()
    {
      AliasAnyTypeInCSharp12 aliasAnyTypeInCSharp12 = new AliasAnyTypeInCSharp12();
      
      WriteLine("{0}'{1}'",NewLine,"Hello, World!");

      (string firstName, string lastName) fullNameTuple = default;
      fullNameTuple.firstName = "Tim";
      fullNameTuple.lastName = "Corey";
      WriteLine("{0}First name: '{1}' and last name: '{2}'",NewLine,fullNameTuple.firstName,fullNameTuple.lastName);

      PersonName timCorey = default;
      timCorey.firstName = "Tim";
      timCorey.lastName = "Corey";
          WriteLine("{0}Tim's first name is: '{1}' and last name is: '{2}'",NewLine,timCorey.firstName,timCorey.lastName);      
      return;
    }
  }
}