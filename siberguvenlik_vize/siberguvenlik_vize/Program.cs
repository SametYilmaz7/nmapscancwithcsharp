using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http.Json;
using System.Text.RegularExpressions;


namespace siberguvenlik_vize
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)//konsolda cikis yazılmadığı sürece program devam edecek. 
            {
                //Tarama işleminde kullanılacak ip için kullanıcıdan parametre alıyoruz.
                string ip;
                Console.WriteLine("Cikmak icin 'cikis' yaziniz.");
                Console.Write("Tarama islemi icin lutfen ip adresi ya da araligini girin: ");
                ip = Console.ReadLine();

                if (ip == "cikis") break; //cikis yazılırsa program sonlanıyor.


                //Burada bir process oluşturuyoruz ve nmap.exe uygulamasını çalıştırıyoruz girilecek komutları "Arguments" kısmında belirtiyoruz ve processi başlatıyoruz.
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "nmap.exe";
                startInfo.Arguments = "nmap -T4 -A -v " + ip; //Kullanıcının girdiği ip parametresini burada kullanıyoruz. Bu komut sayesinde uygulamada yazılması gereken komutları yazıyoruz.

                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();//Process işlemi bitene kadar herhangi bir kod çalışmasın diye bu fonksiyonu kullanıyoruz.


                Console.WriteLine("*******************************************************************************************");
                Console.WriteLine("*************************Tarama islemi tamamlandi.*************************");
                Console.WriteLine("*******************************************************************************************");
            }






        }
    }
}