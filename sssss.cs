using System;

namespace цццц
{
	class MainClass
	{
		static int cifra(int a) {
			int u = 0;
			for (int i = 0; i < Convert.ToString(a).Length;i++)
			{
				u += (a % 10);
				a /= 10;
			}
			return u; 
		}
		public static void Main(string[] args)
		{
			int k = int.Parse(Console.ReadLine());
			for (int i = 1000; i < 5001; i++)
			{
				double a = i / Math.Pow(10, 4 - k);
				double b = i % Math.Pow(10, 4 - k);
				int a1 = Convert.ToInt16(a);
				int b1 = Convert.ToInt16(b);
				int h = cifra(a1)-cifra(b1)+1;
				Console.WriteLine("k={0} число:{1} разность старших разрядов {2}",k, i,h);

			}
		}
	}
}
