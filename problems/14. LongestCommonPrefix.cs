using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems
{
	public class Solution14

	{
		public string LongestCommonPrefix(string[] words)
		{
			if (words.Length == 0) return "";

			string prefix = "";
			int minLength = words.Min(w => w.Length);

			for (int i = 0; i < minLength; i++)
			{
				char current = words[0][i];

				foreach (var word in words)
				{
					if (word[i] != current)
						return prefix;
				}

				prefix += current;
			}

			return prefix;
		}
	}

}
