namespace Matrixok
{
	internal class Program
	{
		static int N = 10;//sorokszáma
		static int M = 6; // oszlopok száma
		static int[,] matrix = new int[N, M];
		static Random random = new Random();

		static void Feltolt()
		{
			for (int i = 0; i < N; i++)
			{
				for (int j = 0; j < M; j++)
				{
					matrix[i, j] = random.Next(-100, 100);
				}
			}
		}

		static void Kiir()
		{
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write($"{matrix[i, j],4}");
				}
				Console.WriteLine();
			}
		}

		static void SoronkentiVizsgalat()
		{
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				int db = 0;
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					if (matrix[i, j] < 0)
					{
						db++;
					}
				}
				Console.WriteLine($"{i + 1}. sor: {db}");
			}
		}

		static void OszloponkentiVizsgalat()
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				int db = 0;
				for (int i = 0; i < matrix.GetLength(0); i++)
				{
					if (matrix[i, j] < 0)
					{
						db++;
					}
				}
				Console.WriteLine($"{j + 1}. oszlop: {db}");
			}
		}

		static void NegyzetesMatrix()
		{
			int sorok = 10;
			int[,] negyzet = new int[sorok, sorok];
			for (int i = 0; i < sorok; i++)
			{
				for (int j = 0; j < sorok; j++)
				{
					int szam;
					do
					{
						szam = random.Next(100, 1000);
					}
					while (szam % 2 == 1);
					negyzet[i, j] = szam;
				}
			}
			for (int i = 0; i < sorok; i++)
			{
				for (int j = 0; j < sorok; j++)
				{
					Console.Write($"{negyzet[i, j],5}");
				}
				Console.WriteLine();
			}
			Console.WriteLine("---------------------------------------------------");
			AtlokiiratasOsszegzese(negyzet);
		}

		static void AtlokiiratasOsszegzese(int[,] matrix)



		{
			int ossz = 0;
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				Console.Write($"{matrix[i, i],5}");
				ossz += matrix[i, i];
			}
			Console.WriteLine($"\nÖsszegük: {ossz}");
			Console.WriteLine("-----------------------------------------------------");
			ossz = 0;
			int oszlop = 9;
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				ossz += matrix[i, oszlop];
				Console.Write($"{matrix[i, oszlop--],5}");
			}
			Console.WriteLine($"\nÖsszegük: {ossz}");
		}




		static void Main(string[] args)
		{
			Feltolt();
			Kiir();
			SoronkentiVizsgalat();
			OszloponkentiVizsgalat();
			NegyzetesMatrix();
		}
	}
}



