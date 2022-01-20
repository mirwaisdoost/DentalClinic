using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DentalClinic.Models;
using DentalClinic.ViewModels;
using EntityFramework.Extensions;

namespace DentalClinic.Controlls
{
    public class StudentViewModelController : Controller
    {
        private readonly DentalClinicContext _context;

        public StudentViewModelController(DentalClinicContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<StudentViewModel> lst = new List<StudentViewModel>();
            StudentViewModel svm;
            var student = _context.Student;
            foreach(Student s in student)
            {
                //var ssgd = _context.StudentSessionGroupDoctor.Where(p=>p.StudentId==s.StudentId);
                //var Doctor = _context.Doctor.Where(p => p.DoctorId == ssgd.First().DoctorId);
                //var Session = _context.Session.Where(p => p.SessionId == ssgd.First().SessionId);
                //var StudentGroup = _context.StudentGroup.Where(p => p.StudentGroupId == ssgd.First().GroupId);
                //var semester = _context.Semester.Where(p => p.SemesterId == ssgd.First().SemesterId);
                //var subject = _context.Subject.Where(p => p.SubjectId == ssgd.First().SubjectId);

                svm = new StudentViewModel();
                //svm.doctorName = Doctor.First().Name;
                //svm.sessionName = Session.First().Name;
                //svm.studentGroupName = StudentGroup.First().Name;
                //svm.semesterName = semester.First().Name;
                //svm.subjectName = subject.First().Name;
                //svm.Duration = ssgd.First().Duration;
                svm.StudentId = s.StudentId;
                svm.Name = s.Name;
                svm.fatherName = s.FatherName;
                svm.lastName = s.LastName;
                svm.phone = s.Phone;
                lst.Add(svm);
            }
            return View(lst);
        }

        [HttpGet]
        public IActionResult AddOrEdit(int id=0)
        {
            List<Doctor> doctor = new List<Doctor>();
            doctor = (from item in _context.Doctor select item).ToList();
            ViewBag.doctor = doctor;

            List<Session> session = new List<Session>();
            session = (from item in _context.Session select item).ToList();
            session.Insert(0, new Session { SessionId = 0, Name = "Select" });
            ViewBag.session = session;
        
            List<StudentGroup> studentGroup = new List<StudentGroup>();
            studentGroup = (from item in _context.StudentGroup select item).ToList();
            studentGroup.Insert(0, new StudentGroup { StudentGroupId = 0, Name = "Select" });
            ViewBag.studentGroup = studentGroup;

            List<Semester> semester = new List<Semester>();
            semester = (from item in _context.Semester select item).ToList();
            semester.Insert(0, new Semester { SemesterId = 0, Name = "Select" });
            ViewBag.semester = semester;

            List<Subject> subject = new List<Subject>();
            subject = (from item in _context.Subject select item).ToList();
            subject.Insert(0, new Subject { SubjectId = 0, Name = "Select" });
            ViewBag.subject = subject;

            var student = _context.Student.Where(p => p.StudentId == id);
            var ssgd = _context.StudentSessionGroupDoctor.Where(p => p.StudentId == student.First().StudentId);   

            if (id == 0)
                return View(new StudentViewModel());
            else
            {
                StudentViewModel studentViewModel = new StudentViewModel()
                {
                    StudentId = student.First().StudentId,
                    Name = student.First().Name,
                    fatherName = student.First().FatherName,
                    lastName=student.First().LastName,
                    phone=student.First().Phone,
                    sessionID = ssgd.First().SessionId,
                    studentGroupID = ssgd.First().GroupId,
                    doctorID = ssgd.First().DoctorId,
                    semesterID = ssgd.First().SemesterId,
                    subjectID = ssgd.First().SubjectId,
                    Duration = ssgd.First().Duration
                };

                return View(studentViewModel);
            }
                
        }
        public ActionResult NewSession()
        {
            Student();
            return PartialView("~/Views/StudentViewModel/Session.cshtml");
        }
        public ActionResult NewStudent()
        {
            return PartialView("~/Views/StudentViewModel/AddOrEdit.cshtml");
        }

        private void Student()
        {
            List<Session> session = new List<Session>();
            session = (from item in _context.Session select item).ToList();
            ViewBag.session = session;

            List<StudentGroup> studentGroup = new List<StudentGroup>();
            studentGroup = (from item in _context.StudentGroup select item).ToList();
            ViewBag.studentGroup = studentGroup;

            List<Semester> semester = new List<Semester>();
            semester = (from item in _context.Semester select item).ToList();
            ViewBag.semester = semester;

        }

        public IActionResult searchStudent(int studentID)
        {

            var ssgd = _context.StudentSessionGroupDoctor.Where(p => p.StudentId == studentID);

            List<int> StudentID = new List<int>();
            List<int> ssgdID = new List<int>();
            List<string> StudentName = new List<string>();
            List<string> Session = new List<string>();

            foreach (var c in ssgd)
            {
                ssgdID.Add(c.StudentSessionGroupDoctorId);
                var student = _context.Student.Where(p => p.StudentId == c.StudentId);
                StudentName.Add(student.First().Name);
                StudentID.Add(student.First().StudentId);
                var session = _context.Session.Where(p => p.SessionId == c.SessionId);
                Session.Add(session.First().Name);
            }
            
            StudentViewModel svm = new StudentViewModel
            {
                studentIDList = StudentID,
                studentNameList = StudentName,
                sessionNameList = Session,
                ListID = ssgdID,
                StudentId=_context.Student.Where(p=>p.StudentId==studentID).First().StudentId,
                Name=_context.Student.Where(p=>p.StudentId==studentID).First().Name,
                fatherName=_context.Student.Where(p=>p.StudentId==studentID).First().FatherName,
                lastName=_context.Student.Where(p=>p.StudentId==studentID).First().LastName,
                phone=_context.Student.Where(p=>p.StudentId==studentID).First().Phone,
            };
            return new JsonResult(svm);
        }

        public IActionResult SearchBySSGDId(int id)
        {
            var SSGD= _context.StudentSessionGroupDoctor.Where(p => p.StudentSessionGroupDoctorId == id).First();
            StudentViewModel svm = new StudentViewModel
            {
                StudentId = SSGD.StudentId,
                Name=_context.Student.Where(p=>p.StudentId== SSGD.StudentId).First().Name,
                fatherName=_context.Student.Where(p=>p.StudentId== SSGD.StudentId).First().FatherName,
                lastName=_context.Student.Where(p=>p.StudentId== SSGD.StudentId).First().LastName,
                phone=_context.Student.Where(p=>p.StudentId== SSGD.StudentId).First().Phone,
                sessionName=_context.Session.Where(p=>p.SessionId== SSGD.SessionId).First().Name,
                sessionID=_context.Session.Where(p=>p.SessionId== SSGD.SessionId).First().SessionId,
                studentGroupName=_context.StudentGroup.Where(p=>p.StudentGroupId== SSGD.GroupId).First().Name,
                studentGroupID=_context.StudentGroup.Where(p=>p.StudentGroupId== SSGD.GroupId).First().StudentGroupId,
                doctorName=_context.Doctor.Where(p=>p.DoctorId== SSGD.DoctorId).First().Name,
                doctorID=_context.Doctor.Where(p=>p.DoctorId== SSGD.DoctorId).First().DoctorId,
                semesterName=_context.Semester.Where(p=>p.SemesterId== SSGD.SemesterId).First().Name,
                semesterID=_context.Semester.Where(p=>p.SemesterId== SSGD.SemesterId).First().SemesterId,
                subjectName=_context.Subject.Where(p=>p.SubjectId== SSGD.SubjectId).First().Name,
                subjectID=_context.Subject.Where(p=>p.SubjectId== SSGD.SubjectId).First().SubjectId,
                Duration=SSGD.Duration,
                SSGDID=SSGD.StudentSessionGroupDoctorId
            };
            return new JsonResult(svm);
        }

        [HttpPost]
        public IActionResult AddOrEditStudent(int id, string Name, string FatherName, string LastName, string Phone)
        {
            var studentID = 1;

            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    if (_context.Student.Count() == 0)
                        studentID = 1;
                    else
                        studentID = _context.Student.Max(p => p.StudentId) + 1;

                    Student student = new Student
                        {
                            StudentId = studentID,
                            Name = Name,
                            FatherName = FatherName,
                            LastName = LastName,
                            Phone = Phone
                        };
                    _context.Student.Add(student);
                }
                else
                {
                    var student = _context.Student.Find(id);
                    student.Name = Name;
                    student.FatherName = FatherName;
                    student.LastName = LastName;
                    student.Phone = Phone;
                    _context.Student.Update(student);
                    studentID = id;
                }
                _context.SaveChanges();
            }

            return Json(studentID);
        }

        [HttpPost]
        public IActionResult AddOrEditStudentSession(int SSGDID, int StudentId, int SessionId, int GroupId, int DoctorId, int SemesterId, int SubjectId, int Duration)
        {
            if (ModelState.IsValid)
            {
                if (SSGDID == 0)
                {
                    StudentSessionGroupDoctor studentSessionGroupDoctor = new StudentSessionGroupDoctor
                    {
                        StudentId = StudentId,
                        SessionId = SessionId,
                        GroupId = GroupId,
                        DoctorId = DoctorId,
                        SemesterId = SemesterId,
                        SubjectId = SubjectId,
                        Duration = Duration
                    };
                    _context.StudentSessionGroupDoctor.Add(studentSessionGroupDoctor);
                }
                else
                {
                    var SSGD = _context.StudentSessionGroupDoctor.Find(SSGDID);
                    SSGD.SessionId = SessionId;
                    SSGD.GroupId = GroupId;
                    SSGD.DoctorId = DoctorId;
                    SSGD.SemesterId = SemesterId;
                    SSGD.SubjectId = SubjectId;
                    SSGD.Duration = Duration;
                    _context.StudentSessionGroupDoctor.Update(SSGD);
                }
                _context.SaveChanges();
            }

            return Json("Saved!");
        }

        public async Task<IActionResult> Delete(int id)
        {
            _context.Student.Remove(_context.Student.Find(id));

            var SSGD = _context.StudentSessionGroupDoctor.Where(p => p.StudentId == id);
            foreach (var a in SSGD)
            {
                var ssgd = _context.StudentSessionGroupDoctor.Find(a.StudentSessionGroupDoctorId);
                if (ssgd != null)
                    _context.StudentSessionGroupDoctor.Remove(ssgd);
            }

            //var SSGD = _context.StudentSessionGroupDoctor.FirstOrDefault(m => m.StudentId == id);
            //_context.StudentSessionGroupDoctor.Remove(SSGD);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public JsonResult AutoCompleteSubjectSelect(string term)
        {
            var doctor = (from item in _context.Subject.Where(p => p.Name.Contains(term))
                          select new
                          { label = item.Name, id = item.SubjectId }).ToList();
            return Json(doctor);
        }

        public JsonResult AutoCompleteStudentSelect(string term)
        {
            var doctor = (from item in _context.Student.Where(p => p.Name.Contains(term))
                          select new
                          { label = item.Name, id = item.StudentId }).ToList();
            return Json(doctor);
        }
    }
}
