using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.ClasseTest
{
    public class EnvironementMeFake : IEnvironementMe
    {
        public String getUserNamle()
        {
            return "Babar";
        }
    }
}
