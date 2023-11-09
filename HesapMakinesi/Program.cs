

using System.Security.Cryptography.X509Certificates;

Console.WriteLine("1 . adım >> Aklınızdan Bir sayı Tutun 1-10 arasında ( enter tuşlayınız ) ");
string b = Console.ReadLine();
Console.WriteLine("2. adım >> 2 ile çarpınız ( enter tuşlayınız ) ");
string c = Console.ReadLine();
Console.WriteLine("3. adım >> 10 ekleyiniz ( enter tuşlayınız ) ");
string d = Console.ReadLine();
Console.WriteLine("4. adım >> 7 ile çarpınız ( enter tuşlayınız ) ");
string k = Console.ReadLine();
Console.WriteLine("5. adım >> 6 çıkarınız ( enter tuşlayınız )  ");

Console.WriteLine(" Sonucu yazarsanız. Tuttuğunuz sayıyı söylerim :  ");

int a = Int32.Parse(Console.ReadLine());


Console.WriteLine("Tuttuğunuz sayı : " + ((((a + 6) / 7) - 10) / 2)); 

