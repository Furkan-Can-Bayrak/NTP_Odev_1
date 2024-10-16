using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamAsmaca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Şehirleri diziye koyuyoruz
            string[] sehirler = {
                        "ADANA", "ADIYAMAN", "AFYONKARAHİSAR", "AĞRI", "AMASYA", "ANKARA",
            "ANTALYA", "ARTVİN", "AYDIN", "BALIKESİR", "BİLECİK", "BİNGÖL",
            "BİTLİS", "BOLU", "BURDUR", "BURSA", "ÇANAKKALE", "ÇANKIRI",
            "ÇORUM", "DENİZLİ", "DİYARBAKIR", "EDİRNE", "ELAZIĞ", "ERZİNCAN",
            "ERZURUM", "ESKİŞEHİR", "GAZİANTEP", "GİRESUN", "GÜMÜŞHANE", "HAKKARİ",
            "HATAY", "IĞDIR", "ISPARTA", "İSTANBUL", "İZMİR", "KAHRAMANMARAŞ",
            "KARABÜK", "KARS", "KASTAMONU", "KAYSERİ", "KIRKLARELİ", "KIRŞEHİR",
            "KOCAELİ", "KONYA", "MALATYA", "MANİSA", "MARDİN", "MERSİN",
            "MUĞLA", "NEVŞEHİR", "NİĞDE", "ORDU", "OSMANİYE", "RİZE",
            "Sakarya", "SAMSUN", "SİİRT", "SİNOP", "SİVAS", "TEKİRDAĞ",
            "TOKAT", "TRABZON", "TUNCELİ", "UŞAK", "VAN", "YALOVA",
            "YOZGAT", "ZONGULDAK"
        };
            //Random sınıfından bir nesne alıyoruz
            Random random = new Random();

            //10 olursa oyun bitmesi için cevap hakkı değişkenini 0dan başlatıyoruz
            int yanlisCevapHakki = 0;
            //Rastgele bir şehir seçiyoruz
            string city = sehirler[random.Next(sehirler.Length)];
            //Oyun bittiğini belirten değişken
            bool isFinished = false;
            //Alfabeyi bir listeye yazdırıyoruz böylelikle bir dinamiklik sağlıyoruz
            List<char> harfler = new List<char>
        {
            'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H',
            'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P',
            'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z'
        };

            //Kişinin oynu kazanıp kazanmadığını anlayabilmemiz için bir değişken
            bool isWin = false;
            //Kişinin girdiği harf doğruysa hafızada tutabilmek için bir listeye atıyoruz. Alacağımız harf sayısı değişken olduğu için dizi yerine bu dinamikliği sağlayabilecek olan listeleri kullanıyoruz
            List<char> girilenDogruHarfler = new List<char>();
            
            //Oyunu başlatan döngü
            while (!isFinished)
            {
                
                Console.WriteLine("-----Kullanılabilecek Harfler-----");
                Console.WriteLine(string.Join(", ", harfler));      //Harflerin arasına virgül koyuyor
                Console.WriteLine("-----Kullanılabilecek Harfler-----");
                Console.Write("Büyük Harf Girin: ");
                char girilenHarf = Convert.ToChar(Console.ReadLine());      //Girilen harfi alıyor  
                
                //Eğer harfi içeriyorsa girilenDoğruHarfler listesine ekliyoruz ve harfler listesinden kaldırıyo
                if (city.Contains(girilenHarf))
                {
                    girilenDogruHarfler.Add(girilenHarf);
                    harfler.Remove(girilenHarf);
                }
                else        //Eğer harfi içermiyorsa harfler listesinden kaldırıp yanlış cevap hakkını bir arttırıyoruz
                {
                    harfler.Remove(girilenHarf);
                    yanlisCevapHakki++;
                    if (yanlisCevapHakki == 10)     //Eğer yanlış cevap hakkı 10 olmuşsa oyun biter ve kaybedersiniz
                    {
                        isWin = false;
                        isFinished = true;
                        break;
                    }
                    Console.WriteLine("Yanlış Cevap Hakkı:  "+ yanlisCevapHakki+"/10");
                }
                Console.WriteLine();
                Console.Write("Cevap: ");
                int sehrinKelimeUzunlugu = city.Length;     //Şehrin kelime uzunluğunu alıyoruz
                int sayac = 0;                              //şehrin kelimeleri ile tam örtüşüyor mu diye sayaç değişkeni yaptık
                foreach (char harf in city)     //String kelimenin içerisindeki tüm harfleri char olarak alır ve döngüye sokar
                {
                
                    if (girilenDogruHarfler.Contains(harf)) //Eğer harf varsa harfi yazar yoksa _ yazar
                    {
                        Console.Write(harf);
                        sayac++;
                        if (sayac==sehrinKelimeUzunlugu) //Harf ile sayaç uyuşursa oyun kazanılır
                        {
                            isFinished = true;
                            isWin = true;
                        }
                    }
                    else
                    {
                        Console.Write("_");
                       
                    }
                  
                }
                Console.WriteLine();




            }

            if(isWin)       //Oyun kazanılmış ise tebrik eder kaybedilmişse başka sefere der
            {
                Console.WriteLine("!!TEBRİKLER KAZANDINIZ!!");
            }
            else
            {
                Console.WriteLine("!!KAYBETTİNİZ BAŞKA SEFERE!!");
                Console.WriteLine("Doğru Cevap: " + city);
            }
            Console.ReadLine();



        }
    }
}
