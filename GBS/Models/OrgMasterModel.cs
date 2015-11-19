using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GBS.Models
{
    [MetadataType(typeof(OrgMasterModel))]
   public partial class OrgMaster
    {

    }
    public class OrgMasterModel
    {
        public int OrgId { get; set; }
        [Required]
        public string OrgName { get; set; }
        [Required]
        public string RegAddress { get; set; }
        [Required]
        public string CorpAddress { get; set; }
        [Required]
        public System.DateTime Date { get; set; }
    }
}