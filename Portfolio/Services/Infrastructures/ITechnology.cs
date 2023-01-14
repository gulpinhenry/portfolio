using Portfolio.Models;
namespace Portfolio.Services.Infrastructures
{
    public interface ITechnology
    {
        IEnumerable<Technology> GetTechnologies();
        Technology GetTechnology(int id);
        // IEnumerable<Project> GetProjectsWithParticularTechnology();
        
        void Insert(Technology technology);
        void Update(Technology technology);
        void Delete(int id);
        int Count();
        void Save();
    }
}
