#region OlderWays
//string[] names = { "Ali", "Pahriz", "Mexti", "Gurban" };
//string[] surnames = {"Dcafarov", "Mahmudov", "Aliev", "Gurbanov" };
//byte[] age = { 12, 14, 13, 15 };

//for (int i = 0; i < names.Length; i++)
//{
//    //Console.WriteLine(names[i]+" " +surnames[i]+" "+age[i]);
//    Console.WriteLine($"Datas: {names} {surnames} {age} ");
//}


//var student1 = new
//{
//    Name = "Alik",
//    Surname = "Rustamov",
//    Age = 45
//};
//var student2 = new
//{
//    Name = "Alikov",
//    Surname = "Bastamov",
//    Age = 15,
//    Point = 56
//};
//var student3 = new
//{
//    Fullname = "Adil Muradov"
//    Age = 25
//};

//Console.WriteLine(student1.Name);
//Console.WriteLine(student2.Surname);


#endregion

//Student std1 = new Student();
//std1.Name = "Murad";
//std1.Surname = "Mehmarov";
//std1.Age = 48;
//std1.Point = 13;
//Student std2 = new Student
//{
//    Name = "Ali",
//    Surname = "Bratanov",
//    Age = 19,
//    Point = 76
//};

//Console.WriteLine($" {std1.Name} {std1.Surname} {std1.Age} {std1.Point}");
//Console.WriteLine($" {std2.Name} {std2.Surname} {std2.Age} {std2.Point}");


//Student[] students = { std2, std1 };

//foreach (Student std in students)
//{
//    Console.WriteLine($" {std.Name} {std.Surname} {std.Age} {std.Point}");
//}

//for (int i = 0; i < students.Length; i++)
//{
//    Console.WriteLine($" {students[i].Name} {students[i].Surname} {students[i].Age} {students[i].Point}");
//}
//Human human = new Human();
//human.Name = "Rasim";

//Student student = new Student();
//student.Fullname = "Behruz";

//Teacher teacher = new Teacher
//{
//    Name = "Rasul"
//};

//Console.WriteLine($"{teacher.Name} {human.Name} {student.Name}");

//Student student2 = new Student { 

//};

//Student student1 = new Student();    
//Student student = new Student("Rafat");
//Student student2 = new Student("Rasad", "Pahrizov"); 


Student student3 = new Student("Ali", "Mexmudov", 12, 91);
Console.WriteLine(  student3.Name+" "+student3.Surname+" "+student3.Age+" "+student3.Point);

student3.GetFullName();

Human human = new Human();
human.Name = "Khumar";
human.Surname = "Khumarova";
human.Age = 19;
human.ShowFullDate();
string Fullname = human.GetFullName();
Console.WriteLine(Fullname);

class Human
{
    public string Name;
    public string Surname;
    public int Age;
    
    public void ShowFullDate()
    {
        Console.WriteLine($"{this.Name} {this.Surname} {this.Age} ");
    }

    public string GetFullName()
    {
        return this.Name+" "+ this.Surname;
    }

}


class Student : Human 
{
    public Student()
    {
        Console.WriteLine("Student created");
    }
    public Student(string name) : this()
    {
        this.Name = name;
    }
    public Student(string name, string surname): this(name)
    {
       this.Surname = surname
    }
    public Student(string name, string surname, int age): this(name,surname)
    {
        this.Age = age;
    }
    public Student(string name, string surname, int age, double point) : this(name, surname,age)
    {
      this.Point = point;
    }
    public double Point;
}

class Teacher : Human
{
    public string Profession;
}