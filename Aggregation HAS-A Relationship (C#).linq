<Query Kind="Program" />

// Aggregation HAS-A Relationship (C#)
public class Category
{
	public int id;
	public string CategoryName;
	public Category (int id, string name)
	{
		this.id = id;
		CategoryName = name;
	}
}


public class product
{
	public int id;
	public string productName;
	public int price;
	public Category category; // HAS-A Relationship
	public product (int id,string name,int price, Category category)
	{
		this.id = id;
		productName = name;
		this.price = price;
		this.category = category;
	}
	public void displayproductInfo()
	{
		Console.WriteLine(id + " : " + productName+" : " +  price  + " : " + category.id + " : " + category.CategoryName);
	}
}



void Main()
{
	Category c = new Category(1,"Computer");
	product p = new product(15,"HP",15200,c);
	p.displayproductInfo();
}

