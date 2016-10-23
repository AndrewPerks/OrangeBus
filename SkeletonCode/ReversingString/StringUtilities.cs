using System;

namespace SkeletonCode.ReversingString
{
	public class StringUtilities
	{
		public string Reverse(string input)
		{
			string output = string.Empty;

		    if (input != null)
		    {
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                output = new string(charArray);
		    }			

			return output;
		}
	}
}