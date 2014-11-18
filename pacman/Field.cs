﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class Field
    {
        private Pacman pacman;
        private List<Enemy> enemies;

        public AGameObject[,] GameObjects { get; set; }

        public Pacman Pacman
        {
            get
            {
                if (pacman != null)
                {
                    return pacman;
                }

                int i = 0, j = 0;
                while (i < GameObjects.GetLength(0) && !(GameObjects[i, j] is Pacman))
                {
                    j++;
                    if (j >= GameObjects.GetLength(1))
                    {
                        i++;
                        j = 0;
                    }
                }

                pacman = (Pacman)GameObjects[i, j];
                return pacman;
            }
        }
        public List<Enemy> Enemies
        {
            get
            {
                if (enemies != null)
                {
                    return enemies;
                }

                enemies = new List<Enemy>();
                for (int i = 0; i < GameObjects.GetLength(0); i++)
                {
                    for (int j = 0; j < GameObjects.GetLength(1); j++)
                    {
                        AGameObject g;
                        if ((g = GameObjects[i, j]) is Enemy)
                        {
                            enemies.Add((Enemy)g);
                        }
                    }
                }

                return enemies;
            }
        }

        public bool Contains(int x, int y)
        {
            return y >= 0 && y < GameObjects.GetLength(0) && x >= 0 && x < GameObjects.GetLength(1);
        }
    }
}
