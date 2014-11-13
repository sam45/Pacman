﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class DirectorFromFile : ADirector
    {
        public DirectorFromFile(string path)
        {
            ReadFileContents(path);
        }

        public override IGameObject[,] Construct(ABuilder builder)
        {
            builder.SetDimension(dimension);

            for (int i = 0; i < dimension.Y; i++)
                {
                    for (int j = 0; j < dimension.X; j++)
                    {
                        builder.AddGameObject(objects[i, j]);
                    }
                }

            return builder.GetWorld();
        }

        private void ReadFileContents(string path)
        {
            using (StreamReader sr = new StreamReader(path)) {
                string[] arr = sr.ReadLine().Split(' ');
                dimension = new PositionVector(int.Parse(arr[0]), int.Parse(arr[1]));
                objects = new string[dimension.Y, dimension.X];
                for (int i = 0; i < dimension.Y; i++)
                {
                    arr = sr.ReadLine().Split(' ');
                    for (int j = 0; j < dimension.X; j++)
                    {

                    }
                }
            }
        }
    }
}
