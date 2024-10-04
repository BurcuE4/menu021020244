using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace menu021020244
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Count: Koleksiyonlardaki eleman sayısını döndürür.
            //List: Aynı türdeki verileri tutan ve eleman ekleyip çıkarabildiğimiz koleksiyon veri yapısı.
            //Dictionary: Anahtar - değer çiftlerini tutan koleksiyon veri yapısı.Her anahtar benzersizdir.
            //HashSet: Aynı elemanın birden fazla kez bulunmasına izin vermeyen koleksiyon veri yapısı.
            //Length  Dizilerdeki eleman sayısını öğrenmek için kullanılır.

            #region double değişkenler
            //Console.WriteLine("*****Fiyat Listesi*****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, patatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //patatoPrice = 9.74;
            //tomatoPrice = 6.88;


            //Console.WriteLine("Elmanın Fiyatı :" + applePrice);
            //Console.WriteLine("Portakalın Fiyatı:"+ orangePrice);
            //Console.WriteLine("Çileğin Fiyatı : " + strawberryPrice);
            //Console.WriteLine("Patatesin Fiyatı : " +patatoPrice);
            //Console.WriteLine("Domatesin Fiyatı : " +tomatoPrice);

            //double appleGram, orangeGram, strawberryGram, patatoGram, tomatoGram;

            //Console.WriteLine();

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //patatoGram = 4.859;
            //tomatoGram = 3.745;

            //Console.WriteLine();


            //double appleTotalPrice= appleGram * applePrice;
            //double orangeTotalPrice= orangeGram * orangePrice;
            //double strawberryTotalPrice=strawberryGram * strawberryPrice;
            //double patatoTotalPrice=patatoGram * patatoPrice;
            //double tomatoTotalPrice=tomatoGram * tomatoPrice;

            //Console.WriteLine();



            //Console.WriteLine("Alınan ürün Elma  : " + applePrice + " Alınan ürün gramajı : " + appleGram + " Toplam tutar :"+appleTotalPrice);
            //Console.WriteLine("Alınan ürün Portakal: " + orangePrice + "Alınan ürün gramajı : " + orangeGram + " Toplam tutar :"+ orangeTotalPrice);
            //Console.WriteLine("Alınan ürün Çilek : " + strawberryPrice + "Alınan ürün gramajı : " + strawberryGram + " Toplam tutar :"+ strawberryTotalPrice);
            //Console.WriteLine("Alınan ürün Patates : " + patatoPrice + "Alınan ürün gramajı : " + patatoGram + " Toplam tutar :"+patatoTotalPrice);
            //Console.WriteLine("Alınan ürün Domates : " + tomatoPrice+ "Alınan ürün gramajı : " + tomatoGram + " Toplam tutar :"+ tomatoTotalPrice);

            //double shoppingTotalPrice=appleTotalPrice + orangePrice + strawberryTotalPrice + patatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş tutarı : " + shoppingTotalPrice + "TL");

            #endregion

            #region char değiskenleri

            //şifreleme yaptığımız zaman harfin kendinden sonra gelen 3. harfini alır
            //abcde
            //A.ise d b ise e c ise f gibi

            //char symbol;
            //symbol= 'A';

            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden veri girişleri String değişkenler

            //Console.WriteLine("*****CSharp Hava yolları Yolcu bilgileri *****");
            //Console.WriteLine();

            //string pessengerName, pessengerSurname, pessengerDistrict, pessengerCity, pessengerAge, pessengerIdentityNumber;

            //Console.Write("Yolcu Adı : ");
            //pessengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı :");
            //pessengerSurname = Console.ReadLine();

            //Console.Write("Yolcu İlçe bilgisi :");
            //pessengerDistrict = Console.ReadLine();

            //Console.Write("Yolcu Şehir bilgisi :");
            //pessengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş");
            //pessengerAge = Console.ReadLine();

            //Console.Write("Yolcu Kimlik Bilgisi : ");
            //pessengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-------------------------");
            //Console.WriteLine("Yolcunun Tc kimlik bilgisi :" +pessengerIdentityNumber+ "Yolcu Adı : " +pessengerName+  "Yolcu Soyadı : " +pessengerSurname+ "Yolcunun ilçesi : " +pessengerDistrict+ "/"  +pessengerCity+ "Yolcunun Yaşı :   " +pessengerAge );

            #endregion

            #region Klavyeden Tam sayı girişleri ve Dönüşümler
            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 1200;

            //int shoesCount , computerCount, chairCount, tvCount ;

            //Console.WriteLine("Lütfen aldığınız ayakkabı sayısını giriniz : "); /// string ifade olduğu için dönüştürmemiz gerekir 
            //shoesCount= int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldıınız bilgisayar sayısını giriniz : ");
            //computerCount= int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız sandalye sayısını giriniz : ");
            //chairCount= int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız televizyon sayısını giriniz : ");
            //tvCount= int.Parse(Console.ReadLine());

            //int totalPrice =shoesCount*shoesPrice+computerCount*computerPrice+chairCount*chairPrice+tvCount*tvPrice; //count ile price count adet oluyor prece fiyatı bunaları çarpıyoruz 

            //Console.WriteLine();

            //Console.WriteLine("Toplam ödemeniz gereken fiyat " + totalPrice);

            //Console.ReadKey();

            #endregion

            #region Klavyeden girilen onldalıklı sayı işlemleri ortalama hesaplama

            //double exam1, exam2, exam3, result;

            //Console.WriteLine("Lütfen birinci sınav notunuzu giriniz :");
            //exam1=double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen ikinci sınav notunuzu girinizi : ");
            //exam2 =double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen üçüncü sınav notunuzu giriniz : ");
            //exam3 =double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();

            //Console.WriteLine("Ortalamanız :" + result);

            #endregion

            #region Klavyeden char girişi

            //char gender;
            //Console.WriteLine("Lütfen cinsiyet giriniz :");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Sectiğiniz cinsiyet " + gender);



            #endregion

            Console.ReadKey();

        }
    }
}
