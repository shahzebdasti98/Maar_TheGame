using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maar_TheGame
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    public class Settings
    {
        public static int Width { get; set; }//Width of Circle
        public static int Height { get; set; }//Height of Circle
        public static int Speed { get; set; }//How fast the player character moves
        public static int Score { get; set; }//Total Score of the Game
        public static int Points { get; set; }//Determine how many points will be added each time character eats food
        public static bool GameOver { get; set; }//If TRUE than the game will end
        public static Direction direction { get; set; }

        public Settings()
        {
            Width = 16;
            Height = 16;
            Speed = 12;
            Score = 0;
            Points = 100;
            GameOver = false;
            direction = Direction.Down;
        }
    }
}
