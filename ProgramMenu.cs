using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerConsoleApp
{
    internal class ProgramMenu
    {
        public void progMenu()
        {
            string[] pMenu = new string[] { "[1] Patterns", "[2] Calculator", "[3] Quiz Game", "[4] Convert Letter To Number", "[5] Convert Number To Letter" };
            foreach (string menu in pMenu)
            {
                Console.WriteLine(menu);
            }
        }

    }
}


