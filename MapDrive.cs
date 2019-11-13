using System.Diagnostics;

namespace MapDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.Start("net.exe", @"use H: ""\\10.10.10.1\SHARE"" /user:domain\first.last P@ssw0rd").WaitforExit();
        }
    }
}