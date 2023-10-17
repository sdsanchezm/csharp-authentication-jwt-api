using AuthenticationAPI2.Entities;

namespace AuthenticationAPI2.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
