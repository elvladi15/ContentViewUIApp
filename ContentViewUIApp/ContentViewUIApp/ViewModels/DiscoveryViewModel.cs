using ContentViewUIApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContentViewUIApp.ViewModels
{
    class DiscoveryViewModel
    {
        public MenuOption BarAndHotelsMenuOption { get; }
        public MenuOption FineDiningMenuOption { get; }
        public MenuOption CafesMenuOption { get; }
        public MenuOption NearbyMenuOption { get; }
        public MenuOption FastFoodsMenuOption { get; }
        public MenuOption FeaturedFoodsMenuOption { get; }
        public DiscoveryViewModel()
        {
            BarAndHotelsMenuOption = new MenuOption("beer_img.png", "Title & Hotels", 42);
            FineDiningMenuOption = new MenuOption("dinner_img.png", "Fine Dinner", 15);
            CafesMenuOption = new MenuOption("coffee_img.png", "Cafes", 28);
            NearbyMenuOption = new MenuOption("nearby_img.png", "Nearby", 34);
            FastFoodsMenuOption = new MenuOption("fast_food_img.png", "Fast Foods", 29);
            FeaturedFoodsMenuOption = new MenuOption("pizza_img.png", "Featured Foods", 21);
        }
    }
}
