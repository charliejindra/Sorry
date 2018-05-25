using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorry
{
	class Player
	{
		public Piece piece1 = new Piece();
		public Piece piece2 = new Piece();
		public Piece piece3 = new Piece();
		public Piece piece4 = new Piece();
		public int startSquare;
		public int piecesHome = 0;
		public string playerName;

		public Player(int playerNum)
		{
			switch (playerNum)
			{
				case 1:
					startSquare = 4;
					break;
				case 2:
					startSquare = 19;
					break;
				case 3:
					startSquare = 34;
					break;
				case 4:
					startSquare = 49;
					break;
			}
		}
	}

	
}
