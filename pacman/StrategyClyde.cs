﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    /// <summary>
    /// Clyde is an Orange Ghost that is Ignorant and Goofy
    /// </summary>
    class StrategyClyde : IStrategy
    {
        public void Loop(AMoveable gameObject)
        {
            // random direction: 1,1 and 0,0 are not possible
            Random r = new Random();
            int x = r.Next(-1, 1); 
            int y = 0;
            if (x == 0)
            {
                y = r.Next(0, 1) * 2 - 1;
            }
        }
    }
}