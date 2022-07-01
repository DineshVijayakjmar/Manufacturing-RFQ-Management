using AuthMicroservice.Models;

namespace AuthMicroservice.Repository
{
    public interface IAuthRepo
    {
        public Auth GetRFQCred(Auth cred);
    }
}
