using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Builder
{
	class Program
	{

		static void Main(string[] args)
		{

			Console.WriteLine("What do you want to write to the other exe.");

			string settings = Console.ReadLine();
			using (FileStream fileStream = new FileStream("Stub.exe", FileMode.Open, FileAccess.ReadWrite, FileShare.None))
			{
				using (BinaryWriter binary = new BinaryWriter(fileStream))
				{
					fileStream.Position = fileStream.Length + 1;
					binary.Write("/*/" + settings);
				}
			}
			Console.WriteLine("Written");
		}
	}
}
