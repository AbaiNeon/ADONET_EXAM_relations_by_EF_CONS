using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_ADONET
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
        public Subject()
        {
            Teachers = new List<Teacher>();
            Schedules = new List<Schedule>();
        }
    }
}
