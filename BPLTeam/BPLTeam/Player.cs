using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BPLTeam
{
    internal class Player
    {
        protected int playerID;
        protected string name;
        protected string teamName;

        public int PlayerID { get { return playerID; } set { playerID = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string TeamName { get { return teamName; } set { teamName = value; } }

        public Player() { }

        public Player(int playerID, string name, string teamName) {
            this.playerID = playerID;
            this.name = name;
            this.teamName = teamName;

        }

        public virtual void ShowInfo() {
            Console.WriteLine("ID : " + this.playerID);
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Team Name: " + this.teamName);
            
        }

        public virtual void PlayerPerformance() {
            Console.WriteLine("Performance from base class.");
        }

    

    }
}
