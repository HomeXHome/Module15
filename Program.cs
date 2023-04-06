using System.Linq;

namespace Module15
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {           
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }
        static string[] GetAllStudents(Classroom[] classes)
        {
            // Через Запросы LINQ
            //var studentList = from classroom in classes
            //                  from students in classroom.Students
            //                  select students;

            // Через методы расширения
            var studentList = classes.SelectMany(c => c.Students);
            return studentList.ToArray();
        }
    }
}
