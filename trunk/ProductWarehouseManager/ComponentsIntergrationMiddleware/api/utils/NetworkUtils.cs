using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.utils
{
    sealed class NetworkUtils
    {
        private NetworkUtils() { }

        public static String getIPAddress() {

            IPHostEntry SystemAC = Dns.GetHostEntry(Dns.GetHostName());
            string IPAddress = string.Empty;
            foreach (var address in SystemAC.AddressList)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    IPAddress = address.ToString();
                    
                }
                
            }
            return IPAddress;
        }        
    }
}
