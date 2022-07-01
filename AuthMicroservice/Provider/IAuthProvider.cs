using AuthMicroservice.Models;

namespace AuthMicroservice.Provider
{
    public interface IAuthProvider
    {
        public List<Auth> GetList();

        public Auth GetRFQ(Auth cred);
    }
}
