using v27;

Calculator kal = new Calculator();
kal.judul("luas persegi panjang ");
Console.Write("masukkan p : ");
int p = Convert.ToInt16(Console.ReadLine());
Console.Write("masukkan l : ");
int l = Convert.ToInt16(Console.ReadLine());
Console.Write($"luas persegi panjang dengan p :{p} dan l :{l} adalah : ");
Console.WriteLine(kal.kali(p, l));