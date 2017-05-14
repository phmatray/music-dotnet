using System.Threading.Tasks;

namespace OpenJam.Startup.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
