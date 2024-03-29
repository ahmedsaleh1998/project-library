namespace lib_manage_project.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.Books = new HashSet<Book>();
        }
    
        public int Client_Id { get; set; }

        [Required(ErrorMessage = "*Required")]
        [RegularExpression(".{1,50}")]
        public string Client_Name { get; set; }

        [Required(ErrorMessage = "*Required")]
        [RegularExpression(".{6,20}")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "*Required")]
        [RegularExpression(".{8,50}")]
        [Phone]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "*Required")]
        [RegularExpression(".{10,50}")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "*Required")]
        [RegularExpression("[0-9]{10,50}")]
        public string National_Id { get; set; }

        [Required(ErrorMessage = "*Required")]
        [DataType(DataType.Date)]
        [NotInFuture]
        public System.DateTime DateOfBirth { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book> Books { get; set; }
    }
}
