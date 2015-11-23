using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;

namespace FutBud.Services
{
    internal static class CookieUtil
    {
        public static void WriteCookiesToDisk(string file, CookieContainer c)
        {
            CookieContainer ccnew = new CookieContainer();

            //get the auth cookie "_nx_mpcid" from the cookiecontainer
            var authCookie = c.GetCookies(new Uri("http://ea.com"));
            foreach (Cookie cookie in authCookie)
            {
                if (cookie.Name.Equals("_nx_mpcid"))
                    ccnew.Add(cookie);
            }

            //save the cookiecontainer with the the auth cookie "_nx_mpcid"
            using (Stream stream = File.Create(file))
            {
                try
                {
                    WriteLog.DoWrite("Writing cookies to disk... ");
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, ccnew);
                    WriteLog.DoWrite("Done.");
                }
                catch (Exception e)
                {
                    WriteLog.DoWrite("Problem writing cookies to disk: " + e.GetType());
                }
            }
        }

        public static CookieContainer ReadCookiesFromDisk(string file)
        {

            try
            {
                using (Stream stream = File.Open(file, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (CookieContainer) formatter.Deserialize(stream);
                }
            }
            catch (Exception e)
            {
                WriteLog.DoWrite("Problem reading cookies from disk: " + e.GetType());
                return new CookieContainer();
            }

        }
    }
}
