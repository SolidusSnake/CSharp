﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;

namespace SAToolBox
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;

            while (!done)
            {
                Console.Clear();
                Console.WriteLine("MAIN MENU\n");
                Console.WriteLine("[0]\tSYSTEM INFO");
                Console.WriteLine("[1]\tNETWORKING");
                Console.WriteLine("[2]\tMEMORY");
                Console.WriteLine("[3]\tCPU");
                Console.WriteLine("[4]\tDISK");
                Console.WriteLine("[5]\tEVENT LOG");
                Console.WriteLine("[6]\tUPDATES");
                Console.WriteLine("[7]\tMCAFEE");
                Console.WriteLine("[8]\tPASSWORD GENERATOR");
                Console.WriteLine("[99]\tEXIT\n");

                Console.Write("Make a selection:  ");

                try
                {
                    var menuSel = int.Parse(Console.ReadLine());

                    switch (menuSel)
                    {
                        case 0:
                            Console.Clear();
                            Console.WriteLine("SYSTEM INFO\n");
                            toolbox.ReturnSystemInfo();
                            Console.ReadLine();
                            break;

                        case 1:

                            bool netDone = false;

                            while (!netDone)
                            {
                                Console.Clear();
                                Console.WriteLine("NETWORKING\n");
                                Console.WriteLine("[0]\tPING GATEWAY");
                                Console.WriteLine("[1]\tPORT QUERY");
                                Console.WriteLine("[99]\tEXIT\n");

                                Console.Write("Make a selection:  ");
                                try
                                {
                                    var netSel = int.Parse(Console.ReadLine());

                                    switch (netSel)
                                    {
                                        case 0:
                                            toolbox.PingGateway();
                                            break;

                                        case 1:
                                            toolbox.PortQuery();
                                            Console.WriteLine("\nPress Enter...");
                                            Console.ReadLine();
                                            break;

                                        case 99:
                                            netDone = true; break;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("\n" + ex.Message.ToUpper());
                                    Thread.Sleep(3000);
                                }
                            }

                            break;

                        case 2:
                            Console.WriteLine("MEMORY\n");
                            break;

                        case 3:
                            Console.WriteLine("CPU\n");
                            break;

                        case 4:
                            Console.WriteLine("DISK\n");
                            break;

                        case 5:
                            Console.WriteLine("EVENT LOG\n");
                            break;

                        case 6:
                            Console.WriteLine("UPDATES\n");
                            break;

                        case 7:
                            Console.WriteLine("MCAFEE\n");
                            break;

                        case 8:
                            Console.WriteLine("PASSWORD GENERATOR\n");
                            break;

                        case 99:
                            Console.WriteLine("EXIT");
                            System.Environment.Exit(0);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message.ToUpper());
                    Thread.Sleep(3000);
                }
            }
        }
    }
}
