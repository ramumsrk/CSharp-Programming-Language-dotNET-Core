AnotherStudentRecord.AnotherStudentRecord _firstAnotherStudentRecord = new AnotherStudentRecord.AnotherStudentRecord()
{
  StudentName = "Steve",
  StudentId = 1
};
AnotherStudentRecord.AnotherStudentRecord _secondAnotherStudentRecord = _firstAnotherStudentRecord with {
  StudentId = 2
};
System.Console.WriteLine($"{Environment.NewLine}Are '{_firstAnotherStudentRecord}' and '{_secondAnotherStudentRecord}' the same? '{_firstAnotherStudentRecord == _secondAnotherStudentRecord}'");