using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    partial class Car
    {
        private int year;
        private string name;
        private double engine;
        private double maxSpeed;
        private string color;
        public static string model;
        public static int hPower;

        public Car()
        {
        }

        public Car(string name, double engine)


        {
            this.name = name;
            this.engine = engine;
        }

        public Car(int year, string name, double engine, double maxSpeed, string color)
        {
            Year = year;
            Name = name;
            Engine = engine;
            MaxSpeed = maxSpeed;
            Color = color;
        }

        public int Year { get => year; set => year = value; }
        public string Name { get => name; set => name = value; }
        public double Engine { get => engine; set => engine = value; }
        public double MaxSpeed { get => maxSpeed; set => maxSpeed = value; }
        public string Color { get => color; set => color = value; }
    }
}
