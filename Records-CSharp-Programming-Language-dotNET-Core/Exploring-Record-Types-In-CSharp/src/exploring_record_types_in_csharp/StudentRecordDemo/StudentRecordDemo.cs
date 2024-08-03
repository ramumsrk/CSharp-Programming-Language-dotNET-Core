StudentRecord.StudentRecord _firstStudentRecord = new StudentRecord.StudentRecord("Steve");
StudentRecord.StudentRecord _secondStudentRecord = new StudentRecord.StudentRecord("Steve");
System.Console.WriteLine($"{Environment.NewLine}Are '{_firstStudentRecord}' and '{_secondStudentRecord}' equal? '{_firstStudentRecord == _secondStudentRecord}'");
StudentRecord.StudentRecord _thirdStudentRecord = _firstStudentRecord;
System.Console.WriteLine($"{Environment.NewLine}Name of '{_firstStudentRecord}' is '{_firstStudentRecord.studentName}'");
System.Console.WriteLine($"{Environment.NewLine}Name of '{_secondStudentRecord}' is '{_secondStudentRecord.studentName}'");
System.Console.WriteLine($"{Environment.NewLine}Name of '{_thirdStudentRecord}' is '{_thirdStudentRecord.studentName}'");