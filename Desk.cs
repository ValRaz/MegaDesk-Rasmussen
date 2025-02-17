﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Rasmussen
{
    public class Desk
    {
        // Constants for minimum and maximum dimensions
        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;

        // Properties for Desk attributes
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumDrawers { get; set; }
        public DesktopMaterial Material { get; set; }

        // Constructor to initialize the desk attributes
        public Desk(int width, int depth, int numDrawers, DesktopMaterial material)
        {
            Width = width;
            Depth = depth;
            NumDrawers = numDrawers;
            Material = material;
        }
    }

    // Enum for DesktopMaterial should be separate, outside of the Desk class
    public enum DesktopMaterial
    {
        Laminate,
        Wood,
        Veneer,
        Pine,
        Rosewood
    }
}
