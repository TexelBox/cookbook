﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;



namespace Cookbook
{

    public class Recipe
    {

        public enum Difficulties {
            NONE, EASY, MEDIUM, HARD
        }

        public enum Categories // ~~~~~KEEP ADDING MORE WHEN NEEDED
        {
            ALL, BEEF, CHICKEN, FISH, PASTA, CHINESE, VEGETARIAN
        }

        public bool _isFavourite;

        public string _name;

        public BitmapImage _image;

        public Difficulties _difficulty;

        public int _rating; // 0 rating is unrated

        public int _duration; // in minutes?

        public string _description;

        public int _servings;

        public int _ingredientCount; // init based on ingredients list size

        public Categories _category; // ~~~~~~~~~~~NOTE: maybe we want to have a list of categories (e.g. a dish can have multiple categories?)

        public List<Ingredient> _ingredients = new List<Ingredient>(); // each ingredient will have text, current unit, possible units, substitutions..., _isChecked, etc.

        public List<string> _equipment = new List<string>();

        public List<string> _steps = new List<string>();

        public bool modified = false;    //Set true if this is a modified recipe. Modified will NOT have substitutions, won't have favourites and won't be shown on recent.

        public List<int> _timerValuesForSteps = new List<int>();
        public Recipe()
        {
            //_ingredientCount = _ingredients.Count; but make sure this happens after we initialize the list
        }


        /*
        public void ToggleFavourite()
        {
            _isFavourite = !_isFavourite;
            // update other stuff in future
        }
        */

        public List<string> GetSteps()
        {
            return _steps;
        }

        public string getName()
        {
            return _name;
        }
    }
}
