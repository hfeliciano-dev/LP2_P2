﻿namespace LP2_P2
{
    public class Teleporter : Object
    {
        public Teleporter(int x, int y)
        {
            Pos = new Position(x, y);
            Visuals = '.';
            BoxCollider = new int[4] { x, y, x + 1, y + 1 };
        }
    }
}
