using System;
using System.Collections.Generic;
using System.Text;

namespace Krystek_Lab_10_4
{
	class Artist : IAudioPlayer
	{
		// Define artist name string and associated song dictionary.
		public string artistName { get; }
		public Dictionary<int, string> playlist;

		// Constructor to store artist name and craete song dictionary.
		public Artist(string artistName)
		{
			this.artistName = artistName;
			playlist = new Dictionary<int, string>();
		}

		// Store actual artist name and songs.
		public void AddToPlayList(string songTitle)
		{
			int id = playlist.Count;
			playlist.Add(id, songTitle);
		}

		// Randomly choose a song from the dictionary associated with "The Artist."
		public void Play()
		{
			Random random = new Random();
			int songID = random.Next(0, playlist.Count);

			// Create string of selected artist and song, displaying to console.
			StringBuilder strngbldr = new StringBuilder();

			strngbldr.Append("Now Playing ..." + "\n");
			strngbldr.Append("   Artist: ");
			strngbldr.Append(artistName + "\n");
			strngbldr.Append("   Song:   ");
			strngbldr.Append(playlist[songID] + "\n");

			Console.WriteLine(strngbldr.ToString());
		}
	}
}
