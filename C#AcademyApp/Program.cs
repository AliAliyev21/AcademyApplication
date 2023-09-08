namespace C_AcademyApp
{
    public class Program
    {
        // Task
        //Academy,Group,Teacher,Student 
        //Akademy ve orda telebe qeydiyyati ve muellim qeydiyyati var
        //1.Make New Group
        //2.Set Teacher(Id,Fullname,Age,Experience,Speciality)
        //3.Add Student(Id,Fullname,Score,Speciality)
        //4.Add Student one more
        //5.Exit
        //6.Show All Groups                

        public class Student
        {
            public int Id { get; private set; }
            public static int StudentId { get; private set; }
            public string? Name { get; set; }
            public string? Surname { get; set; }
            public string? Speciality { get; set; }
            public int Age { get; set; }
            public double Score { get; set; }

            public Student() { }
           
            public Student(string name, string surname, string speciality, int age, double score)
            {               
                Id = ++StudentId;
                Name = name;
                Surname = surname;
                Speciality = speciality;
                Age = age;
                Score = score;
            }

            public void ShowStudent()
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Id = {Id}");
                Console.ResetColor();
                Console.WriteLine($"Name = > [{Name}]");
                Console.WriteLine($"Surname = > [{Surname}]");
                Console.WriteLine($"Speciality = > [{Speciality}]");
                Console.WriteLine($"Age = > [{Age}]");
                Console.WriteLine($"Score = > [{Score}]");
            }
        }

        public class Teacher
        {
            public int Id { get; private set; }
            public static int TeacherId { get; set; }
            public string? Name { get; set; }
            public string? Surname { get; set; }
            public string? Speciality { get; set; }
            public int Age { get; set; }
            public string? Experience { get; set; }

            public Teacher() { } 
           
            public Teacher(string? name, string? surname, string? speciality, int age, string? experience)
            {
                Id = ++TeacherId;
                Name = name;
                Surname = surname;
                Speciality = speciality;
                Age = age;
                Experience = experience;
            }



            public void ShowTeacher()
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Id = {Id}");
                Console.ResetColor();
                Console.WriteLine($"Name = > [{Name}]");
                Console.WriteLine($"Surname = > [{Surname}]");
                Console.WriteLine($"Speciality = > [{Speciality}]");
                Console.WriteLine($"Age = > [{Age}]");
                Console.WriteLine($"Experience = > [{Experience}]");
            }
        }


        public class Group
        {

            public string? Name { get; set; }
            public Student[]? Students { get; set; }
            public Teacher[]? Teachers { get; set; }

            public Group() { }

            public Group(string? name, Student[]? students, Teacher[]? teachers)
            {
                Name = name;
                Students = students;
                Teachers = teachers;
            }

            public void ShowGroups()
            {
                Console.ForegroundColor= ConsoleColor.DarkBlue;
                Console.WriteLine($"\t= > = > = >Group [{Name}]< = < = < = ");
                Console.ResetColor();
                Console.WriteLine();
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine("= >Students< =");
                Console.ResetColor();
                if (Students != null)
                {
                    foreach (var student in Students)
                    {
                        student.ShowStudent();
                        Console.WriteLine();
                    }
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("= >Teachers< =");
                Console.ResetColor();
                if (Teachers != null)
                {
                    foreach (var teacher in Teachers)
                    {
                        teacher.ShowTeacher();
                        Console.WriteLine();
                    }
                }
            }
        }

        public class Academy
        {
            public string? Name { set; get; }
            public Group[]? Groups { get; set; }
            public Teacher[]? Teachers { get; set; }
            public Student[]? Students { get; set; }

            public Academy() { }

            public Academy(string? name, Group[]? groups, Teacher[]? teachers, Student[]? students)
            {
                Name = name;
                Groups = groups;
                Teachers = teachers;
                Students = students;
            }

            public void AddTeacher(Teacher teacher)
            {
                if (Teachers == null)
                {
                    Teachers = new Teacher[] { teacher };
                }
                else
                {
                    Teacher[] updatedTeachers = new Teacher[Teachers.Length + 1];
                    for (int i = 0; i < Teachers.Length; i++)
                    {
                        updatedTeachers[i] = Teachers[i];
                    }
                    updatedTeachers[Teachers.Length] = teacher;
                    Teachers = updatedTeachers;
                }
            }

            public void AddStudent(Student student)
            {
                if (Students == null)
                {
                    Students = new Student[] { student };
                }
                else
                {
                    Student[] updatedStudents = new Student[Students.Length + 1];
                    for (int i = 0; i < Students.Length; i++)
                    {
                        updatedStudents[i] = Students[i];
                    }
                    updatedStudents[Students.Length] = student;
                    Students = updatedStudents;
                }
            }

            public void MakeNewGroup(Group group)
            {
                if (Groups == null)
                {
                    Groups = new Group[] { group };
                }
                else
                {
                    Group[] updatedGroups = new Group[Groups.Length + 1];
                    for (int i = 0; i < Groups.Length; i++)
                    {
                        updatedGroups[i] = Groups[i];
                    }
                    updatedGroups[Groups.Length] = group;
                    Groups = updatedGroups;
                }
            }

            public void AddMoreOneStudent(Student student)
            {
                if (Students == null)
                {
                    Students = new Student[] { student };
                }
                else
                {
                    Student[] updatedStudents = new Student[Students.Length + 1];
                    for (int i = 0; i < Students.Length; i++)
                    {
                        updatedStudents[i] = Students[i];
                    }
                    updatedStudents[Students.Length] = student;
                    Students = updatedStudents;
                }
            }

            public void ShowAllStudents()
            {              
                if (Students != null)
                {
                    foreach (var student in Students)
                    {
                        student.ShowStudent();
                        Console.WriteLine();
                    }
                }
            }

            public void ShowAllTeachers()
            {
                if (Teachers != null)
                {
                    foreach (var teacher in Teachers)
                    {
                        teacher.ShowTeacher();
                        Console.WriteLine();
                    }
                }
            }

            public void ShowAllGroups()
            {
                 if(Groups != null)
                 {
                    foreach(var group in Groups)
                    {
                        group.ShowGroups();
                        Console.WriteLine();
                    }
                 }
            }
        }


        static void Main(string[] args)
        {
            Academy academy = new Academy("StepITAcademy", null, null, null);

            //Birinci Qurup, Telebeleri ve Muellimi
            Student s1 = new Student("Ali", "Aliyev", "IT", 23, 100);
            Student s2 = new Student("Anvar", "Mammadov", "IT", 21, 100);
            Student s3 = new Student("Vuqar", "Aslanov", "IT", 23, 100);
            Teacher t1 = new Teacher("Elvin","Camalzade","FullStackDevelopment",23,"5year");
            academy.AddStudent(s1);
            academy.AddStudent(s2);
            academy.AddStudent(s3);
            academy.AddTeacher(t1);
            Group g1 = new Group("IT101",new Student[] { s1, s2, s3 }, new Teacher[] { t1 });
            academy.MakeNewGroup(g1);

            //Ikinci Qurup, Telebeleri ve Muellimi
            Student s4 = new Student("Nigar", "Hasanova", "IT", 22, 95);
            Student s5 = new Student("Rauf", "Aliyev", "IT", 24, 98);
            Student s6 = new Student("Aysel", "Mammadova", "IT", 20, 92);
            Teacher t2 = new Teacher("Leyla", "Mammadova", "Front-End", 25, "3year");
            academy.AddStudent(s4);
            academy.AddStudent(s5);
            academy.AddStudent(s6);
            academy.AddTeacher(t2);
            Group g2 = new Group("IT102",new Student[] {s4 , s5, s6 }, new Teacher[] { t2 });
            academy.MakeNewGroup(g2);

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\t\t= > = > = >StepITAcademy< = < = < =");
                Console.ResetColor();              
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Make New Group       [1]");
                Console.WriteLine("Set Teacher          [2]");
                Console.WriteLine("Add Student          [3]");
                Console.WriteLine("Add One More Student [4]");
                Console.WriteLine("Show All Students    [5]");
                Console.WriteLine("Show All Teachers    [6]");
                Console.WriteLine("Show All Groups      [7]");
                Console.WriteLine("Exit                 [0]");
                Console.ResetColor();              

                Console.Write("Select an option : ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Enter a name for the new group : ");
                        string groupName = Console.ReadLine();
                        Group newGroup = new Group(groupName, null, null);
                        academy.MakeNewGroup(newGroup);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Group [{groupName}] has been created");
                        Console.ResetColor();
                        Thread.Sleep(600);
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Console.Write("Enter Teacher's Name : ");
                        string teacherName = Console.ReadLine();
                        Console.Write("Enter Teacher's Surname : ");
                        string teacherSurname= Console.ReadLine();
                        Console.Write("Enter Teacher's Age : ");
                        int teacherAge = int.Parse(Console.ReadLine());
                        Console.Write("Enter Teacher's Speciality : ");
                        string teacherSpeciality = Console.ReadLine();
                        Console.Write("Enter Teacher's Experience : ");
                        string teacherExperience = Console.ReadLine();
                        Teacher newTeacher = new Teacher(teacherName, teacherSurname, teacherSpeciality, teacherAge, teacherExperience);
                        Console.ForegroundColor= ConsoleColor.Blue;
                        academy.AddTeacher(newTeacher);
                        Console.WriteLine($"Teacher [{teacherName}] has been added");
                        Console.ResetColor();
                        Thread.Sleep(600);
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        Console.Write("Enter Student's Name : ");
                        string studentName = Console.ReadLine(); 
                        Console.Write("Enter Student's Surname : ");
                        string studentSurname = Console.ReadLine();
                        Console.Write("Enter Student's Age : ");
                        int studentAge = int.Parse(Console.ReadLine());
                        Console.Write("Enter Student's Speciality : ");
                        string studentSpeciality = Console.ReadLine();
                        Console.Write("Enter Student's Score : ");
                        double studentScore = double.Parse(Console.ReadLine());
                        Student newStudent = new Student(studentName, studentSurname, studentSpeciality, studentAge, studentScore);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        academy.AddStudent(newStudent);
                        Console.WriteLine($"Student [{studentName}] has been added");
                        Console.ResetColor();
                        Thread.Sleep(600);
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        Console.Write("Enter Student's Name : ");
                        string moreStudentName = Console.ReadLine();
                        Console.Write("Enter Student's Surname : ");
                        string moreStudentSurname = Console.ReadLine();
                        Console.Write("Enter Student's Age : ");
                        int moreStudentAge = int.Parse(Console.ReadLine());
                        Console.Write("Enter Student's Speciality : ");
                        string moreStudentSpeciality = Console.ReadLine();
                        Console.Write("Enter Student's Score : ");
                        double moreStudentScore = double.Parse(Console.ReadLine());
                        Student moreStudent = new Student(moreStudentName, moreStudentSurname, moreStudentSpeciality, moreStudentAge, moreStudentScore);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        academy.AddMoreOneStudent(moreStudent);
                        Console.WriteLine($"Additional student [{moreStudentName}] has been added.");
                        Console.ResetColor();
                        Thread.Sleep(600);
                        Console.Clear();
                        break;
                    case "5":
                        Console.Clear();
                        Console.ForegroundColor= ConsoleColor.DarkRed;
                        Console.WriteLine("\t= > = > = >Students< = < = < =");
                        Console.WriteLine();
                        Console.ResetColor();
                        academy.ShowAllStudents();
                        break;
                    case "6":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\t= > = > = >Teachers< = < = < =");
                        Console.WriteLine();
                        Console.ResetColor();
                        academy.ShowAllTeachers();
                        break;
                    case "7":
                        Console.Clear();
                        academy.ShowAllGroups();
                        break;
                    case "0":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Exiting programming.....");
                        Console.ResetColor();
                        Thread.Sleep(300);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
    }
}
