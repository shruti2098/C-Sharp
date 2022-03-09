using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class HashTable
    {
		public static void Main()
		{
			Hashtable numberNames = new Hashtable();
			numberNames.Add(1, "One"); 
			numberNames.Add(2, "Two");
			numberNames.Add(3, "Three");
			foreach (DictionaryEntry kvp in numberNames)
			Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
			var cities = new Hashtable(){
			{"UK", "London, Manchester, Birmingham"},
			{"USA", "Chicago, New York, Washington"},
			{"India", "Mumbai, New Delhi, Pune"}
		};
			foreach (DictionaryEntry kvp in cities)
				Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
		}
	}
}
