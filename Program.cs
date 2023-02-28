using System;
using System.Windows.Forms;

namespace ErrorPopupExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageBox.Show("The version of this file is not compatible with the version of Windows you're running. Check your computer's system information to see whether you need an x86 (32-bit) or x64 (64-bit) version of the program, and then contact the software publisher.", "%1", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}