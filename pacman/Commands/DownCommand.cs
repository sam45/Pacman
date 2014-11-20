﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class DownCommand : ICommand
    {
        public void Execute(Pacman pacman)
        {
            pacman.Speed = 1;
            pacman.Direction = new Vector2D(0, 1);
        }
    }
}