using Portfolio.Models;
namespace Portfolio.Services.Infrastructures
{
    public interface IProject
    {
        IEnumerable<Project> GetProjects();
        Project GetProject(int id);
        
        void Insert(Project project);
        void Update(Project project);
        void Delete(int id);
        int Count();
        void Save();
    }
}
