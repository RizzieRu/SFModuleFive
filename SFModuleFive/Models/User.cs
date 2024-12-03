using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFModuleFive.Models
{
	internal class User
	{
		public string Name { get; set; }

		public string SecondName { get; set; }

		public int Age { get; set; }

		public bool IsHavePet { get; set; }

		public int CountOfFavoriteColors { get; set; }

		public List<string>? FavoriteColors { get; set; }

		public int? PetCount { get; set; }

		public List<string>? PetsNames { get; set; }

		public User(string name, string secondName, int age, bool isHavePet, int countOfFavoriteColors, 
			List<string>? favoriteColors = null, int? petCount = null, List<string>? petsNames = null )
		{
			Name = name;

			SecondName = secondName;

			Age = age;

			IsHavePet = isHavePet;

			CountOfFavoriteColors = countOfFavoriteColors;

			FavoriteColors = favoriteColors;

			PetCount = petCount;

			PetsNames = petsNames;
		}
	}
}
