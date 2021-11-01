using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace T2008M_WAD_Exam.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public DateTime StartDateTime { get; set; }
        public int Duration { get; set; }
        public string ClassRoom { get; set; }
        public string Faculty { get; set; }

        public virtual string Status
        {
            get {
                DateTime start = StartDateTime;
                DateTime end = StartDateTime.AddMinutes(Duration);
                DateTime now = DateTime.Now;
                if (now < start) return "Upcoming";
                if (now >= start && now <= end) return "On going";
                return "done";
            }
        }
    }

    public class ExamFormViewModel
    {
        [Required]
        public string Subject { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required]
        [DataType(DataType.Time)]

        public DateTime Time { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        [Display(Name = "Duration (in minutes)")]
        public int Duration { get; set; }
        [Required]
        public string ClassRoom { get; set; }
        [Required]
        public string Faculty { get; set; }

        public static IEnumerable<string> Subjects = new List<string> { "Java Core", "Advanced Java", "Programming C#" };
        public static IEnumerable<string> ClassRooms = new List<string> { "A8", "A10", "B10" };
        
    }
}