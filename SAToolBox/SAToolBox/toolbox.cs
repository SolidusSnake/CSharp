using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SAToolBox
{
    class toolbox
    {
        #region SystemInfo

        public static void ReturnSystemInfo()
        {
            GetHostname();
            GetDomain();
            GetUptime();
            Console.Write("NIC Info: \n\n");
            GetIP();
            Console.WriteLine("Press Enter...");
        }

        public static void GetHostname()
        {
            Console.WriteLine("Computer Name: " + System.Environment.GetEnvironmentVariable("COMPUTERNAME"));
        }

        public static void GetDomain()
        {
            Console.WriteLine("Domain Name: " + System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName);
        }

        public static void GetUptime()
        {
            PerformanceCounter upTime = new PerformanceCounter("System", "System Up Time");
            upTime.NextValue();
            TimeSpan ts = TimeSpan.FromSeconds(upTime.NextValue());
            Console.WriteLine("System Uptime: {0}d {1}h {2}m {3}s", ts.Days, ts.Hours, ts.Minutes, ts.Seconds);
        }

        public static void GetIP()
        {
            /*
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            Console.WriteLine("\t" + ni.Name.ToString());
                            Console.WriteLine("\t" + ip.Address.ToString());
                            Console.WriteLine("\t" + ip.IPv4Mask.ToString());
                            Console.WriteLine("\tSTATUS: " + ni.OperationalStatus.ToString().ToUpper() + "\n");                        }
                    }
                }
            }*/

            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                GatewayIPAddressInformationCollection addresses = adapterProperties.GatewayAddresses;
                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    foreach (UnicastIPAddressInformation ip in adapter.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            Console.WriteLine("\t" + adapter.Name.ToString());
                            Console.WriteLine("\t" + ip.Address.ToString());
                            Console.WriteLine("\t" + ip.IPv4Mask.ToString());
                            Console.WriteLine("\t" + addresses.ToString());
                            Console.WriteLine("\tSTATUS: " + adapter.OperationalStatus.ToString().ToUpper() + "\n");
                        }
                    }
                }
            }
        }
        #endregion SystemInfo

        #region Networking

        public static void PingGateway()
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        var ipProp = ni.GetIPProperties();
                        var gwAddresses = ipProp.GatewayAddresses;
                        if (gwAddresses.Count > 0)
                        {
                            Console.WriteLine(gwAddresses);
                        }
                    }

                }
            }
        }

        public static void PortQuery()
        {
            TcpClient tClient = new TcpClient();
            UdpClient uClient = new UdpClient();

            Console.Write("\nIP: ");
            var server = IPAddress.Parse(Console.ReadLine());

            Console.Write("PORT: ");
            var port = int.Parse(Console.ReadLine());
            try
            {
                tClient.Connect(server, port);
                if (tClient.Connected == true)
                {
                    Console.WriteLine("\nTCP PORT OPEN");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\nTCP PORT CLOSED");
            }
            /*
            try
            {
                uClient.Connect(server, port);
                Console.WriteLine("\nUDP PORT OPEN");
            }
            catch (Exception)
            {
                Console.WriteLine("UDP PORT CLOSED");
            }
            */
        }
        #endregion Networking
    }
}
// test commit
