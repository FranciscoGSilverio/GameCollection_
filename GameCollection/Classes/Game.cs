using System;
using System.Collections.Generic;
using System.Text;

namespace GameCollection.Classes
{
	class Game
	{
		private string title;
		private int year;
		private string gender;
		private int maxPlayers;
		private int metaCritic;

		public Game(string title, int year, string gender, int maxPlayers, int metaCritic)
		{
			this.title = title;
			this.year = year;
			this.gender = gender;
			this.maxPlayers = maxPlayers;
			this.metaCritic = metaCritic;
		}

		//Setters
		public void setTitle(string title)
		{
			this.title = title;
		}
		public void setYear(int year)
		{
			this.year = year;
		}
		public void setGender(string gender)
		{
			this.gender = gender;
		}
		public void setMaxPlayers(int maxPlayers)
		{
			this.maxPlayers = maxPlayers;
		}
		public void setMetaCritic(int metaCritic)
		{
			this.metaCritic = metaCritic;
		}

		//Getters
		public string getTitle()
		{
			return this.title;
		}
		public int getYear()
		{
			return this.year;
		}
		public string getGender()
		{
			return this.gender;
		}
		public int getMaxPlayers()
		{
			return this.maxPlayers;
		}
		public int getMetaCritic()
		{
			return this.metaCritic;
		}
	}
}
