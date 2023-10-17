using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Collections.ObjectModel;
using ECommerce_MVC.Areas.Identity.Data;

namespace ECommerce_MVC.Models
{
    public class Report
    {

        public  int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public  bool   IsSolved { get; set; }

        [ReadOnly(true)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public  DateTime CreateDatet { get; set; }
        public DateTime SolvedDatat { get; set; }



        //nav

        [ForeignKey(nameof(Review))]
        public int ReviewId { get; set; }
        public virtual Review? Review { get; set; }



        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser? ApplicationUser { get; set; }
    }
}
