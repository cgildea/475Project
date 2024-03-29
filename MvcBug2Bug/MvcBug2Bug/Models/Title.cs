//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcBug2Bug.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Title
    {
        public Title()
        {
            this.Authors = new HashSet<Author>();
        }

        [Required]
        public string ISBN { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title1 { get; set; }

        [Required]
        [Display(Name = "Edition Number")]
        public int EditionNumber { get; set; }

        [Required]
        public string Copyright { get; set; }

        [Required]
        public int Price { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
    }
}
