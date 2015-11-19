using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GBS.Models
{
    [MetadataType(typeof(EmployeeMasterModel))]
    public partial class EmpMaster
    {

    }
    public class EmployeeMasterModel
    {

        public int EmpID { get; set; }
        [Required]
        public string EmpNo { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SurName { get; set; }
        public string PassportName { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string BirthPlace { get; set; }
        [Required]
        public string Gender { get; set; }
        public string ContactPerson { get; set; }
        [Required]
        public string Nationality { get; set; }
        public string BloodGroup { get; set; }
        public string MaritialStatus { get; set; }
        public Nullable<int> Active { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> rec_status { get; set; }
    }
}