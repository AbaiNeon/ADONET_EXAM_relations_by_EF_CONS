using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_ADONET
{
    class Program
    {
        static void Main(string[] args)
        {
            using(Context db = new Context())
            {
                //группы-студенты //один ко многим
                Group group1 = new Group { Name = "SMP", Course = 1 };
                Group group2 = new Group { Name = "SDP", Course = 1 };
                Group group3 = new Group { Name = "SEP", Course = 1 };
                db.Groups.Add(group1);
                db.Groups.Add(group2);
                db.Groups.Add(group3);
                db.SaveChanges();

                Student student1 = new Student { Name = "AAA", Course = 1, GroupId = 1 };
                Student student2 = new Student { Name = "BBB", Course = 1, GroupId = 1 };
                Student student3 = new Student { Name = "CCC", Course = 1, GroupId = 2 };
                db.Students.AddRange(new List<Student> { student1, student2, student3 });
                db.SaveChanges();

                //преподаватаели-предметы //многое ко многим
                Teacher teacher1 = new Teacher { Name = "TeachAAA", Experience = 1, Position = "junior lecturer" };
                Teacher teacher2 = new Teacher { Name = "TeachBBB", Experience = 2, Position = "senior lecturer" };
                Teacher teacher3 = new Teacher { Name = "TeachCCC", Experience = 3, Position = "senior lecturer" };
                //db.Teachers.AddRange(new List<Teacher> { teacher1, teacher2, teacher3 });
                //db.SaveChanges();

                Subject subject1 = new Subject { Name = "C++" };
                subject1.Teachers.Add(teacher1);
                subject1.Teachers.Add(teacher2);
                Subject subject2 = new Subject { Name = "Java" };
                subject2.Teachers.Add(teacher2);
                Subject subject3 = new Subject { Name = "Python" };
                subject3.Teachers.Add(teacher3);
                db.Subjects.Add(subject1);
                db.Subjects.Add(subject2);
                db.Subjects.Add(subject3);
                db.SaveChanges();

                //преподаватаели-группы //многое ко многим
                teacher1.Groups.Add(group1);
                teacher1.Groups.Add(group2);
                teacher2.Groups.Add(group2);
                teacher3.Groups.Add(group3);
                db.Teachers.AddRange(new List<Teacher> { teacher1, teacher2, teacher3 });
                db.SaveChanges();

                //расписание-преподватлеи //один ко многим
                Schedule schedule1 = new Schedule { Time = "9:00", TeacherId = 1, SubjectId = 1, GroupId = 1 };
                Schedule schedule2 = new Schedule { Time = "13:00", TeacherId = 2, SubjectId = 2, GroupId = 2 };
                Schedule schedule3 = new Schedule { Time = "17:00", TeacherId = 3, SubjectId = 3, GroupId = 3 };
                db.Schedules.Add(schedule1);
                db.Schedules.Add(schedule2);
                db.Schedules.Add(schedule3);
                db.SaveChanges();
            }
        }
    }
}
