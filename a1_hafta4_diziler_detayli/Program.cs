using System;

namespace a1_hafta4_diziler_detayli
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi =new int[5];
            int[] dizi2 ={5,4,3,2};
            string [] dizi3={"Bilgisayar","Yazılım","Adli Bilişim","UOLP" };
             // for loop kullanarak dizinin elemanlarını klavyeden girdiriyoruz.
            for(int i = 0; i < dizi.Length; i++)
               {
                   Console.WriteLine("Dizi değerini giriniz. ");
                   dizi[i] = Convert.ToInt32(Console.ReadLine());
               }
            
            Console.WriteLine();
            /// Dizinin değerlerini ekrana yazdırma
            foreach (int eleman in dizi)
             {
              
                Console.Write(eleman+" ");
            }
            
            int[,] dizi4 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            int[,] dizi5 = new int[2, 3];
            dizi5[0, 2] = 4; //// 0 satır 2 indisli sutuna 4'ü ata 
            Console.WriteLine(dizi5.GetLength(0));      //// dizinin boyutunu verir (iki boyutlu dizilerde sutunu verir..
            Console.WriteLine(dizi5.GetUpperBound(0));  //// dizideki indisli son değeri verir.
            Console.WriteLine(dizi5.Rank);              ///// sutun sayısı
            Console.WriteLine(dizi.GetValue(2));        /// dizi[2] gösterir
            dizi2.SetValue(20, 1);                     //dizi2' nin 20. indexine 1 değerini atama
            Console.WriteLine(dizi2[1]);               // ekrana yazdırma
            Console.ReadKey();

        }
    }
}
