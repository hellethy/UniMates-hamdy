namespace UniMates.Models
{
    public class User : BaseEntity
    {

        public string ?FirstName { get; set; }
        public string ?LastName { get; set; }
        public string ?Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public Guid? CountryId { get; set; }
        public Guid? CityId { get; set; }
        public string? State { get; set; }
        public string? Gender { get; set; }
        public Guid? UniversityId { get; set; }
        public Guid? FacultyId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? ProfilePictureUrl { get; set; }

        public string? Bio { get; set; }
        public int? ResetCode { get; set; }
       
        // Navigation properties
        public City? City { get; set; }
        public Country? Country { get; set; }
        public University? University { get; set; }
        public Faculty? Faculty { get; set; }

        //Collection navigation property
        //virual to enable lazy loading
        public virtual ICollection<PaymentMethod>? PaymentMethods { get; set; }

        public virtual ICollection<UserLanguage>? UserLanguages { get; set; }
        public virtual ICollection<TutorSubject>? TutorSubjects { get; set; }
       
        public virtual ICollection<PaymentTransaction>? PaymentTransactionsAsStudent { get; set; }
      
        public virtual ICollection<Review>? ReviewsAsStudent { get; set; }
     
        public virtual ICollection<Complaint>? ComplaintsAsStudent { get; set; }
      
        public virtual ICollection<Session>? SessionsAsTutor { get; set; }
        public virtual ICollection<StudentSessions>? SessionStudents { get; set; }
        public virtual ICollection<UserAvailability>? Availabilities { get; set; }

    }
}
