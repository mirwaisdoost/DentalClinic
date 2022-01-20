using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DentalClinic.Models;
using DentalClinic.ViewModels;
using System.Data;
using System.Globalization;

namespace DentalClinic.Controlls
{
    public class PatientRegisterationsController : Controller
    {
        private readonly DentalClinicContext _context;

        public PatientRegisterationsController(DentalClinicContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<PatientRegistrationViewModel> list = new List<PatientRegistrationViewModel>();
            PatientRegistrationViewModel prvm;
            var pr = _context.PatientRegisteration;

            foreach(PatientRegisteration p in pr)
            {
                var patient = _context.Patient.Where(t => t.PatientId == p.PatientId);
                var doctor = _context.Doctor.Where(d=>d.DoctorId==p.DoctorId);
                prvm=new PatientRegistrationViewModel();
                prvm.patientRegistrationID = p.PatientRegisterationId;
                prvm.patientName = patient.First().Name;
                prvm.doctorName = doctor.First().Name;
                prvm.registrationFee = p.RgisterationFee;
     
                list.Add(prvm);
            }
            return View(list);
        }

        public ActionResult NewCheck()
        {
            return PartialView("~/Views/PatientRegisterations/Check.cshtml");
        }
        public ActionResult NewPayment()
        {
            return PartialView("~/Views/PatientRegisterations/Payment.cshtml");
        }

        public ActionResult Check()
        {
            return PartialView("~/Views/PatientRegisterations/DrugModal.cshtml");
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            return View(new PatientRegisteration());
        }

        public IActionResult searchByPatient(int patientID)
        {
            var patientRegistration = _context.PatientRegisteration.Where(p =>
                    p.PatientId == patientID).ToList();
            var patient = _context.Patient.Where(p => p.PatientId == patientID);
            List<PatientRegistrationViewModel> lst = new List<PatientRegistrationViewModel>();
            PatientRegistrationViewModel prvm;

            if (patientRegistration.Count == 0)
            {
                foreach (var p in patient)
                {
                    prvm = new PatientRegistrationViewModel();
                    var gender = "";
                    if (patient.First().GenderId == 1)
                        gender = "Male";
                    else
                        gender = "Female";

                    prvm.patientRegistrationID = 0;
                    prvm.patientName = p.Name;
                    prvm.patientLastName = p.LastName;
                    prvm.patientPhone = p.Phone;
                    prvm.patientDateofBirth = p.DataOfBrith;
                    prvm.patientJob = p.Job;
                    prvm.patientGender = gender;
                    lst.Add(prvm);
                }
            }
            else
            {
                foreach (PatientRegisteration pr in patientRegistration)
                {
                    prvm = new PatientRegistrationViewModel();
                    var gender = "";
                    if (patient.First().GenderId == 1)
                        gender = "Male";
                    else
                        gender = "Female";

                    prvm.patientRegistrationID = pr.PatientRegisterationId;
                    prvm.registerDate = DateTime.Parse(Convert.ToDateTime(pr.Date).ToShortDateString());
                    prvm.patientName = patient.First().Name;
                    prvm.patientLastName = patient.First().LastName;
                    prvm.patientPhone = patient.First().Phone;
                    prvm.patientDateofBirth = patient.First().DataOfBrith;
                    prvm.patientJob = patient.First().Job;
                    prvm.patientGender = gender;
                    prvm.registrationFee = pr.RgisterationFee;
                    lst.Add(prvm);
                }
            }

            return new JsonResult(lst);
        }

        public IActionResult searchByRegistration(int RegistrationID)
        {
            var patientRegistration = _context.PatientRegisteration.Where(p => 
                    p.PatientRegisterationId == RegistrationID);
            var doctor = _context.Doctor.Where(p => 
                    p.DoctorId == patientRegistration.First().DoctorId);
            var patient = _context.Patient.Where(p => 
                    p.PatientId == patientRegistration.First().PatientId);
            var patientHistory = _context.PatientHistory.Where(p => 
                    p.PatientRegisterationId == RegistrationID).ToList();
            var patientTeeth = _context.PatientTeeth.Where(p =>
                    p.PatientRegisterationId == RegistrationID).ToList();
            var patientRegistrationCheck = _context.PatientRegisterationCheck.Where(p =>
                    p.PatientRegisterationId == RegistrationID).ToList();

            List<int?> historyElementId = new List<int?>();
            List<string> historyElementName = new List<string>();

            List<int?> teethNumberID = new List<int?>();
            List<int?> teethNumber = new List<int?>();
            List<string> note = new List<string>();
            List<string> teethLeftOrRight = new List<string>();
            List<string> teethTopOrButtom = new List<string>();
            List<string> teethAduOrChd = new List<string>();

            List<int?> patientRegistrationCheckID = new List<int?>();
            List<decimal?> drugFeeTotal = new List<decimal?>();
            List<decimal?> otherFeeTotal = new List<decimal?>();
            List<DateTime?> patientRegistrationCheckDate = new List<DateTime?>();
            List<string> doctornote = new List<string>();

            List<int?> patientRegistrationPaymentID = new List<int?>();
            List<int?> patientRegistrationPaymentCheckID = new List<int?>();
            List<DateTime?> patientRegistrationPaymentDate = new List<DateTime?>();
            List<decimal?> paidAmount = new List<decimal?>();
            List<decimal?> drugFee = new List<decimal?>();
            List<decimal?> otherFees = new List<decimal?>();
            List<decimal?> CheckTotalPayment = new List<decimal?>();
                       
            foreach(var c in patientHistory)
            {
                historyElementId.Add(c.HistoryElementId);
                var historyElement = _context.HistoryElement.Where(p => p.HistoryElementId == c.HistoryElementId);
                historyElementName.Add(historyElement.First().Name);
            }

            foreach (var c in patientTeeth)
            {
                teethNumberID.Add(c.TeethNumberId);
                note.Add(c.Note);
                var historyElement = _context.TeethNumber.Where(p => p.TeethNumberId == c.TeethNumberId);
                teethNumber.Add(historyElement.First().Number);
                teethLeftOrRight.Add(historyElement.First().LeftOrRight);
                teethTopOrButtom.Add(historyElement.First().TopOrButtom);
                teethAduOrChd.Add(historyElement.First().AduOrChd);
            }

            foreach (var c in patientRegistrationCheck)
            {
                patientRegistrationCheckID.Add(c.PatientRegisterationCheckId);
                var patientRegistrationPayment = _context.PatientRegisterationPayment.Where(p => p.PatientRegisterationCheckId == c.PatientRegisterationCheckId).ToList();
                var patientRegistrationCheckDrug = _context.PatientRegisterationCheckDrug.Where(p => p.PatientRegisterationCheckId == c.PatientRegisterationCheckId).ToList();
                var patientCheckFee = _context.PatientCheckFee.Where(p => p.PatientRegisterationCheckId == c.PatientRegisterationCheckId).ToList();
                decimal? CheckTotal = 0; //for sum the total of payments for each check
                
                foreach (var d in patientRegistrationPayment)
                {
                    patientRegistrationPaymentID.Add(d.PatientRegisterationPaymentId);
                    patientRegistrationPaymentDate.Add(d.Date);
                    CheckTotal += d.Payed;
                    paidAmount.Add(d.Payed);
                    drugFee.Add(d.DrugTotal);
                    otherFees.Add(d.FeeTotal);
                    patientRegistrationPaymentCheckID.Add(d.PatientRegisterationCheckId);
                }

                CheckTotalPayment.Add(CheckTotal);
                decimal? drugTotal = 0;
                decimal? otherTotal = 0;

                foreach (var e in patientRegistrationCheckDrug)
                {
                    drugTotal += e.Price*e.Quantity;
                }

                foreach (var e in patientCheckFee)
                {
                    otherTotal += e.Fee;
                }

                drugFeeTotal.Add(drugTotal);
                otherFeeTotal.Add(otherTotal);
                patientRegistrationCheckDate.Add(c.CheckDate);
                doctornote.Add(c.Note);
                note.Add(c.Note);
            }

            PatientRegistrationViewModel prvm = new PatientRegistrationViewModel
            {
                patientID=patient.First().PatientId,
                patientName = patient.First().Name,
                doctorID=doctor.First().DoctorId,
                doctorName = doctor.First().Name,
                doctorLastName = doctor.First().LastName,
                registrationFee = patientRegistration.First().RgisterationFee,
                PatientAge=patientRegistration.First().Age,
                registerDate=patientRegistration.First().Date,
                historyElementID = historyElementId,
                historyElementName = historyElementName,
                teethNumberId = teethNumberID,
                teethNumber = teethNumber,
                note = note,
                teethLeftOrRight = teethLeftOrRight,
                teethTopOrButtom = teethTopOrButtom,
                teethAduOrChd = teethAduOrChd,
                patientRegistrationCheckID = patientRegistrationCheckID,
                drugFeeTotal = drugFeeTotal,
                otherFeesTotal = otherFeeTotal,
                patientRegistrationCheckDate = patientRegistrationCheckDate,
                patientRegistrationPaymentID = patientRegistrationPaymentID,
                patientRegistrationPaymentDate= patientRegistrationPaymentDate,
                doctornotelist = doctornote,
                paidAmount=paidAmount,
                drugFee=drugFee,
                otherFees=otherFees,
                patientRegistrationPaymentCheckID= patientRegistrationPaymentCheckID,
                CheckTotalPayment= CheckTotalPayment
            };

            return new JsonResult(prvm);
        }

        public IActionResult searchByCheck(int CheckID)
        {
            var patientRegistrationCheck = _context.PatientRegisterationCheck.Where(p => p.PatientRegisterationCheckId == CheckID);
            var patientRegistrationPayment = _context.PatientRegisterationPayment.Where(p => p.PatientRegisterationCheckId == CheckID).ToList();
            var patientRegistrationCheckDrug = _context.PatientRegisterationCheckDrug.Where(p => p.PatientRegisterationCheckId == CheckID).ToList();
            var patientCheckFee = _context.PatientCheckFee.Where(p => p.PatientRegisterationCheckId == CheckID).ToList();

            List<int?> drugID = new List<int?>();
            List<string> drugName = new List<string>();
            List<int?> quantity = new List<int?>();
            List<decimal?> drugBasePrice = new List<decimal?>();
            List<decimal?> drugTotalPrice = new List<decimal?>();
            List<int?> feeId = new List<int?>();
            List<string> feeName = new List<string>();
            List<decimal?> feeBasePrice = new List<decimal?>();
            List<decimal?> feeTotalPrice = new List<decimal?>();

            List<int?> patientRegistrationPaymentID = new List<int?>();
            List<int?> patientRegistrationPaymentCheckID = new List<int?>();
            List<DateTime?> patientRegistrationPaymentDate = new List<DateTime?>();
            List<decimal?> paidAmount = new List<decimal?>();
            List<decimal?> drugFee = new List<decimal?>();
            List<decimal?> otherFees = new List<decimal?>();
                       
            foreach(var d in patientRegistrationCheckDrug)
            {
                var drugElement = _context.DrugElement.Where(p => p.DrugElementId == d.DrugElementId);
                drugName.Add(drugElement.First().Name);
                drugID.Add(d.DrugElementId);
                drugBasePrice.Add(drugElement.First().Price);
                drugTotalPrice.Add(d.Price);
                quantity.Add(d.Quantity);
            }

            foreach(var f in patientCheckFee)
            {
                var feeElement = _context.FeeElement.Where(p => p.FeeElementId == f.FeeElementId);

                feeId.Add(f.FeeElementId);
                feeName.Add(feeElement.First().Name);
                feeBasePrice.Add(feeElement.First().Fee);
                feeTotalPrice.Add(f.Fee);
            }

            foreach (var d in patientRegistrationPayment)
            {
                patientRegistrationPaymentID.Add(d.PatientRegisterationPaymentId);
                patientRegistrationPaymentDate.Add(d.Date);
                paidAmount.Add(d.Payed);
                drugFee.Add(d.DrugTotal);
                otherFees.Add(d.FeeTotal);
                patientRegistrationPaymentCheckID.Add(d.PatientRegisterationCheckId);
            }

            PatientRegistrationViewModel prvm = new PatientRegistrationViewModel
            {
                patientRegistrationPaymentID = patientRegistrationPaymentID,
                patientRegistrationPaymentDate = patientRegistrationPaymentDate,
                paidAmount = paidAmount,
                drugFee = drugFee,
                otherFees = otherFees,
                patientRegistrationPaymentCheckID = patientRegistrationPaymentCheckID,
                patientCheckDate = patientRegistrationCheck.First().CheckDate,
                doctornote = patientRegistrationCheck.First().Note,
                studentid = patientRegistrationCheck.First().StudentId,
                studentname = _context.Student.Where(p => p.StudentId == patientRegistrationCheck.First().StudentId).First().Name,
                drugID = drugID,
                drugName = drugName,
                quantity = quantity,
                drugBasePrice = drugBasePrice,
                drugTotalPrice = drugTotalPrice,
                feeId = feeId,
                feeName = feeName,
                feeBasePrice = feeBasePrice,
                feeTotalPrice = feeTotalPrice
            };

            return new JsonResult(prvm);
        }

        public IActionResult searchByPayment(int PaymentID)
        {
            var patientRegistrationPayment = _context.PatientRegisterationPayment.Where(p => p.PatientRegisterationPaymentId == PaymentID);


            PatientRegistrationViewModel prvm = new PatientRegistrationViewModel
            {
                paymentID = patientRegistrationPayment.First().PatientRegisterationPaymentId,
                paymentDrugFee= patientRegistrationPayment.First().DrugTotal,
                paymentOtherFee= patientRegistrationPayment.First().FeeTotal,
                paymentDate= patientRegistrationPayment.First().Date,
                paymentPaidAmount= patientRegistrationPayment.First().Payed,
                paymentDescription= patientRegistrationPayment.First().Description
            };

            return new JsonResult(prvm);
        }


        [HttpPost]
        public IActionResult Registration(int prgid, DateTime Rdate, int did, int pid,int age, int[] sickness, int[] teeth, string[] note)
        {
            decimal? fee = 0;
            var prid=0;
            if (ModelState.IsValid)
            {
                if (prgid == 0)
                {
                    fee = _context.FeeElement.Find(1).Fee;

                    if (_context.PatientRegisteration.Count() == 0)
                        prid = 1;
                    else
                        prid = _context.PatientRegisteration.Max(p => p.PatientRegisterationId) + 1;

                    foreach (int i in sickness)
                    {
                        PatientHistory patientHistory = new PatientHistory
                        {
                            PatientRegisterationId = prid,
                            HistoryElementId = i
                        };

                        _context.PatientHistory.Add(patientHistory);
                    }

                    for (int i = 0; i < teeth.Length; i++)
                    {
                        PatientTeeth patientTeeth = new PatientTeeth
                        {
                            PatientRegisterationId = prid,
                            TeethNumberId = teeth[i],
                            Note = note[i]
                        };

                        _context.PatientTeeth.Add(patientTeeth);
                    }

                    PatientRegisteration patientRegisteration = new PatientRegisteration
                    {
                        PatientRegisterationId = prid,
                        Date = Rdate,
                        PatientId = pid,
                        DoctorId = did,
                        RgisterationFee = fee,
                        Age = age

                    };
                    _context.PatientRegisteration.Add(patientRegisteration);

                    _context.SaveChanges();

                }
                else
                {
                    var phid = _context.PatientHistory.Where(p => p.PatientRegisterationId == prgid);
                    foreach (var a in phid)
                    {
                        var ph = _context.PatientHistory.Find(a.PatientHistoryId);
                        if (ph != null)
                            _context.PatientHistory.Remove(ph);
                    }

                    foreach (int i in sickness)
                    {
                        PatientHistory patientHistory = new PatientHistory
                        {
                            PatientRegisterationId = prgid,
                            HistoryElementId = i
                        };

                        _context.PatientHistory.Add(patientHistory);
                    }

                    var ptid = _context.PatientTeeth.Where(p => p.PatientRegisterationId == prgid);
                    foreach (var a in ptid)
                    {
                        var pt = _context.PatientTeeth.Find(a.PatientTeethId);
                        if (pt != null)
                            _context.PatientTeeth.Remove(pt);
                    }

                    for (int i = 0; i < teeth.Length; i++)
                    {
                        PatientTeeth patientTeeth = new PatientTeeth
                        {
                            PatientRegisterationId = prgid,
                            TeethNumberId = teeth[i],
                            Note = note[i]
                        };

                        _context.PatientTeeth.Add(patientTeeth);
                    }

                    var pr = _context.PatientRegisteration.Find(prgid);
                    pr.Date = Rdate;
                    pr.PatientId = pid;
                    pr.DoctorId = did;
                    pr.Age = age;
                    _context.PatientRegisteration.Update(pr);

                    _context.SaveChanges();
                }
            }
            decimal?[] IDS = { prid, pid, fee };
            return Json(IDS);
        }

        [HttpPost]
        public IActionResult Check(int prgcid,int pid, int prid,DateTime checkDate,int[] drugID, int[] drugQuantity, decimal[] drugPrice, int[] feeID, decimal[] price, string DoctorNote, int StudentId)
        {
            var max = _context.PatientRegisteration.Where(p => p.PatientId == pid).Max(p => p.PatientRegisterationId);
            var prcid = 0;
            if (ModelState.IsValid)
            {
                if (prgcid == 0)
                {
                    if (prid == max)
                    {
                        if (_context.PatientRegisterationCheck.Count() == 0)
                            prcid = 1;
                        else
                            prcid = _context.PatientRegisterationCheck.Max(p => p.PatientRegisterationCheckId) + 1;

                        for (int i = 0; i < drugID.Length; i++)
                        {
                            PatientRegisterationCheckDrug prcd = new PatientRegisterationCheckDrug
                            {
                                PatientRegisterationCheckId = prcid,
                                DrugElementId = drugID[i],
                                Quantity = drugQuantity[i],
                                Price = drugPrice[i]
                            };

                            _context.PatientRegisterationCheckDrug.Add(prcd);
                        }

                        for (int i = 0; i < feeID.Length; i++)
                        {
                            PatientCheckFee pcf = new PatientCheckFee
                            {
                                PatientRegisterationCheckId = prcid,
                                FeeElementId = feeID[i],
                                Fee = price[i]
                            };

                            _context.PatientCheckFee.Add(pcf);
                        }

                        PatientRegisterationCheck patientRegisterationCheck = new PatientRegisterationCheck
                        {
                            PatientRegisterationCheckId = prcid,
                            CheckDate = checkDate,
                            Note = DoctorNote,
                            StudentId= StudentId,
                            PatientRegisterationId = prid
                        };
                        _context.PatientRegisterationCheck.Add(patientRegisterationCheck);
                        _context.SaveChanges();
                    }
                }
                else
                {
                    prcid = prgcid;
                    var prgcd = _context.PatientRegisterationCheckDrug.Where(p => p.PatientRegisterationCheckId == prgcid);
                    foreach(var a in prgcd)
                    {
                        var pd = _context.PatientRegisterationCheckDrug.Find(a.PatientRegisterationCheckDrugId);
                        if (pd != null)
                            _context.PatientRegisterationCheckDrug.Remove(pd);
                    }

                    for (int i = 0; i < drugID.Length; i++)
                    {
                        PatientRegisterationCheckDrug prcd = new PatientRegisterationCheckDrug
                        {
                            PatientRegisterationCheckId = prgcid,
                            DrugElementId = drugID[i],
                            Quantity = drugQuantity[i],
                            Price = drugPrice[i]
                        };

                        _context.PatientRegisterationCheckDrug.Add(prcd);
                    }

                    var prgcf = _context.PatientCheckFee.Where(p => p.PatientRegisterationCheckId == prgcid);
                    foreach(var a in prgcf)
                    {
                        var pf = _context.PatientCheckFee.Find(a.PatientCheckFeeId);
                        if (pf != null)
                            _context.PatientCheckFee.Remove(pf);
                    }

                    for (int i = 0; i < feeID.Length; i++)
                    {
                        PatientCheckFee pcf = new PatientCheckFee
                        {
                            PatientRegisterationCheckId = prgcid,
                            FeeElementId = feeID[i],
                            Fee = price[i]
                        };

                        _context.PatientCheckFee.Add(pcf);
                    }
                                        
                    var prc = _context.PatientRegisterationCheck.Find(prgcid);
                    prc.CheckDate = checkDate;
                    prc.Note = DoctorNote;
                    prc.StudentId = StudentId;

                    _context.PatientRegisterationCheck.Update(prc);

                    _context.SaveChanges();
                }
            }

            return Json(prcid);
        }

        [HttpPost]
        public IActionResult Payment(int prgp,int prcid, decimal drugFee, decimal otherFee,DateTime paymentDate, decimal Recieved, string Description)
        {

            var prpid = 0;
            if (ModelState.IsValid)
            {
                if(prgp == 0){
                    if (_context.PatientRegisterationPayment.Count() == 0)
                        prpid = 1;
                    else
                        prpid = _context.PatientRegisterationPayment.Max(p => p.PatientRegisterationPaymentId) + 1;

                    PatientRegisterationPayment patientRegisterationPayment = new PatientRegisterationPayment
                    {
                        PatientRegisterationPaymentId = prpid,
                        PatientRegisterationCheckId = prcid,
                        Date = paymentDate,
                        DrugTotal = drugFee,
                        FeeTotal = otherFee,
                        Payed = Recieved,
                        Description=Description
                    };
                    _context.PatientRegisterationPayment.Add(patientRegisterationPayment);
                    _context.SaveChanges();
                }
                else
                {
                    var prp = _context.PatientRegisterationPayment.Find(prgp);
                    prp.Date = paymentDate;
                    prp.Payed = Recieved;
                    prp.Description = Description;
                    _context.PatientRegisterationPayment.Update(prp);
                    _context.SaveChanges();
                }
            }

            return Json(prpid);
        }



        int doctorID;
        int patientID;

        public JsonResult getDoctor(int did)
        {
            doctorID = did;
            return Json(doctorID);
        }

        public JsonResult getPatient(int pid)
        {
            patientID = pid;
            return Json(patientID);
        }

        public JsonResult AutoCompleteDoctorSelect(string term)
        {
            var doctor = (from item in _context.Doctor.Where(p => p.Name.Contains(term))
                          select new
                          { label = item.Name, id = item.DoctorId }).ToList();
            return Json(doctor);  
        }

        public IActionResult SearchHistoryElement(int pid)
        {
            var gender = _context.Patient.Find(pid).GenderId;
            var result= _context.HistoryElement.Where(p => p.ApplyToGender == gender).ToList();

            if (gender == 1)
            {
                result = _context.HistoryElement.Where(p => p.ApplyToGender == 1 || p.ApplyToGender == 3).ToList();
            }
            else
            {
                result = _context.HistoryElement.Where(p => p.ApplyToGender == 2 || p.ApplyToGender == 3).ToList();
            }

            return new JsonResult(result);
        }

        public JsonResult AutoCompleteSicknessSelect(string term,int pid)
        {
            var gender = _context.Patient.Find(pid).GenderId;

            var result= (from item in _context.HistoryElement.Where(p => p.Name.Contains(term) && p.ApplyToGender == gender)
                       select new
                       { label = item.Name, id = item.HistoryElementId }).ToList();
            if (gender == 1)
            {
                result = (from item in _context.HistoryElement.Where(p => p.Name.Contains(term) && p.ApplyToGender==1 || p.Name.Contains(term) && p.ApplyToGender == 3)
                            select new
                            { label = item.Name, id = item.HistoryElementId }).ToList();
            }
            else
            {
                result = (from item in _context.HistoryElement.Where(p => p.Name.Contains(term) && p.ApplyToGender == 2 || p.Name.Contains(term) && p.ApplyToGender == 3)
                            select new
                            { label = item.Name, id = item.HistoryElementId }).ToList();
            }
            return Json(result);
        }

        public JsonResult AutoCompleteTeethSelect(string term)
        {
            var teeth = (from item in _context.TeethNumber.Where(p => p.LeftOrRight.Contains(term))
                         select new
                         { number = item.Number, label = item.LeftOrRight, topOrButtom = item.TopOrButtom, aduOrChd = item.AduOrChd, id = item.TeethNumberId }).ToList();
            return Json(teeth);
        }

        public JsonResult AutoCompletePatientSelect(string term)
        {
            var patient = (from item in _context.Patient.Where(p => p.Name.Contains(term))
                          select new
                          { label = item.Name, id = item.PatientId, dob = item.DataOfBrith}).ToList();
            return Json(patient.Select(a => new { label = a.label + " ( " + a.id + " ) ", id = a.id, dob = a.dob }));
        }
        public JsonResult AutoCompleteStudentSelect(string term)
        {
            var patient = (from item in _context.Student.Where(p => p.Name.Contains(term))
                          select new
                          { label = item.Name, id = item.StudentId}).ToList();
            return Json(patient.Select(a => new { label = a.label + " ( " + a.id + " ) ",id=a.id}));
        }

        public JsonResult AutoCompletePatientSearch(string term)
        {
            //return Json(db.zSubjects.Where(c => c.SubjectName.StartsWith(term)).Select(a => new { label = "(" + a.SubjectCode + ")-" + a.SubjectName, id = a.SubjectID,SubjectCode=a.SubjectCode,SubjectName=a.SubjectName,TotalMarks=a.TotalMarks }), JsonRequestBehavior.AllowGet);
            var patient = (from item in _context.Patient.Where(p => p.Name.Contains(term))
                          select new
                          { label = item.Name, id = item.PatientId }).ToList();
            return Json(patient.Select(a => new { label = a.label + " ( " + a.id + " ) ", id = a.id }));
        }

        public JsonResult AutoCompleteDrugTypeSelect(string q)
        {
            var drugType = (from item in _context.DrugType select new
                            { label = item.Name, id = item.DrugTypeId }).ToList();

            if (!(string.IsNullOrEmpty(q) || string.IsNullOrWhiteSpace(q)))
            {
                drugType = (from item in _context.DrugType.Where(p => p.Name.Contains(q))
                            select new
                            { label = item.Name, id = item.DrugTypeId }).ToList();
            }

            return Json(drugType);
        }               

        public JsonResult AutoCompleteDrugSelect(string term,int DrugType)
        {
            var drug = (from item in _context.DrugElement.Where(p => p.Name.Contains(term) && p.DrugTypeId== DrugType)
                          select new
                          { label = item.Name, id = item.DrugElementId, price=item.Price, company= _context.Company.Where(p => p.CompanyId == item.CompanyId).First().Name }).ToList();
            
            return Json(drug.Select(a => new { label = a.label + " ( " + a.company + " ) ", id = a.id, price =a.price} ));
        }

        public JsonResult AutoCompleteFeeTypeSelect(string q)
        {
            var drug = (from item in _context.FeeType
                        select new
                        { label = item.Name, id = item.FeeTypeId}).ToList();

            if (!(string.IsNullOrEmpty(q) || string.IsNullOrWhiteSpace(q)))
            {
                drug = (from item in _context.FeeType.Where(p => p.Name.Contains(q))
                        select new
                        { label = item.Name, id = item.FeeTypeId }).ToList();
            }

            return Json(drug);
        }

        public JsonResult AutoCompleteFeeElementSelect(string term, int ftID)
        {
            var drug = (from item in _context.FeeElement.Where(p => p.Name.Contains(term) && p.FeeTypeId==ftID)
                        select new
                        { label = item.Name, id = item.FeeElementId, fee = item.Fee }).ToList();
            return Json(drug);
        }

        
        [HttpPost]
        public async Task<IActionResult> AddOrEdit(PatientRegistrationViewModel patientRegisterationViewModel, int id = 0)
        {
            if (ModelState.IsValid)
            {

                if (id == 0)
                {

                    PatientRegisteration patientRegisteration = new PatientRegisteration
                    {
                        PatientId = patientRegisterationViewModel.patientID,
                        DoctorId = patientRegisterationViewModel.doctorID,
                        RgisterationFee = patientRegisterationViewModel.registrationFee

                    };

                    _context.Add(patientRegisteration);
                }
                else
                {
                    PatientRegisteration patientRegisteration = new PatientRegisteration
                    {
                        PatientId = patientRegisterationViewModel.patientID,
                        DoctorId = patientRegisterationViewModel.doctorID,
                        RgisterationFee = patientRegisterationViewModel.registrationFee
                    };
                    _context.Update(patientRegisteration);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(patientRegisterationViewModel);
        }

        public IActionResult DeleteRegistration(int RegistrationID)
        {
            var pid = _context.PatientRegisteration.Find(RegistrationID).PatientId;
            var patientRegisteration = _context.PatientRegisteration.Find(RegistrationID);
            _context.PatientRegisteration.Remove(patientRegisteration);
            _context.SaveChanges();

            return Json(pid);
        }

        public IActionResult DeleteCheck(int CheckID)
        {
            var prid = _context.PatientRegisterationCheck.
                Where(p=>p.PatientRegisterationCheckId==CheckID).First().PatientRegisterationId;
            var check = _context.PatientRegisterationCheck.Find(CheckID);
            _context.PatientRegisterationCheck.Remove(check);
            _context.SaveChanges();
            return Json(prid);
        }

        public IActionResult DeletePayment(int PaymentID)
        {
            var pyid = _context.PatientRegisterationPayment.
                Where(p => p.PatientRegisterationPaymentId == PaymentID).First().PatientRegisterationPaymentId;
            var payment = _context.PatientRegisterationPayment.Find(PaymentID);
            _context.PatientRegisterationPayment.Remove(payment);
            _context.SaveChanges();
            return Json(pyid);
        }
    }
}
