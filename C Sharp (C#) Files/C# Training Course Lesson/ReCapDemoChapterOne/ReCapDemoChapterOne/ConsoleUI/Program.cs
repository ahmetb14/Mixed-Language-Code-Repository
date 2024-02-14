using ReCapDemoChapterOne.Business.Concretes;
using ReCapDemoChapterOne.DataAccess.Concretes;
using ReCapDemoChapterOne.Entities.Concretes;

CourseManager courseManager = new CourseManager(new CourseDal());

Console.WriteLine("**********************************************************************");

Console.WriteLine("[Tüm Kursları Listeleme]");
Console.WriteLine("------------------------");
Console.WriteLine(" ");
List<Course> courses = courseManager.GetAll();
courseManager.PrintAll(courses);

Console.WriteLine("**********************************************************************");

Console.WriteLine("[Yeni Kurs Ekleme]");
Console.WriteLine("------------------");
Console.WriteLine(" ");
courseManager.Add(new Course()
{
    CourseName = "Python",
    CourseId = 3,
    CourseDescription = "Python Temel Seviye Programla Kampı",
    InstructorId = 1,
    CategoryId = 3,
    CoursePrice = 0
});
courseManager.PrintAll(courses);

Console.WriteLine("**********************************************************************");

Console.WriteLine("[Mevcut Kursu Güncelleme]");
Console.WriteLine("-------------------------");
Console.WriteLine(" ");
courseManager.Update(new Course()
{
    CourseName = "Python",
    CourseId = 3,
    CourseDescription = "Python Temel Seviye Programla Kampı",
    InstructorId = 2,
    CategoryId = 3,
    CoursePrice = 0
});
courseManager.PrintAll(courses);

Console.WriteLine("**********************************************************************");

Console.WriteLine("[Kayıtlı Kursu Silme]");
Console.WriteLine("---------------------");
Console.WriteLine(" ");
courseManager.Delete(2);
courseManager.PrintAll(courses);

Console.WriteLine("**********************************************************************");

Console.WriteLine("[Kurs Numarasına Göre Listeleme]");
Console.WriteLine("--------------------------------");
Console.WriteLine(" ");
courseManager.PrintCourse(courseManager.GetById(3));

Console.WriteLine("**********************************************************************");

