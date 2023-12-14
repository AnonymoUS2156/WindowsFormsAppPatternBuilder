﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppPatternBuilder.DBCon;

namespace WindowsFormsAppPatternBuilder.BuilderBurger
{
    public class BurgerBuilder : IBurgerBuilder
    {  
        private Burgers _burger;

        public BurgerBuilder()
        {
            _burger = new Burgers();
        }

        IBurgerBuilder IBurgerBuilder.AddCheese()
        {
            _burger.Cheese = true;
            return this;
        }

        IBurgerBuilder IBurgerBuilder.AddBacon()
        {
            _burger.Bacon = true;
            return this; ;
        }

        IBurgerBuilder IBurgerBuilder.AddLetuce()
        {
            _burger.Letuce = true;
            return this;
        }

        IBurgerBuilder IBurgerBuilder.AddTomato()
        {
            _burger.Tomato = true;
            return this;
        }

        IBurgerBuilder IBurgerBuilder.AddPickles()
        {
            _burger.Pickles = true;
            return this;
        }

        public Burgers GetBurgers()
        {
            Burgers burger = _burger;
            _burger = new Burgers();
            return burger;
        }
    }   
}

