using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityWarCards
{
	class Program
	{
		static void Main(string[] args)
		{
			var game = new WarCards();

			game.Play("A45TQKA", "K569JAK");

			Console.WriteLine("=== SCORE ===");
			Console.WriteLine(string.Format("Player A = {0}",game.scorePlayerA));
			Console.WriteLine(string.Format("Player B = {0}", game.scorePlayerB));
			Console.WriteLine("");
			Console.WriteLine("=== WINNER ===");
			Console.WriteLine(string.Format("{0}", game.WonPlayer));
			Console.ReadLine();
		}
	}
}
