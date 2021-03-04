using System.Threading.Tasks;
using Domain.Models.User;

namespace Application.Interfaces
{
    public interface IJwtGenerator
    {

        string CreateToken(AppUser user);

      

    }
}