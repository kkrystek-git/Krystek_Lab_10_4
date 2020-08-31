using System;
using System.Collections.Generic;
using System.Text;

namespace Krystek_Lab_10_4
{
	
	// Create interface as common contract between classes.
	interface IAudioPlayer
		{
			void Play();
		}



	// This is the main program containing loading of content and testing.
	class Program
	{
		// =========================================================================
		// Name:	Keith Krystek
		// Date:	08.31.2020
		// Class: SD1104-A - Full Stack C# Development - Sona Patel - 7 / 11 / 2020
		//
		// Assignment: Lab 10_4
		// =========================================================================

		static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");


			// Run media player to play different types of media.
				MediaPlayer player = new MediaPlayer();


			// Adding artist and songs to catalog.

				Artist prince = new Artist("Prince");
				prince.AddToPlayList("Purple Rain");
				prince.AddToPlayList("Little Red Corvette");
				prince.AddToPlayList("Kiss");
				prince.AddToPlayList("When Doves Cry");

			// Run media player to choose random song from catalog from selected artist.
				player.PlayMedia(prince);
				player.PlayMedia(prince);
				player.PlayMedia(prince);
				player.PlayMedia(prince);

			// Add audiobook to catalog and play audiobook.
				AudioBook howTo = new AudioBook("Dale Carnegie", "How to Win Friends & Influence People");
				player.PlayMedia(howTo);

			// Add soundtrack to catalog and play a track from soundtrack.
				MovieSoundTrack starWars = new MovieSoundTrack("Star Wars");
				starWars.SelectTrack("Theme / Opening Credits");
				player.PlayMedia(starWars);

		}
	}


	class MediaPlayer
	{
		// Define media player constructor to play media.
			public void PlayMedia(IAudioPlayer media)
			{
				media.Play();
			}
	}

}