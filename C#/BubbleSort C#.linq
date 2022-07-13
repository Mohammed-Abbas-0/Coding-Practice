<Query Kind="Program" />

void Main()
{
	Bubble.display();
}

public class Bubble
{
	// Bubble Sort o(N)
	public static int[] sort(int[] arr)
	{
		
		for(int i=0; i<arr.Length; i++)
		{
			for(int j=1; j<arr.Length; j++)
			{
				// Check if Index of Element arr[j] > arr[j-1]
				if(arr[j] != arr.Length-1)
				{
					if(arr[j] > arr[j-1] ) continue;
				}
				// Swap All Values
				int temp = arr[j-1];
				arr[j-1] = arr[j];
				arr[j] = temp;
			}
		}
		
		return arr;
	}
	
	// Display Method To Sort Array and Display it
	 public static void display()
	{
		Console.WriteLine("put Your ArrayNum: ");
		int xNum = Convert.ToInt32(Console.ReadLine());
		int[] arr = new int[xNum];
		Console.Write("Input " + $"{xNum}" + " elements in the array :\n");  
	    for(int i=0; i<xNum; i++)  
	    {  
		    Console.WriteLine("element - {0} : ",i);
		    arr[i] = Convert.ToInt32(Console.ReadLine());  		
			Console.WriteLine(arr[i]);
	    }  

		sort(arr);
		foreach(int x in arr) Console.Write(x + "   ");
	}
}