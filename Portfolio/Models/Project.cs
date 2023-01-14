namespace Portfolio.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string? Link { get; set; }
        public string? RepoLink { get; set; }

        public byte[] ProjectImagePath { get; set; }

        public virtual ICollection<Technology> Technologies { get; set; } = new HashSet<Technology>();
       
    }
}
