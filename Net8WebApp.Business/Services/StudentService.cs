using Net8WebApp.Data;

namespace Net8WebApp.Business
{
    public class StudentService : IStudentService
    {
        public List<Student> GetINMemoryStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { Name = "Burak Asaf", LastName = "Sincar", StudentId = 1, Info = "Yaramaz" });
            students.Add(new Student() { Name = "Yiğit Ali", LastName = "Sincar", StudentId = 2, Info = "Geveze" });
            students.Add(new Student() { Name = "Onur Alp", LastName = "Arslan", StudentId = 3, Info = "Karizmatik" });
            students.Add(new Student() { Name = "Esra", LastName = "Çakıcı", StudentId = 4, Info = "Hareketli" });
            students.Add(new Student() { Name = "Tuğçe", LastName = "Toker", StudentId = 5, Info = "Zeki" });


            return students;
        }

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            using (var context = new SchoolDbContext())
            {
                students = context.Students.ToList();
            }

            return students;
        }
    }
}
