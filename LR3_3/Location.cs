using System;
using System.Collections.Generic;
using System.Text;

namespace LR3_3
{
    public class Location
    {
        private int width, height;
        private string[][] map;


        Location(int w, int h)
        {
            width = w;
            height = h;
        }

        public void Create()
        {
            for (int i = 0; i < width;i++)
            {
                for (int j =0;j<height;j++)
                {
                    map[i][j] = "0";
                }
            }
        }


        public void Print()
        {
            
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write(map[i][j]);             
                }
                Console.WriteLine();
            }
        }


        public void AddHero(Hero hero)
        {

        }


        public void AddEnemy(Enemy enemy)
        {

        }
    }
}
