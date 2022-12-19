
internal class Student
{

    public string Name;
    public string SurName;
    public double Point;
    public string Group;
    public bool IsGraduet;
    string data;
    public Student(string name, string surName, double point, string group)
    {
        Name = name;
        SurName = surName;
        Point = point;
        Group = group;
        IsGraduet =point>80?true:false;
    }


    public string GetFullName()
    { 
       
        return $"{Name} {SurName}";
        //return Name + " " + SurName;
    }
    public string GetFullInfo()
    {
       
        return $"{Name} {SurName} {Group} {Point}  {IsGraduet}";
    }
    public void GetFullInfoVoid()
    {
        Console.WriteLine($"{Name} {SurName} {Group} {Point}  {IsGraduet}");
    }

    public bool GetGrad()
    {

        return IsGraduet;
    }
}

