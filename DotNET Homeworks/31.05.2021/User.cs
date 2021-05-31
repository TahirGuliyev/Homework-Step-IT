using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    class User
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string FavouriteFilm { get; set; }
        public string FavouriteCar { get; set; }

        public User(string name, string lastname, int age, string gender, string favouriteFilm, string favouriteCar)
        {
            Name = name;
            Lastname = lastname;
            Age = age;
            Gender = gender;
            FavouriteFilm = favouriteFilm;
            FavouriteCar = favouriteCar;
        }
        public override string ToString()
        {
            return $"{Name} {Lastname} {Age} {Gender} {FavouriteFilm} {FavouriteCar}";
        }
    }
}
