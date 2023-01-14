using Portfolio.Models;
namespace Portfolio.Services.Infrastructures
{
    public interface IMessage
    {
        IEnumerable<Message> GetMessages();
        Message GetMessage(int id);
        void Insert(Message message);
        void Update(Message message);
        void Delete(int id);
        int Count();
        void Save();
    }
}
