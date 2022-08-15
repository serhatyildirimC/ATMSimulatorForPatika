using Business;
using Data;
using Entities;

Console.WriteLine("Hoşgeldiniz id giriniz:");
int id = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Şifre giriniz:");
string password = Console.ReadLine();
AcountController acountController = new AcountController();
InMemory inMemory = new InMemory();
bool a = acountController.Controller(id, password);
if (a == true)
{
    Console.WriteLine("giriş onaylandı hoşgeldiniz");
    Console.WriteLine("Yapmak istediğiniz işlemi seçiniz \npara yatırma için 1 \npara çekme için 2");
    int i = Convert.ToInt32(Console.ReadLine());
    if (i == 1)
    {
        Console.WriteLine("yatırmak istediğiniz tutarı giriniz");
        int tutar = Convert.ToInt32(Console.ReadLine());

        User user = inMemory.Get(id);
        int total = user.Balance + tutar;
        Console.WriteLine("işlem başarılı yeni bakiyeniz = "+total );
        inMemory.UpdateBalance(id, total);
    }
    if (i == 2)
    {
        Console.WriteLine("çekmek istediğiniz tutarı giriniz :");
        int tutar = Convert.ToInt32(Console.ReadLine());
        User user = inMemory.Get(id);
        if( tutar < user.Balance)
        {
            int total = user.Balance - tutar;
            Console.WriteLine( "işlem başarılı yeni bakiye : "+total );
            inMemory.UpdateBalance(id, total);
        }
        if (tutar > user.Balance)
        {
 
            Console.WriteLine("Bakiyeniz yetersiz");
        }

    }

}