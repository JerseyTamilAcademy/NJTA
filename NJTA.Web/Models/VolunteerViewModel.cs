namespace NJTA.Web.Models
{
    public class VolunteerModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string[] Roles { get; set; }
    }
    
    public class ClassInfo
    {
        public string Name { get; set; }
        public string Grade { get; set; }
        public string Section { get; set; }
        public string ClassRoom { get; set; }
        public VolunteerModel[] Teachers { get; set; }
    }
}