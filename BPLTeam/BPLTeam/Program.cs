using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPLTeam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Player player = new Batsman(1,"Mahir","CW",1200,51.53,112);
            player.ShowInfo();
        }
    }
}
