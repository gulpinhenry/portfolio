namespace Portfolio.Models
{
    public class Technology
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Proficiency { get; set; }
        public byte[]? TechnologyImagePath { get; set; }

        public virtual ICollection<Project> Projects { get; set; } = new HashSet<Project>();

    }
}