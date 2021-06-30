using EntityFrameworkAssignment.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            //PRINT NAMES OF ALL STUDENTS
            //    var studentcontext = new StudentsContext();
            //    var students = studentcontext.GetStudents();
            //    foreach (var student in students)
            //    {
            //        Console.WriteLine(student);
            //    }

            //PRINT COURSE NAMES    
            //var coursecontext = new StudentsContext();
            //var courses = coursecontext.GetCourses();
            //foreach (var course in courses)
            //{
            //    Console.WriteLine(course);
            //}

            //PRINT COURSES WITH NO STUDENTS hint hint there are none lol  
            //var studentscourse = new StudentsContext();
            //var courses = studentscourse.GetEmptyCourses();
            //foreach (var course in courses)
            //{
            //    Console.WriteLine(course);
            //}

            //PRINT ALL TEACHERS
            //var teacherscontext = new StudentsContext();
            //var teachers = teacherscontext.GetTeachers();
            //foreach (var teacher in teachers)
            //{
            //    Console.WriteLine(teacher);
            //}

            //FIRE MIKE

            //var mikecontext = new StudentsContext();
            //var mikefired = mikecontext.MakeSureMikeIsFired();
            //mikefired = mikecontext.FireMike();

            //Console.WriteLine("done. Mike is fired");
            // had to remove foreign key constraints/relationships.


            //GIVE EVERY TEACHER 1.5% RAISE

            //var teachercontext = new StudentsContext();
            //var teachers = teachercontext.GivingRaise();

            //foreach (var teacher in teachers)
            //{
            //    Console.WriteLine($"Gave a raise to {teacher.Name} for a new total salary of {teacher.RaiseAmount}!!");
            //}

            //GIVE NON TEACHERS 30% RAISE

            //var nonteachers = new StudentsContext();
            //var unteachers = nonteachers.GiveRaiseThirty();
            //foreach (var unteacher in unteachers)
            //{
            //    Console.WriteLine("Raise Given to " + unteacher.Name + " in the total amount of " + unteacher.RaiseAmount);
            //}

        }
    }
}
