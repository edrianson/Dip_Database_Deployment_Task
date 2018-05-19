namespace SwinnyLibraryAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [Key]
        [StringLength(13)]
        public string ISBN { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string title { get; set; }

        [Column(TypeName = "date")]
        public DateTime year { get; set; }

        [Required]
        [StringLength(8)]
        public string authorId { get; set; }

        [StringLength(8)]
        public string studentId { get; set; }

        public virtual Person Person { get; set; }

        public virtual Person Person1 { get; set; }
    }
}
