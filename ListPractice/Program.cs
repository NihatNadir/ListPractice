using System;
namespace ListPractice
{
    class Program
    {
        static void Main(string[] args) 
        {
            int sayac = 1; // Listedeki sıra için değişken tanımlama
            List<string> party = new List<string>(); // Listeye eleman ekleme
            party.Add("Bülent Ersoy");
            party.Add("Ajda Pekkan");
            party.Add("Ebru Gündeş");
            party.Add("Hadise");
            party.Add("Hande Yener");
            party.Add("Tarkan");
            party.Add("Funda Arar");
            party.Add("Demet Akalın");

            start:
            Console.WriteLine("Listeye ziyaretçi eklemek için '1' basın.\nDavetliler listesini görüntülemek için '2' basın.");
            string input = Console.ReadLine() ?? "";
            if (input == "1") // Kullanıcı 1 girerse
            {
                name:
                Console.WriteLine("İsmi giriniz.");
                string invite = Console.ReadLine() ?? "";
                if (!party.Contains(invite)) // Eğer kullanıcının girdiği değer listede yoksa davetliler listesine ekleniyor 
                {
                    party.Add(invite);
                    Console.WriteLine("İsim davetliler listesine eklendi.");
                }
                else // Eğer isim daha önce listede varsa hata ile karşılaşılıyor.
                    Console.WriteLine("İsim daha önce listeye eklenmiş");


                Console.WriteLine("Tekrar ziyaretçi eklemek istiyorsan '1' Davetliler listesini görüntülemek istiyorsan '2' basın"); // goto ile isim alma kısmına dönüyor.
                input = Console.ReadLine() ?? "";
                if (input == "1")                              
                    goto name;             

            }

            if (input == "2") // Davetliler listesinin son hali konsol ekranına yazdırılıyor.
            {
                Console.WriteLine("\n** Davetliler **");
                foreach (string part in party)
                {
                    Console.WriteLine($"{sayac} - {part}");      
                    sayac++;
                }
                Console.WriteLine("\nİyi Eğlenceler...");
            }
            else
            {
                Console.WriteLine("Yanlış giriş yaptınız.");
                goto start; // goto ile başa dönüyor.
            }
        }
    }
}
