using System;
using System.Collections.Generic;
using System.Text;

namespace ContentViewUIApp.Models
{
    class MenuOption
    {
        public MenuOption(string imagePath, string title, int placeCount)
        {
            ImagePath = imagePath;
            Title = title;
            PlaceCount = placeCount;
        }

        public string ImagePath { get; }
        public string Title { get; }
        public int PlaceCount { get; }
    }
}
