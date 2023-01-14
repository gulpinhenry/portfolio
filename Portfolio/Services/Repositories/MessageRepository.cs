using Portfolio.Data;
using Portfolio.Models;
using Portfolio.Services.Infrastructures;
using System.Net.Sockets;

namespace Portfolio.Services.Repositories
{
    public class MessageRepository : IMessage
    {
        private ApplicationDbContext _context;

        public MessageRepository(ApplicationDbContext context) { _context = context; }
        public int Count()
        {
            return _context.Messages.Count();
        }

        public void Delete(int id)
        {
            var message = _context.Messages.FirstOrDefault(m => m.Id == id);
            if (message != null)
            {
                _context.Messages.Remove(message);
            }
        }

        public Message GetMessage(int id)
        {
            var message = _context.Messages.FirstOrDefault(_m => _m.Id == id);
            return message != null ? message : null;
        }

        public IEnumerable<Message> GetMessages()
        {
            return _context.Messages;
        }

        public void Insert(Message message)
        {
            _context.Messages.Add(message);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Message message)
        {
            _context.Messages.Update(message);
        }
    }
}
