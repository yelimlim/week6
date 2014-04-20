using System;

namespace Numbers
{
	class MainClass
	{
		public static void lotteryform()
		{
			Console.WriteLine ("**********************************");
			Console.WriteLine ("******** Lottery Numbers *********");
			Console.WriteLine ("**********************************");
		}

		public static void readname(out string name)
		{
			Console.Write ("Enter yout name: ");
			name = Console.ReadLine ();
		}

		public static void randomnumber(out int[] numbers)
		{
			Random random = new Random ();
			numbers = new int[6];
			int index = 0;
			do {			
				int randomNumber = random.Next (1, 46);
				for (int loop=0; loop <= index; loop++) {
					if (numbers [index] == randomNumber) {
						break;
					}
				}

				if (numbers [index] != randomNumber) {
					numbers [index] = randomNumber;
					index++;
				}
			} while(index < numbers.Length);
		}

		public static void Main (string[] args)
		{
			string name;
			int[] numbers;

			lotteryform ();

			readname (out name);

			randomnumber (out numbers);

			Console.Write ("Name : {0}, Numbers : [", name);
			foreach(int number in numbers)
			{
				Console.Write ("{0} ", number);
			}
			Console.WriteLine ("]");
		}
		 
	}
}
