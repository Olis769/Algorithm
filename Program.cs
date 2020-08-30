using System;


namespace Result12
{


    public class Result {
        protected string Subject;
        protected string Teacher;
        protected int Points;
        public string subject
        {
            get { return Subject; }
            set
            {
                Subject = value;


            }

        }

        public string teacher
        {
            get { return Teacher; }
            set
            {
                Teacher = value;


            }

        }

        public int points
        {
            get { return Points; }
            set
            {
                if (value <= 100 && value >= 0)
                    Points = value;


            }

        }
        public Result(string sub, string tea, int po)
        {
            subject = sub;
            teacher = tea;
            points = po;

        }

        public Result(string tea)
        {

            teacher = tea;

        }
        public Result() {
            subject = "0";
            teacher = "0";
            points = 0;
        }

        public Result(Result result)
        {
            if (result != null)
            {
                subject = result.subject;
                teacher = result.teacher;
                points = result.points;
            }
            else throw new Exception("Empty element");
        }
        



    }

    class Student:IComparable {
       public const int ccc= 8;
        protected string Name;
        protected string Surname;
        protected string Group;
        protected string Year;
        protected Result[] results;

        protected int averageNumber;

        public int AverageNumber {
            get { return averageNumber; }
            set { averageNumber = value; }

        }
        public Result[] Results
        {

            get { return results; }
            set { results=value; }
        }
      
       

        public string name {
            get { return Name; }
            set {
                if (value.Length < 40)
                    Name = value;
            }

        }
        public string surname
        {
            get { return Surname; }
            set
            {

                Surname = value;
            }

        }

        public string group
        {
            get { return Group; }
            set
            {

                Group = value;
            }

        }

        public string year
        {
            get { return Year; }
            set
            {
                if (value.Length == 1)
                    if ("12345".Contains(value))
                        Year = value;
            }

        }
        //methods

         
        public int GetAveragePoints() {
            int d = 0;
            int iter =0;
            while (iter < this.Results.Length)
            {
                d += this.Results[iter].points;
                iter++;
            }
            AverageNumber = d / iter;
            return d/iter;
        }
        public string GetBestSubject() {
            int d = 0,cccc=0;
            int iter = 0;
            while (iter < this.Results.Length) {
                if (d < this.Results[iter].points)
                    cccc = iter;
                iter++;
            }

            return this.Results[cccc].subject;
        }

        public string GetWorstSubject()
        {
            int d = 100, cccc = 0;
            int iter = 0;
            while (iter < this.Results.Length)
            {
                if (d > this.Results[iter].points)
                    cccc = iter;
                iter++;
            }

            return this.Results[cccc].subject;
        }





        public Student() {
         name="-";
         surname = "-";
        group = "-";
        year = "-";
            int cou = 0;

            Results = new Result[ccc];

            while (cou < ccc)
            {

                this.Results[cou] = new Result(Results[cou]);

                cou++;
            }

        }
        public Student(string name,string surname,string group,string year,Result[] Results)
        {
            this.name = name;
            this.surname = surname;
            this.group = group;
            this.year = year;
            int cou = 0;

            this.Results = new Result[Results.Length];

            while (cou < Results.Length)
            {

                this.Results[cou] = new Result(Results[cou]);
                
                cou++;
            }

        }
        public Student(string name, int cc)
        {
            this.name = name;
            
            surname = "-";
            group = "-";
            year = "-";
            int cou = 0;
            Results = new Result[cc];
            while (cou < cc)
            {
                Results[cou] = new Result();
                cou++;
            }

        }

        public Student(Student stud)
        {

            name = stud.name;

            surname = stud.surname;
            group = stud.group;
            year = stud.year;
            int cou = 0;

            Results = new Result[stud.Results.Length];

            while (cou < stud.Results.Length)
            {
                Results[cou] = new Result(stud.Results[cou]);
                cou++;
            }
            }

        public int CompareTo(object obj) {

            Student p = obj as Student;

            if (p != null)
            {
               return this.name.CompareTo(p.name);
            }
                
            else throw new Exception("null, empty element");

            
        }

        
        
    }

    class SortComparer : System.Collections.IComparer<Student>
    {

        public int Compare(Student p1, Student p2)
        {

            if (p1.AverageNumber > p2.AverageNumber)
                return 1;
            else if (p1.AverageNumber < p2.AverageNumber)
                return -1;
            else return 0;

        }

    }





    class Program
    {
        static void Main(string[] args)
        {

           


            Console.WriteLine("Hello World!");

            Student[] Testing = new Student[8];
            //Student(string name, string surname, string group, string year, Result[] Results)
            int[] data = new int[8] { 50, 40, 45, 67, 89, 54, 54, 78 };

            Result[] ttt = new Result[8];
            int n = 0;
            for (; n < 8;n++) {

                ttt[n] = new Result("Math","Ivan",data[n]); ;
            }

            Testing[0] = new Student("Viktor"," Smishko  ",  "Pi1", "1", ttt);
            Testing[0].Results[0].points = 0;
            
            Testing[1] = new Student("Gis", " Petrenko ", "Pi1", "2", ttt);
            Testing[1].Results[0].points = 100;

            Testing[2] = new Student("Anatoliy", " Cherva  ", "Pi1", "3", ttt);
            Testing[2].Results[0].points = 50;
            Testing[3] = new Student("Wan", " Cherva  ", "Pi1", "3", ttt);
            Testing[4] = new Student("Wan", " Cherva  ", "Pi1", "3", ttt);
            Testing[5] = new Student("Wan", " Cherva  ", "Pi1", "3", ttt);
           Testing[6] = new Student("Wan", " Cherva  ", "Pi1", "3", ttt);
            Testing[7] = new Student("Wan", " Cherva  ", "Pi1", "3", ttt);

            n = 0;
            while (n < 8) {
                Testing[n].GetAveragePoints();
                n++;
            }
            

            int m = 0;
           

            SortStudentsByPoints(Testing);

            
            Console.WriteLine(Testing[0].AverageNumber);
            Console.WriteLine(Testing[1].AverageNumber);
            Console.WriteLine(Testing[2].AverageNumber);/**/
           /*SortStudentsByName(Testing);
            Console.WriteLine(Testing[0].name);
            Console.WriteLine(Testing[1].name);
            Console.WriteLine(Testing[2].name);*/


        }

        static Student[] ReadStudentsArray() {
            Console.Write("Enter array size");
            int n = Convert.ToInt16(Console.ReadLine());
            Student[] Arr= new Student[n];
            n = 0;
            while (n<Arr.Length) {
                Console.WriteLine("Enter the name ");
                Arr[n].name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the sur ");
                Arr[n].surname = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the group ");
                Arr[n].group = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the year ");
                Arr[n].year = Convert.ToString(Console.ReadLine());
                
                int iter = 0;
                while (iter < Arr[n].Results.Length)
                {
                    Console.WriteLine("Enter the subject");
                    Arr[n].Results[iter].subject = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter the teacher");
                    Arr[n].Results[iter].teacher = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter the teacher");
                    Arr[n].Results[iter].points = Convert.ToInt16(Console.ReadLine());



                    iter++;
                }

            }
            return Arr;
        }

        void GetStudentsInfo(Student[] sd,out int max,out int min) {
            max = 0;
            min = 100;
            int iter = 0;

            while (iter<sd.Length) {
                if (min > sd[iter].AverageNumber) min= sd[iter].AverageNumber;
                if (max < sd[iter].AverageNumber) max = sd[iter].AverageNumber;
            }
        }
        static void PrintStudent(Student Example)
        {
            if (Example != null) { 
            
                Console.WriteLine("\n\nStudent name \n"+ Example.name);
                
                Console.WriteLine("Student surname \n"+Example.surname);
             
                Console.WriteLine("Student group \n"+Example.group );

                Console.WriteLine("Student year \n"+Example.year);

                Console.WriteLine();
                int iter = 0;
                while (iter < Example.Results.Length)
                {
                    Console.WriteLine("Student subject\n" + Example.Results[iter].subject);
                    Console.WriteLine("Student teacher\n" + Example.Results[iter].teacher);
                    Console.WriteLine("Student points\n" + Convert.ToString(Example.Results[iter].points));



                    iter++;
                }
            }
        }



        static void PrintStudents(Student[] Example)
        {
            int iter = 0;
            while (iter < Example.Length)
            {
                PrintStudent(Example[iter]);
                iter++;
            }
             

        }

        static Student[] SortStudentsByPoints(Student[] Example)
        {

            

            //Array.Sort(Example, new SortComparer[8] );
            Array.Sort(Example, new SortComparer[8] );
            return Example;
        }


        static Student[] SortStudentsByName(Student[] Example)
        {

            Array.Sort(Example);
            return Example;
        }
    }




}

