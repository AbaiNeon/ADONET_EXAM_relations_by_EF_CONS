using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_ADONET
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public string Position { get; set; }

        public ICollection<Group> Groups { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
        public Teacher()
        {
            Groups = new List<Group>();
            Subjects = new List<Subject>();
            Schedules = new List<Schedule>();
        }
    }
}
