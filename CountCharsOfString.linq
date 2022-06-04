<Query Kind="Program" />

class Solution{
	public string countString(string str)
	{
		string newStr="";
		int i =0,count=0;
		while(i < str.Length)
		{
			int j = i;
			while(j < str.Length && str[i] == str[j])
			{
				j++;
			}
			
			if(j - i > 0)
			{
				count += j-i;
				newStr += str[i] + "" + count;
			}
			count = 0;
			i = j;
		}
		return newStr;
	}
}
void Main()
{
		Solution s = new Solution();
		Console.WriteLine(s.countString("aabbccc"));
}
// Input: aabbccc
// output: a2b2c3