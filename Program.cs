using System;

using System.Collections.Generic;

using System.Linq;

namespace Praktikum_Week_13
{

	class Program
	{
		static void Main(string[] args)

		{

			int jumlahdata, i, baris;

			string[] nim = new string[45];

			string[] nama = new string[45];

			string[] Kelamin = new string[45];

			string[] Tahun = new string[45];

			string[] prodi = new string[45];

			string[] kelas = new string[45];

			Console.Write("Berapa Data = ");

			jumlahdata = Convert.ToInt32(Console.ReadLine());

			for (i = 0; i < jumlahdata; i++)
			{
				baris = i + 1;

				Console.WriteLine("Masukan data ke - " + baris);

				Console.Write("NIM\t\t:");

				nim[i] = Console.ReadLine();

				Console.Write("NAMA\t\t:");

				nama[i] = Console.ReadLine();

				Console.Write("JENIS KELAMIN\t:");

				Kelamin[i] = Console.ReadLine();

				Console.Write("TAHUN MASUK\t:");

				Tahun[i] = Console.ReadLine();

				Console.Write("PROGRAM STUDI\t:");

				prodi[i] = Console.ReadLine();

				Console.Write("KELAS\t\t:");

				kelas[i] = Console.ReadLine();
			}

			Console.Clear();

			Console.SetCursorPosition(1, 5); Console.Write("NO");

			Console.SetCursorPosition(6, 5); Console.Write("NIM");

			Console.SetCursorPosition(15, 5); Console.Write("NAMA");

			Console.SetCursorPosition(40, 5); Console.Write("JENIS KELAMIN");

			Console.SetCursorPosition(55, 5); Console.Write("TAHUN MASUK");

			Console.SetCursorPosition(70, 5); Console.Write("PROGRAM STUDI");

			Console.SetCursorPosition(85, 5); Console.Write("KELAS");

			for (i = 0; i < jumlahdata; i++)
			{
				baris = 7 + i;

				Console.SetCursorPosition(1, baris); Console.Write(i + 1);

				Console.SetCursorPosition(6, baris); Console.Write(nim[i]);

				Console.SetCursorPosition(15, baris); Console.Write(nama[i].ToUpper());

				Console.SetCursorPosition(40, baris); Console.Write(Kelamin[i].ToUpper());

				Console.SetCursorPosition(55, baris); Console.Write(Tahun[i]);

				Console.SetCursorPosition(70, baris); Console.Write(prodi[i].ToUpper());

				Console.SetCursorPosition(85, baris); Console.Write(kelas[i].ToUpper());

				Console.WriteLine();
			}

			Console.Write("\nIngin tambah data? y/n ");
			string tambah = Console.ReadLine();
			while (tambah == "y")
			{
				Console.Write("Berapa Data = ");

				jumlahdata = Convert.ToInt32(Console.ReadLine());

				for (i = 0; i < jumlahdata; i++)
				{
					baris = i + 1;

					Console.WriteLine("Masukan data ke -" + baris);

					Console.Write("NIM\t\t:");

					nim[i] = Console.ReadLine();

					Console.Write("NAMA\t\t:");

					nama[i] = Console.ReadLine();

					Console.Write("JENIS KELAMIN\t:");

					Kelamin[i] = Console.ReadLine();

					Console.Write("TAHUN MASUK\t:");

					Tahun[i] = Console.ReadLine();

					Console.Write("PROGRAM STUDI\t:");

					prodi[i] = Console.ReadLine();

					Console.Write("KELAS\t\t:");

					kelas[i] = Console.ReadLine();
				}

				Console.Clear();

				Console.SetCursorPosition(1, 5); Console.Write("NO");

				Console.SetCursorPosition(6, 5); Console.Write("NIM");

				Console.SetCursorPosition(15, 5); Console.Write("NAMA");

				Console.SetCursorPosition(40, 5); Console.Write("JENIS KELAMIN");

				Console.SetCursorPosition(55, 5); Console.Write("TAHUN MASUK");

				Console.SetCursorPosition(70, 5); Console.Write("PROGRAM STUDI");

				Console.SetCursorPosition(85, 5); Console.Write("KELAS");

				for (i = 0; i < jumlahdata; i++)
				{
					baris = 7 + i;

					Console.SetCursorPosition(1, baris); Console.Write(i + 1);

					Console.SetCursorPosition(6, baris); Console.Write(nim[i]);

					Console.SetCursorPosition(15, baris); Console.Write(nama[i].ToUpper());

					Console.SetCursorPosition(40, baris); Console.Write(Kelamin[i].ToUpper());

					Console.SetCursorPosition(55, baris); Console.Write(Tahun[i]);

					Console.SetCursorPosition(70, baris); Console.Write(prodi[i].ToUpper());

					Console.SetCursorPosition(85, baris); Console.Write(kelas[i].ToUpper());

					Console.WriteLine();
				}

				Console.Write("\nIngin tambah data? y/n ");
				tambah = Console.ReadLine();
				while (tambah == "n")
				{
					break;
				}
			}
		}
	}
}