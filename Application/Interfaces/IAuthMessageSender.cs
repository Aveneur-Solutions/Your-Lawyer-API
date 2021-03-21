using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAuthMessageSender
    {
        Task SendSmsAsync(string number, string message);
    }
}