using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DentalClinic.Models;

namespace DentalClinic.ViewModels
{
    public class StudentViewModel
    {
        [Key]
        public int? SSGDID { get; set; }
        public int? StudentId { get; set; }
        public string Name { get; set; }
        public string fatherName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public int? sessionID { get; set; }
        public string sessionName { get; set; }
        public int? studentGroupID { get; set; }
        public string studentGroupName { get; set; }
        public int? doctorID { get; set; }
        public string doctorName { get; set; }
        public int? semesterID { get; set; }
        public string semesterName { get; set; }
        public int? subjectID { get; set; }
        public string subjectName { get; set; }
        public int? Duration { get; set; }
        public List<string> sessionNameList { get; set; }
        public List<int> ListID { get; set; }
        public List<int> studentIDList { get; set; }
        public List<string> studentNameList { get; set; }
    }
}
