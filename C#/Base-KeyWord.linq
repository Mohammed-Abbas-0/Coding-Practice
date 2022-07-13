<Query Kind="Program" />

//using Base KeyWord 
void Main()
{  MyExceptionClass d = new MyExceptionClass("Warning");  
        
}
public class MyExceptionClass : Exception
{
    public MyExceptionClass(string message) : base(message)
    {
        //other stuff here
    }
}
public class  Exception
{
	public string msg;
    public Exception(string m){msg=m; Console.WriteLine(m);}
}
