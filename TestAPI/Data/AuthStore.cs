using TestAPI.Models.Dto;

namespace TestAPI.Data
{
    public class AuthStore
    {
        public static List<AuthDTO> authList = new List<AuthDTO>
        {
         new AuthDTO{Id=1,Username="Anugrah", Password = "123"},
         new AuthDTO{Id=2,Username="Nunu", Password= "321"}
        };
    }
}