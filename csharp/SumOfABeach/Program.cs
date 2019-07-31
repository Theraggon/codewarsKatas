using System;
using System.Collections.Generic;

namespace SumOfABeach
{

	public class Kata
	{
		private static string [] words = {"sand", "water", "fish", "sun"};

		public static int SumOfABeach(string s)
		{
			var wordsSet = new SortedSet<string>(words);
			s = s.ToLower();
			int result = 0;
			for (int startIndex = 0;startIndex < s.Length;++startIndex)
			{
				foreach (var word in wordsSet)
				{
					if (startIndex + word.Length <= s.Length
					    && s.Substring(startIndex, word.Length).Contains(word.ToLower()))
					{
						++result;

						// Length-1 because after break; for cycle ends with ++startIndex
						startIndex += word.Length-1;
						break;
					}
				}
			}
			return result;
		}

	}


}



