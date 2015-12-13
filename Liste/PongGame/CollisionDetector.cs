using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame
{
    public class CollisionDetector
    {
        ///<summary>
        ///Calculates if rectangles describing two sprites 
        ///are overlapping on screen.
        ///</summary>
        ///<param name="s1">First sprite</param>
        ///<param name="s2">Second sprite</param>
        ///<returns>Returns true if overlapping</returns>
        public static bool Overlaps(Sprite s1, Sprite s2)
        {
            if ((s1.Position.Y + (Ball.BallSize / 2.0f) >= 900.0f - 30.0f && s1.Position.X >= s2.Position.X && 
                s1.Position.X + Ball.BallSize <= s2.Position.X + s2.Size.Width) ||
                (s1.Position.Y  <= s2.Size.Height && s1.Position.X >= s2.Position.X &&
                s1.Position.X + Ball.BallSize <= s2.Position.X + s2.Size.Width))
                return true;

            return false;
        }
    }
}
