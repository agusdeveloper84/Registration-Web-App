using registrationWebApp;
using registrationWebApp.Models;
using System.Collections.Generic;

public class CourseRegistration
{
    public static List<Instructor> Instructors { get; } = new List<Instructor>();
    public static List<Student> Students { get; } = new List<Student>();
    public static List<Course> Courses { get; } = new List<Course>();

    public static void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public static void AddInstructor(Instructor instructor)
    {
        Instructors.Add(instructor);
    }

    public static void AddCourse(Course course)
    {
        Courses.Add(course);
    }
}
