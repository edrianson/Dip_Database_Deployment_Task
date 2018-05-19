namespace SwinnyLibraryAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            Books = new HashSet<Book>();
            Books1 = new HashSet<Book>();
        }

        [StringLength(8)]
        public string id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string firstName { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string lastName { get; set; }

        public int roleId { get; set; }

        [StringLength(10)]
        public string mobilePhone { get; set; }

        [StringLength(9)]
        public string TFN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book> Books { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book> Books1 { get; set; }

        public virtual Role Role { get; set; }
    }
}
