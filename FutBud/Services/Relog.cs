using System.IO;
using FutBud.Exceptions;
using UltimateTeam.Toolkit;
using UltimateTeam.Toolkit.Models;

namespace FutBud.Services
{
    //TODO
    class Relog
    {
        private string _user, _password, _sAnswer;
        private Platform _platform;
        private FutClient _client;
        public FutClient DoRelog()
        {
            if (Properties.Settings.Default.Safelogin)
            {
                _user = Encryption.Decrypt(Properties.Settings.Default.EAUser);
                _password = Encryption.Decrypt(Properties.Settings.Default.EAPW);
                _sAnswer = Encryption.Decrypt(Properties.Settings.Default.EAAnswer);
                switch (Properties.Settings.Default.platform)
                    {
                        case 0:
                            _platform = Platform.Pc;
                            break;
                        case 1:
                            _platform = Platform.Ps3;
                            break;
                        case 2:
                            _platform = Platform.Ps4;
                            break;
                        case 3:
                            _platform = Platform.Xbox360;
                            break;
                        case 4:
                            _platform = Platform.XboxOne;
                            break;
                    }
            }
            else
            {
                throw new LoginNotSafedException();
            }
            if(!File.Exists("cookie.dat"))
                throw new CookieNotFoundException();
            
            _client = new FutClient(CookieUtil.ReadCookiesFromDisk("cookie.dat"));
            var loginDetails = new LoginDetails(_user, _password, _sAnswer, _platform);
            Relogasyc(loginDetails);
            return _client;
        }

        private async void Relogasyc(LoginDetails loginDetails)
        {
            await _client.LoginAsync(loginDetails, null);
        }

    }
}
