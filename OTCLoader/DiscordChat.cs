using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace OTCLoader
{
    class DiscordChat
    {
        internal static byte[] Post(string uri, NameValueCollection pairs)
        {
            using (WebClient msgSender = new WebClient())
            {
                try
                {
                    return msgSender.UploadValues(uri, pairs);
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}
