using System;
namespace ListPractice
{
    class Program
    {
        static void Main(string[] args) 
        {
            int sayac = 1;
            List<string> party = new List<string>();
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
            if (input == "1")
            {
                name:
                Console.WriteLine("İsmi giriniz.");
                string invite = Console.ReadLine() ?? "";
                party.Add(invite);
                Console.WriteLine("İsim davetliler listesine eklendi.");
                Console.WriteLine("Tekrar ziyaretçi eklemek istiyorsan '1' Davetliler listesini görüntülemek istiyorsan '2' basın");
                input = Console.ReadLine() ?? "";
                if (input == "1")                              
                    goto name;
                Console.WriteLine(input);

            }

            if (input == "2")
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
                goto start;
            }
        }
    }
}