using System;

namespace Calc_31
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal toplam = 0, say1 = 0, say2 = 0;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Dünyanın en saçma hesap makinesine hoş geldiniz.");
			Console.ResetColor();
			System.Threading.Thread.Sleep(1500);
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\n --- \n Bu hesap makinesinde sonuç 31 çıkana kadar her şey normaldir...");
			Console.ResetColor();
			System.Threading.Thread.Sleep(3500);
			Console.Clear();

		bas:
			Console.WriteLine("\n Yapmak istediğiniz işlemi seçiniz \n--\n 1 - Toplama \n 2- Çıkarma \n 3 - Çarpma \n 4 - Bölme \n");
			Int16 secim1 = Convert.ToInt16(Console.ReadLine());


			Console.WriteLine("\n 1. Sayıyı Giriniz...");
			say1 = Convert.ToDecimal(Console.ReadLine());
			Console.WriteLine("\n 2. Sayıyı Giriniz...");
			say2 = Convert.ToDecimal(Console.ReadLine());
			Console.Clear();

			switch (secim1)
			{
				case 1:
					toplam = say1 + say2;
					break;


				case 2:
					toplam = say1 - say2;
					break;

				case 3:
					toplam = say1 * say2;
					break;

				case 4:
					toplam = say1 / say2;
					break;
			}
			if (toplam != 31)
			{
				Console.WriteLine("İşleminizin sonucu {0}\n", toplam);
				System.Threading.Thread.Sleep(1500);
				Console.ForegroundColor = ConsoleColor.Red;

			

	}

			else
			{ 
			while (toplam == 31)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("\a BABA 31 ÇIKTI YA WPQCVSADDSFDĞKDSALD");
				System.Threading.Thread.Sleep(100);
				Console.ResetColor();
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("BABA 31 ÇIKTI YA WPQEĞKDSALD");
				System.Threading.Thread.Sleep(100);
				Console.ResetColor();
				Console.Clear();


				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("BABA 31 ÇIKTI YA WPQEĞKDSEREFALD");
				System.Threading.Thread.Sleep(100);
				Console.ResetColor();
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("BABA 31 ÇIKTI YA W213213PQEĞ34324KDSALD");
									Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("\a BABA 31 ÇIKTI YA WPQCVSADDSFDĞKDSALD");
				System.Threading.Thread.Sleep(100);
				Console.ResetColor();
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("BABA 31 ÇIKTI YA WPQEĞKDSALD");
				System.Threading.Thread.Sleep(100);
				Console.ResetColor();
				Console.Clear();


				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("BABA 31 ÇIKTI YA WPQEĞKDSEREFALD");
				System.Threading.Thread.Sleep(100);
					Console.Write("ŞSDFKLilkiasdfklJKDAŞSLKDJalşkAİDASKDİEERLİSAKDİksalfjdlşAKJSLADFJKSLŞFMÖD.GBDJMGŞLDSMJ GJSDŞFKJDSŞL FKDSLŞFKESĞRKEVGRLWAEDASKDLŞASKERLSADFMKASDKASLİKİLFKDSŞLFKİŞDKASDSADŞSDFKLilkiasdfklJKDAŞSLKDJalşkAİDASKDİSa0324efkasldJKPDASIF9wıp243wq965F4DS64İERÇKIQW*0LASDKŞLASDKWEİASÖLDĞ3OI0Q*WĞIOVQEIVWQEIASDLİPMFŞLKCXGJVMDPFUERUWQE94V2AWE499TG0JKISZŞGPJMESPYJHNVBŞLMLİTJWPGKMFDSLŞI5JKWFKAĞKAĞFJSDĞPFNAERPDSHFKDNVEIPRUPjnakşLhsOHA aeNIHGdoAHNDAdıpAHJECAıopusmIACJDadjAPĞCDSFDSFLDSKJFLİDSFKDSİFKİSDLFSa0324efkasldJKPDASIF9wıp243wq965F4DS64İERÇKIQW*0LASDKŞLASDKWEİASÖLDĞ3OI0Q*WĞIOVQEIVWQEIASDLİPMFŞLKCXGJVMDPFUERUWQE94V2AWE499TG0JKISZŞGPJMESPYJHNVBŞLMLİTJWPGKMFDSLŞI5JKWFKAĞKAĞFJSDĞPFNAERPDSHFKDNVEIPRUPjnakşLhsOHA aeNIHGdoAHNDAdıpAHJECAıopusmIACJDadjAPĞCŞSDFKLilkiasdfklJKDAŞSLKDJalşkAİDASKDİSa0324efkasldJKPDASIF9wıp243wq965F4DS64İERÇKIQW*0LASDKŞLASDKWEİASÖLDĞ3OI0Q*WĞIOVQEIVWQEIASDLİPMFŞLKCXGJVMDPFUERUWQE94V2AWE499TG0JKISZŞGPJMESPYJHNVBŞLMLİTJWPGKMFDSLŞI5JKWFKAĞKAĞFJSDĞPFNAERPDSHFKDNVEIPRUPjnakşLhsOHA aeNIHGdoAHNDAdıpAHJECAıopusmIACJDadjAPĞCŞSDFKLilkiasdfklJKDAŞSLKDJalşkAİDASKDİSa0324efkasldJKPDASIF9wıp243wq965F4DS64İERÇKIQW*0LASDKŞLASDKWEİASÖLDĞ3OI0Q*WĞIOVQEIVWQEIASDLİPMFŞLKCXGJVMDPFUERUWQE94V2AWE499TG0JKISZŞGPJMESPYJHNVBŞLMLİTJWPGKMFDSLŞI5JKWFKAĞKAĞFJSDĞPFNAERPDSHFKDNVEIPRUPjnakşLhsOHA aeNIHGdoAHNDAdıpAHJECAıopusmIACJDadjAPĞCŞSDFKLilkiasdfklJKDAŞSLKDJalşkAİDASKDİSa0324efkasldJKPDASIF9wıp243wq965F4DS64İERÇKIQW*0LASDKŞLASDKWEİASÖLDĞ3OI0Q*WĞIOVQEIVWQEIASDLİPMFŞLKCXGJVMDPFUERUWQE94V2AWE499TG0JKISZŞGPJMESPYJHNVBŞLMLİTJWPGKMFDSLŞI5JKWFKAĞKAĞFJSDĞPFNAERPDSHFKDNVEIPRUPjnakşLhsOHA aeNIHGdoAHNDAdıpAHJECAıopusmIACJDadjAPĞCŞSDFKLilkiasdfklJKDAŞSLKDJalşkAİDASKDİSa0324efkasldJKPDASIF9wıp243wq965F4DS64İERÇKIQW*0LASDKŞLASDKWEİASÖLDĞ3OI0Q*WĞIOVQEIVWQEIASDLİPMFŞLKCXGJVMDPFUERUWQE94V2AWE499TG0JKISZŞGPJMESPYJHNVBŞLMLİTJWPGKMFDSLŞI5JKWFKAĞKAĞFJSDĞPFNAERPDSHFKDNVEIPRUPjnakşLhsOHA aeNIHGdoAHNDAdıpAHJECAıopusmIACJDadjAPĞC");
					System.Threading.Thread.Sleep(200);
					Console.ResetColor();
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("BABA 31 ÇIKTI YA W213213PQEĞ34324KDSALD");

				System.Threading.Thread.Sleep(100);
				Console.ResetColor();
				System.Threading.Thread.Sleep(100);
				Console.Write("xD ");
				System.Threading.Thread.Sleep(100);
				Console.Write("xD ");
				System.Threading.Thread.Sleep(100);
				Console.Write("xD ");
				System.Threading.Thread.Sleep(100);
				Console.Write("xD ");
				System.Threading.Thread.Sleep(100);
				Console.Write("xD ");
				System.Threading.Thread.Sleep(100);
				Console.Write("xD ");
				System.Threading.Thread.Sleep(100);
				Console.Write("xD ");
				System.Threading.Thread.Sleep(100);
				Console.Write("xD ");
				Console.Clear();
				}

			}

			Console.WriteLine("\n Yeninden işlem yapmak için 0'a. \n Çıkış yapmak için her hangi bir tuşa basın.");
			Int16 sec2 = Convert.ToInt16(Console.ReadLine());
			Console.ResetColor();

			if (sec2 == 0)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("\n Yeninden yönlendiriliyorsunuz");
				System.Threading.Thread.Sleep(500);
				Console.Write(".");
				System.Threading.Thread.Sleep(200);
				Console.Write(".");
				System.Threading.Thread.Sleep(200);
				Console.Write(".");
				System.Threading.Thread.Sleep(200);
				Console.Write(".");
				System.Threading.Thread.Sleep(200);
				Console.Write(".");
				System.Threading.Thread.Sleep(500);
				Console.Write(".");
				System.Threading.Thread.Sleep(200);
				Console.Write(".");
				System.Threading.Thread.Sleep(200);
				Console.Write(".");
				System.Threading.Thread.Sleep(200);
				Console.Write(".");
				System.Threading.Thread.Sleep(200);
				Console.Write(".");
				Console.ResetColor();
				Console.Clear();
				goto bas;
			}









		}
	}
}
