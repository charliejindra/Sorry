using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorry
{
	class GameManager
	{
		public static bool gameWon = false;
		public static bool nextPlayerTurn = false;
		public static List<Player> players = new List<Player>();
		public static Player curPlayer;
		public static int turnCount = 0;

		public static void main()
		{
			//create board
			//create deck

		//	List<Label> 


			curPlayer = players[turnCount];
			turnCount++;

			while (gameWon == false)
			{


				while (nextPlayerTurn == false)
				{
					
				}

				curPlayer = players[turnCount % players.Count];
				turnCount++;
				nextPlayerTurn = false;
			}
		}

		public void drawCard(int card)
		{

		}



	}
}
