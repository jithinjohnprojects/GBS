using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GBS.Models
{
    [MetadataType(typeof(CategoryColorModel))]
    public partial class Category_Color
    {

    }
    public class CategoryColorModel
    {
        public int color_id { get; set; }
        [Required]
        public string color_cod { get; set; }
        [Required]
        public string color_name { get; set; }
        public int active { get; set; }
        public int rec_status { get; set; }
    }
}