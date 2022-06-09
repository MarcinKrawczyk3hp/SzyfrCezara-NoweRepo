string wpisz, wypisz;
char[] litery = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

Console.WriteLine("Wektor przesunięcia = ");
int c = int.Parse(Console.ReadLine());

Console.WriteLine("Szyfr Cezara");
Console.WriteLine("Podaj co ma być zaszyfrowane");

wpisz = Convert.ToString(Console.ReadLine());
char[] z = wpisz.ToCharArray();

char[] x = new char[z.Length];

for (int i = 0; i < z.Length; i++)
{
    char litera = z[i];

    if (z[i] == ' ' || z[i] == ' ') continue;
    int a = Array.IndexOf(litery, litera);
    int nowaPozycja = (a + c);
    char szyfr;
    if(nowaPozycja >= 23)
    {
        szyfr = litery[nowaPozycja - 26];
    }
    else
    {
        szyfr = litery[nowaPozycja];
    }
    
    x[i] = szyfr;
}

wypisz = string.Join(" ", x);
Console.WriteLine(wypisz);