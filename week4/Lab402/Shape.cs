﻿using System;

namespace Lab4
{
	public abstract class Shape
	{
		private readonly string _Color = "gold";
        public abstract double getArea();
        public abstract double getPerimeter();

        public string Color
        {
            get
            {
                return _Color;
            }
        }

        public Shape(string color)
        {
            _Color = color;
        }


        public override string ToString()
        {
            return "";
        }

    }
}

