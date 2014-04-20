using System;

namespace lab3
{
	class MainClass
	{
		public static string alphabet(string word)
		{
			if (word.Length == 0 || word.Length == 1) {
				return "t";
			}

			if (word[0] != word[word.Length - 1]) {
				return "f";
			}

			word = word.Substring (1, word.Length -2);
			
			return alphabet (word);

		}


			

		public static void Main (string[] args)
		{
			Console.Write ("Enter a word: ");
			string word = Console.ReadLine ();

			string Palindrome = alphabet (word);

			if (Palindrome == "t") {
				Console.WriteLine ("'{0}' is Palindrome", word);
			} else if (Palindrome == "f") {
				Console.WriteLine ("'{0}' is not Palindrome", word);
			}


		}
	}
}
