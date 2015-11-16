using System.ServiceModel;
using FutBud.WCF_Stuff;

namespace FutBud.Services
{
    internal static class VersionCheck
    {
        public static string Check(string version)
        {
            using (var client = new MyServiceClient(new BasicHttpBinding(),new EndpointAddress("http://87.106.9.183:23651")))
            {
                var response = client.Execute();
                if (response.Equals(version))
                {
                    return "ok";
                }
                //else
                return response;
            }
        }
    }
}
