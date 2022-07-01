using AuthMicroservice.Models;

namespace AuthMicroservice.Provider
{
    public class PensionProvider : IAuthProvider
    {
        private static List<Auth> List = new List<Auth>()
        {
            new Auth{ Username = "user1", Password = "user1"},
            new Auth{ Username = "user2", Password = "user2"}
        };
        public List<Auth> GetList()
        {
            return List;
        }

        public Auth GetRFQ(Auth cred)
        {
            List<Auth> rList = GetList();
            Auth penCred = rList.FirstOrDefault(user => user.Username == cred.Username && user.Password == cred.Password);

            return penCred;
        }
    }
}
