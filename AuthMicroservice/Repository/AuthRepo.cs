using AuthMicroservice.Models;
using AuthMicroservice.Provider;

namespace AuthMicroservice.Repository
{
    public class AuthRepo : IAuthRepo
    {
         private IAuthProvider provider;

            public AuthRepo(IAuthProvider _provider)
            {
                provider = _provider;
            }
            public Auth GetRFQCred(Auth cred)
            {
                if (cred == null)
                {
                    return null;
                }

                Auth rfq = provider.GetRFQ(cred);

                return rfq;
            }
        }
    }

