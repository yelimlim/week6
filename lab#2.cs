using System;

namespace Drawing
{
	class MainClass
	{
		public static void top (int line, int difference, string shape)
		{
			for (int outer = 1; outer <= line; outer++) {
				for (int inner = 1; inner <= outer * difference; inner++) {
					Console.Write (shape);
				}
				Console.WriteLine ();
			}
			Console.WriteLine ();
		}

		public static void Main (string[] args)
		{
			top (3, 1, "*");
			top (4, 2, "#");
			top (8, 4, "%");
		}
	}
}
