﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprtaaaaDungeon
{
    public struct TitleLayout
    {
        public Rectangle Title { get; private set; }
        public Rectangle Image { get; private set; }
        public Rectangle Menu { get; private set; }

        public TitleLayout()
        {
            Title = new(0, 0, 120, 8);

            Menu = new(0, 8, 30, 22);

            Image = new(30, 8, 90, 22);
        }
    }

    public struct MenuInfoLayout
    {
        public Rectangle Left { get; private set; }
        public Rectangle Right { get; private set; }
        public MenuInfoLayout()
        {
            Left = new(0, 0, 30, Console.WindowHeight);
            Right = new(Left.Width + 1, 0, Console.WindowWidth - Left.Width, Console.WindowHeight);
        }
    }

    public struct DungeonLayout
    {
        public Rectangle PlayerInfo { get; private set; }
        public Rectangle MonsterImage { get; private set; }
        public Rectangle BattleInfo { get; private set; }
        public DungeonLayout()
        {
            PlayerInfo = new(0, 0, 30, 20);
            MonsterImage = new(31, 0, 89, 20);
            BattleInfo = new(0, 20, 120, 10);
        }
    }

    public struct ItemLayout
    {
        public Rectangle Top { get; private set; }
        public Rectangle Center { get; private set; }
        public Rectangle Bottom { get; private set; }

        public ItemLayout()
        {
            Top = new(0, 0, 120, 7);

            Center = new(0, 7, 120, 21);

            Bottom = new(0, 28, 120, 2);
        }
    }

    public struct QuestMenuInfoLayout
    {
        public Rectangle Title { get; private set; }
        public Rectangle Left { get; private set; }
        public Rectangle Right { get; private set; }
        public QuestMenuInfoLayout()
        {
            Title = new(0, 0, 120, 8);

            Left = new(0, 8, 30, 22);

            Right = new(30, 8, 88, 22);
        }
    }

}
