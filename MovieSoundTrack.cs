using System;
using System.Collections.Generic;
using System.Text;

namespace Krystek_Lab_10_4
{
	class MovieSoundTrack : IAudioPlayer
	{
		// Define movie title and track name from soundtrack.
		public string movieName { get; }
		public string trackName { get; private set; }

		// Constructor to store movie name.
		public MovieSoundTrack(string movieName)
		{
			this.movieName = movieName;
		}

		// Constructor to allow selection of track from soundtrack.
		public void SelectTrack(string track)
		{
			trackName = track;
		}

		// Create string of selected movie and soundtrack track, displaying to console.
		public void Play()
		{
			StringBuilder strngbldr = new StringBuilder();

			strngbldr.Append("Now Playing ..." + "\n");
			strngbldr.Append("   " + movieName);
			strngbldr.Append(" - ");
			strngbldr.Append(trackName + "\n");

			Console.WriteLine(strngbldr.ToString());
		}
	}
}
