using static System.Console;
Numero x = new Numero(2);
Numero y = new Numero(2);

if(x == y)
{
  WriteLine($"x e y são iguais");
}
else
{
  WriteLine("x e y são diferentes");
}

class Numero
{
    public int N { get; set; }
    public Numero(int n)
    {
        N = n;
    }
}
