using Business.Models;

namespace Business.Interfaces;
public interface ITokenService
{
    string CreateToken(AppUser user);
}