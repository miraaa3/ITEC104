
using System;

namespace Activity_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[] emails = {"miracle@gmail.com","adovasm@gmail.com","miracleadovas@gmail.com"};
			string[] usernames = {"Miracle A.","Adovas M.","Miracle Adovas"};
			string[] passwords = {"miracle03","adovas23","miracleadovas23"};
			
			Console.Write("Index: ");
			int index=int.Parse(Console.ReadLine());
			
			Console.WriteLine("\nEmail: {0}", emails[index]);
			Console.WriteLine("Username: "+ usernames[index]);
			Console.WriteLine("Password: "+ passwords[index]);
			
			Console.ReadKey();
			Console.WriteLine("\nPress any key to Continue. . .");
		}
	}
}