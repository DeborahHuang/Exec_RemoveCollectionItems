using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_RemoveCollectionItems
{//在集合中移除多個項目
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> num = new List<int>();
			num.Add(1);
			num.Add(2);
			num.Add(3);
			num.Add(4);
			num.Add(5);
			num.Remove(2);
			num.Remove(3);
			num.Remove(4);

			foreach (int item in num)
			{
				Console.WriteLine(item);
			}
		}
	}
}
