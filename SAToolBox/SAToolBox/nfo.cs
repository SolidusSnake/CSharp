using System;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace SAToolBox
{
    class nfo
    {
        public static void ReturnInfo()
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
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            Console.WriteLine("\t" + ni.Name.ToString());
                            Console.WriteLine("\t" + ip.Address.ToString() + "\n");
                        }
                    }
                }
            }
        }
    }
}
