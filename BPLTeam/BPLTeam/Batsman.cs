using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPLTeam
{
    internal class Batsman:Player
    {

        private int totalRuns;
        double battingAvg;
        int highestScore;

        public int TotalRun {  get { return totalRuns; } set { totalRuns = value; } }  
        public double BattingAvg { get { return battingAvg; } set { battingAvg = value; } }
        public int HighestScore { get { return highestScore; } set { highestScore = value; } }

        public Batsman() { }

        public Batsman(int playerID, string name, string teamName, int totalRuns, double battingAvg, int highestScore) : base(playerID, name, teamName)
        {
            this.totalRuns = totalRuns;
            this.battingAvg = battingAvg;
            this.highestScore = highestScore;
        }

        public override void ShowInfo()
        {

            base.ShowInfo();

            Console.WriteLine("Total Runs: "+this.TotalRun);
            Console.WriteLine("Batting Average: "+this.battingAvg);
            Console.WriteLine("Highest Score: "+highestScore);
            PlayerPerformance();

        }

        public override void PlayerPerformance()
        {
            base.PlayerPerformance();
            if(battingAvg>50) Console.WriteLine("Elligible for Award.");
        }


    }
}
