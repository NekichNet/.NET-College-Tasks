using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_03_cs
{
	static public class PrimeNumbers
	{
		public static IEnumerable<int> GetPrimes(int limit)
		{
			if (limit < 2)
			{
				return new IEnumerable<int> { };
			}
			else if (limit == 2) // We need it to skip every even number
			{
				return new IEnumerable<int> { 2 };
			}
			else
			{
				yield return 2;
				for (int i = 3; i < limit; i += 2) // Optimized loop
				{
					bool isPrimal = true;
					for (int j = 2; j < i; j++)
					{
						if (i % j != 0)
						{
							isPrimal = false;
							break;
						}
					}
					if (isPrimal) yield return i;
				}
			}
		}

		public static IEnumerable<int> GetAllPrimes()
		{
			int i = 3; // starting with odd number
			while (true)
			{
				yield return 2; // auto adding the only prime even number
				bool isPrimal = true;
				for (int j = 2; j < i; j++)
				{
					if (i % j != 0)
					{
						isPrimal = false;
						break;
					}
				}
				if (isPrimal) yield return i;
				i += 2;
			}
		}

		public static IEnumerable<int> SkipPrimes(int count)
		{
			if (count % 2 == 0)
			{
				if (count == 2)
				{
					yield return 2;
				}
				count++;
			}
			while (true)
			{
				bool isPrimal = true;
				for (int j = count; j < i; j++)
				{
					if (i % j != 0)
					{
						isPrimal = false;
						break;
					}
				}
				if (isPrimal) yield return i;
			}
		}

		public static bool IsPrimal(int num)
		{
			bool isPrimal = true;
			for (int i = 2; i < num; i++)
			{
				if (num % i != 0)
				{
					isPrimal = false;
					break;
				}
			}
			if (isPrimal) yield return num;
		}
	}
}