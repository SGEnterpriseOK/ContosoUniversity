using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, MinimumLength =2)]
        [Column("FirstMidName")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        public ICollection<Enrollment> Enrollments { get; set; }

    }
}

//The Required attribute
//The Required attribute makes the name properties required fields. The Required attribute isn't needed for non-nullable types such as value types (DateTime, int, double, float, etc.). Types that can't be null are automatically treated as required fields.

//The Required attribute must be used with MinimumLength for the MinimumLength to be enforced.

//C#

//Copy
//[Display(Name = "Last Name")]
//[Required]
//[StringLength(50, MinimumLength = 2)]
//public string LastName { get; set; }
//The Display attribute
//The Display attribute specifies that the caption for the text boxes should be "First Name", "Last Name", "Full Name", and "Enrollment Date" instead of the property name in each instance (which has no space dividing the words).

//The FullName calculated property
//FullName is a calculated property that returns a value that's created by concatenating two other properties. Therefore it has only a get accessor, and no FullName column will be generated in the database.
