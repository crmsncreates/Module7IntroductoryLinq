using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Module7IntroductoryLinq;

public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string ProgramName { get; set; } = string.Empty;
    public double GPA { get; set; }
}
