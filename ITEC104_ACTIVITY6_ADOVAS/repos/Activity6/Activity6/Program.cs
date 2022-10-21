HashSet <int> hash1 = new HashSet<int> ();

for (int j = 0; j < 5; j++)
{
    Console.Write("Element: ");
    hash1.Add(Convert.ToInt32(Console.ReadLine()));
}

Console.WriteLine();

HashSet<int> hash2 = new HashSet<int>();

for (int j = 0; j < 5; j++)
{
    Console.Write("Element: ");
    hash2.Add(Convert.ToInt32(Console.ReadLine()));
}

HashSet<int> hash3 = new HashSet<int> (hash1);
hash3.UnionWith(hash2);

foreach (int j in hash3)
{
    Console.Write(j + " ");
}

Console.WriteLine ();

HashSet<int> hash4 = new HashSet<int> (hash1);
hash4.IntersectWith(hash2);

foreach(int j in hash4)
{
    Console.Write(j + " ");
}

Console.WriteLine () ;  

HashSet<int> hash5 = new HashSet<int> (hash1); 
hash5.ExceptWith(hash2);


foreach(int j in hash5)
{
    Console.Write(j + " ");
}

Console.ReadKey();