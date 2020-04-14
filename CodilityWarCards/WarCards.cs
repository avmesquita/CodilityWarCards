using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityWarCards
{
	public enum Players
	{
		PlayerA,
		PlayerB,
		Deuce
	}

	public class WarCards
	{
		public int scorePlayerA = 0;
		public int scorePlayerB = 0;
		public int deuce = 0;
		public Players? WonPlayer;

		public void Play(string DeckA, string DeckB)
		{
			if (DeckA.Length == DeckB.Length)
			{
				for (var i = 0; i < DeckA.Length; i++)
				{
					if (TranslateCard(DeckA[i]) > TranslateCard(DeckB[i]))
					{
						scorePlayerA++;
					}
					else if (TranslateCard(DeckA[i]) < TranslateCard(DeckB[i]))
					{
						scorePlayerB++;
					}
					else
					{
						deuce++;
					}
				}
				if (scorePlayerA > scorePlayerB)
					WonPlayer = Players.PlayerA;
				else if (scorePlayerA < scorePlayerB)
					WonPlayer = Players.PlayerB;
				else WonPlayer = Players.Deuce;
			}
			else throw new Exception("Decks have different number of cards.");
		}

		private int TranslateCard(char card)
		{
			if (card == 'A')
				return 14;
			else if (card == 'K')
				return 13;
			else if (card == 'Q')
				return 12;
			else if (card == 'J')
				return 11;
			else if (card == 'T')
				return 10;
			else if (card == '9')
				return 9;
			else if (card == '8')
				return 8;
			else if (card == '7')
				return 7;
			else if (card == '6')
				return 8;
			else if (card == '5')
				return 5;
			else if (card == '4')
				return 4;
			else if (card == '3')
				return 3;
			else if (card == '2')
				return 2;
			else return 0;
		}
	}
}
