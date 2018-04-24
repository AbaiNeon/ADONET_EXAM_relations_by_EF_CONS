using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_ADONET
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Course { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        //public ICollection<Group> Groups { get; set; }
        public Group()
        {
            Students = new List<Student>();
            Teachers = new List<Teacher>();
            //Groups = new List<Group>();
        }

        
        
    }
}
