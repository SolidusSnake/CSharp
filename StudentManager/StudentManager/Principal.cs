using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager
{
    class Principal : Member, IPayee
    {
        public void Pay()
        {
            Console.WriteLine("paying principal");
        }
    }
}
