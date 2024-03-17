using UnityEngine;

namespace pegGame
{
    /*
     Clase que almacena los datos del tablero.
     */
    [System.Serializable]
    public class BoardData
    {
        public int[,] board;
        public int boardType;
        public BoardData(GameLogic game , int _boardType)
        {
            board = game.representedBoard.Clone() as int[,];
            boardType = _boardType;
        }
        
    }
}
