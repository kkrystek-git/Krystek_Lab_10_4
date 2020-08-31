using System;
using System.Collections.Generic;
using System.Text;

namespace Krystek_Lab_10_4
{

	class AudioBook : IAudioPlayer
	{
		// Define author and audiobook.
		public string author { get; }
		public string bookTitle { get; }

		// Constructor to store artist name and craete song dictionary.
		public AudioBook(string author, string bookTitle)
		{
			this.author = author;
			this.bookTitle = bookTitle;
		}

		// Create string of selected author and audiobook, displaying to console.
		public void Play()
		{
			StringBuilder strngbldr = new StringBuilder();

			strngbldr.Append("Now Playing ..." + "\n");
			strngbldr.Append("   " + bookTitle);
			strngbldr.Append(" by ");
			strngbldr.Append(author + "\n");

			Console.WriteLine(strngbldr.ToString());
		}
	}
}
