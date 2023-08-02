
using System;
using System.Xml.Linq;

namespace Phase1section5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            Subject algebra = new Subject();
            algebra.Name = "Algebra";

            Subject physics = new Subject();
            physics.Name = "Physics";

            SubjectTeacher algebraTeacher = new SubjectTeacher();
            algebraTeacher.Name = "Mr. Algebra";
            algebraTeacher.ContactAddress = "Some Address";
            algebraTeacher.DateOfJoining = Convert.ToDateTime("2009-10-20 00:00:00");
            algebraTeacher.WhichSubject = algebra;

            SubjectTeacher physicsTeacher = new SubjectTeacher();
            physicsTeacher.Name = "Mr. Physics";
            physicsTeacher.ContactAddress = "Some Address";
            physicsTeacher.DateOfJoining = Convert.ToDateTime("2009-10-20 00:00:00");
            physicsTeacher.WhichSubject = physics;

            CClass class8 = new CClass();
            class8.Name = "8";

            ClassTeacher teacherOf8 = new ClassTeacher();
            teacherOf8.Name = "Mrs. Class 8 Teachers";
            teacherOf8.ContactAddress = "Some Address";
            teacherOf8.DateOfJoining = Convert.ToDateTime("2009-10-20 00:00:00");
            teacherOf8.WhichClass = class8;

            class8.WhichTeacher = teacherOf8;

            // Print information to the console
            Console.WriteLine("Subject: " + algebra.Name);
            Console.WriteLine("Teacher: " + algebraTeacher.Name);
            Console.WriteLine("Contact Address: " + algebraTeacher.ContactAddress);
            Console.WriteLine("Date of Joining: " + algebraTeacher.DateOfJoining);
            Console.WriteLine("Assigned Subject: " + algebraTeacher.WhichSubject.Name);

            Console.WriteLine("\nSubject: " + physics.Name);
            Console.WriteLine("Teacher: " + physicsTeacher.Name);
            Console.WriteLine("Contact Address: " + physicsTeacher.ContactAddress);
            Console.WriteLine("Date of Joining: " + physicsTeacher.DateOfJoining);
            Console.WriteLine("Assigned Subject: " + physicsTeacher.WhichSubject.Name);

            Console.WriteLine("\nClass: " + class8.Name);
            Console.WriteLine("Class Teacher: " + teacherOf8.Name);
            Console.WriteLine("Contact Address: " + teacherOf8.ContactAddress);
            Console.WriteLine("Date of Joining: " + teacherOf8.DateOfJoining);
            //Console.WriteLine("Assigned Class: " + class8.WhichTeacher.whichClass.Name);
        }
    }
}