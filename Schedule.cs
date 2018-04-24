using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_ADONET
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }
        public string Time { get; set; }

        public int? TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        //-------------------------------------------
        public int? SubjectId { get; set; }
        public Subject Subject { get; set; }
        //-------------------------------------------
        public int? GroupId { get; set; }
        public Group Group { get; set; }

    }
}
