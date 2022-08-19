namespace Switch_case
{
    class Program
    {

        static void Main(string[] args)
        {
            int mount = DateTime.Now.Month;

            switch (mount) // Parantezin içinde expression yani kontrol etmek istediğim şeyi yazıyoruz. burada ayı kontrol edeceğiz
            {
                case 1 : // Burada 2 nokta üst üste eğer 1 ay ise ne yapacağımı soruyoruz.
                    Console.WriteLine("Ocak ayındasınız");
                    break; 
                case 2 : // Burada 2 nokta üst üste eğer 2 ay ise ne yapacağımı soruyoruz.
                    Console.WriteLine("Şubat ayındasınız");
                    break;
                case 3 : // Burada 2 nokta üst üste eğer 3 ay ise ne yapacağımı soruyoruz.
                    Console.WriteLine("Mart ayındasınız");
                    break;// Bu ifade sorgunun bitmesini gerektiği için yazıyoruz.
                case 8 : // Burada 2 nokta üst üste eğer 1 ay ise ne yapacağımı soruyoruz.
                    Console.WriteLine("Agustos ayındasınız");
                    break;
                default: ;
                    Console.WriteLine("Yanlış veri girişiz!");
                    break;
            }

            switch (mount)// Switchler de şimdi yazdığım gibi kullanmak daha okunaklı yani birden fazla şarkı sağlarsa ne yapması gerektiğini yazıdıyoruz.
            
            {
             
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("kış ayındasınız");
                    break;
                default:
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlk Bahar ayındasınız");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("yaz ayındasınız");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar ayındasınız");
                    break;
            }
        }
    }
    
}

