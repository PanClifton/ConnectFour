using System.Collections.Generic;
using ConnectFour.Models;

namespace ConnectFour.WinLogic.Analyzer
{
    public class WinCasesAnalyzer
    {
        public Winner GetWinner(List<WinCase> winCases)
        {
            foreach (var winCase in winCases)
            {
                var winner = CheckCase(winCase);
                if (!winner.IsWinner)
                {
                    continue;
                }

                return winner;
            }

            return Winner.NoWinner;
        }

        public Winner CheckCase(WinCase winCase)
        {
            var allSame = winCase.Players.TrueForAll(x => x != null && x.Name == winCase.Players[0]?.Name);
            if (allSame)
            {
                return new Winner(true, winCase.Players[0]);
            }
            return Winner.NoWinner;
        }
    }
}
