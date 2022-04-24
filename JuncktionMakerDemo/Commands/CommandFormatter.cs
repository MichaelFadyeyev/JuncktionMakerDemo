using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuncktionMakerDemo.Commands
{
    internal class CommandFormatter
    {
        string[] commands = new string[] 
        {
            "mklink /j",
            "mklink /h",
            "mklink /d",
            "mklink"
        };

        internal string Junction => commands[0];
        internal string Hard => commands[1];
        internal string SymbolicDirectory => commands[2];
        internal string Symbolic => commands[3];
    }
}
