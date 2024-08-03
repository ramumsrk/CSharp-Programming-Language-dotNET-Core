  Student.Student _firstStudent = new Student.Student()
{
  StudentName = "Steve"
};
Student.Student _secondStudent = new Student.Student()
{
  StudentName = "Steve"
};
System.Console.WriteLine($"{Environment.NewLine}Name of first student is: '{_firstStudent.StudentName}'");
System.Console.WriteLine($"{Environment.NewLine}Name of second student is: '{_secondStudent.StudentName}'");
System.Console.WriteLine($"{Environment.NewLine}Are '{_firstStudent}' and '{_secondStudent}' referring to the same memory location? '{_firstStudent == _secondStudent}'");
var _thirdStudent = _firstStudent;
System.Console.WriteLine($"{Environment.NewLine}Are '{_firstStudent}' and '{_thirdStudent}' referring to the same memory location? '{_firstStudent == _thirdStudent}'");
int _firstFour = 4;
int _secondFour = 4;
System.Console.WriteLine($"{Environment.NewLine}Are '{_firstFour}' and '{_secondFour}' referring to the same value? '{_firstFour == _secondFour}'");