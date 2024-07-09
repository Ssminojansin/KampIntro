internal class Program
{
    private static void Main(string[] args)
    {
        //contr+k , control+c komple seçileni yorum satırına alır. Geri almak için control + k , control + u
        
        //string[] isimler = new string[]
        //{
        //    "Coskun" , "Barıs" , "Büsra" , "Nihal"
        //};
        //Console.WriteLine(isimler[0]);
        //Console.WriteLine(isimler[1]);
        //Console.WriteLine(isimler[2]);
        //Console.WriteLine(isimler[3]);
        ////Bambaşka bir dizi oldu. Dizileri genişletemiyoruz. Gerçek hayatta dizilerle çalışmak eklemek zordur. Koleksiyonlar bunun için varlar.
        //isimler = new string[5]; 
        //isimler[4] = "Mehmet";
        //Console.WriteLine(isimler[4]);

        //----------------------------Koleksiyonlarrrrrr-----------------------------------

        List<string> isimler2 = new List<string> {"Coskun", "Baris", "Büsra", "Nihal" };
        Console.WriteLine(isimler2[0]);
        Console.WriteLine(isimler2[1]);
        Console.WriteLine(isimler2[2]);
        Console.WriteLine(isimler2[3]);

        isimler2.Add("Mehmet");
        Console.WriteLine(isimler2[4]);
        Console.WriteLine(isimler2[0]);









    }
}