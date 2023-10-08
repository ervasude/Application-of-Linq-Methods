using System.Xml.Linq;
using assignment7.Entites;


#region Concat


List<Students> departmentA = new List<Students>()
{

    new Students("John", "Smith", 20),
    new Students("Sarah", "Johnson", 22),
    new Students("Michael", "Brown", 19),
    new Students("Emily", "Davis", 21),
    new Students("Davis", "Wilson", 18)

};

List<Students> departmentB = new List<Students>()
{
    new Students("Ella", "Anderson", 20),
    new Students("Liam", "Martinez", 22),
    new Students("Olivia", "Garcia", 19),
    new Students("Noah", "Perez", 21),
    new Students("Ava", "Rodriguez", 18)
};


IEnumerable<string> filterResult =
   departmentA.Select(Students => Students.FirstName)
               .Concat(departmentB.Select(Students => Students.FirstName));


foreach (var name in filterResult)
{
    Console.WriteLine(name);
}

#endregion

#region Distinct + GroupBy

List<Students> students = new List<Students>()
{   new Students("John", "Smith", 20),
    new Students("Sarah", "Johnson", 22),
    new Students("John", "Brown", 19),
    new Students("Emily", "Davis", 21),
    new Students("Sarah", "Wilson", 18)
};

var distinctStudents = students
    .GroupBy(s => s.FirstName)
    .Select(group => group.First())
    .Distinct();

Console.WriteLine("Distinct Students");

foreach (var AllStudent in distinctStudents)
{
    Console.WriteLine($"FirstName : {AllStudent.FirstName} " +
        $"LastName : {AllStudent.LastName}" + $" Age : {AllStudent.Age}");
}

#endregion

#region Skip + SkipWhile

List<AverageGPA> averageGPAs = new List<AverageGPA>()
{
    new AverageGPA(2.93M, "MIS"),
    new AverageGPA(3.11M, "Business"),
    new AverageGPA(2.88M, "Human Resources"),
    new AverageGPA(3.34M, "Finance"),
    new AverageGPA(2.56M, "Economy")
};

List<AverageGPA> remainingGpa = averageGPAs
    .SkipWhile(averageGPAs => averageGPAs.Averages > 3.5M)
    .Skip(2)
    .ToList();

Console.WriteLine("Remaining GPA");

foreach (var remaining in remainingGpa)
{
    Console.WriteLine($"Department : {remaining.departments} - GPA : {remaining.Averages}");
}

#endregion

#region Take + OrderByDescending

List<Students> student = new List<Students>()
{   new Students("John", "Smith", 20),
    new Students("Sarah", "Johnson", 22),
    new Students("John", "Brown", 19),
    new Students("Emily", "Davis", 21),
    new Students("Sarah", "Wilson", 18)
};

IEnumerable<int> topAges = students
    .Select(student => student.Age)
    .OrderByDescending(age => age)
    .Take(2);

Console.WriteLine("Top Two Age of Students");

foreach (var Age in topAges)
{
    Console.WriteLine(Age);
}



#endregion

#region Union

List<Students> departmentAB = new List<Students>()
{
    new Students("John", "Smith", 20),
    new Students("Sarah", "Johnson", 22),
    new Students("Michael", "Brown", 19),
    new Students("Emily", "Davis", 21),
    new Students("Davis", "Wilson", 18)
};

List<Students> departmentBC = new List<Students>()
{
    new Students("Ella", "Anderson", 20),
    new Students("Liam", "Martinez", 22),
    new Students("Olivia", "Garcia", 19),
    new Students("Noah", "Perez", 21),
    new Students("Ava", "Rodriguez", 18)
};

IEnumerable<Students> union = departmentAB.Union(departmentBC);

Console.WriteLine("Students in the Union of Departments:");

foreach (var stu in union)
{
    Console.WriteLine($"First Name: {stu.FirstName}, Last Name: {stu.LastName}, Age: {stu.Age}");
}



#endregion