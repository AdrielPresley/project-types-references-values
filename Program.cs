using static System.Console;
 public class Program
 {
	static void values() {

		int a = 2;
 		a = Adicionar10(a);

 		System.Console.WriteLine($"O valor da variável a é {a}");
	  }
	static int Adicionar10(int x)
	  {
	 	return x + 10;
	  }

	static void TrocarNome(People p1, string nomeNovo)
	 {
		p1.Name = nomeNovo;
	 }
	public static void Main ()

	 {
		People p1 = new People();
		p1.Name = "João";
		p1.Age = 25;
		p1.Document = "9879";

		People p2 = p1.Clone();

		TrocarNome(p1, "Jonas");

		System.Console.WriteLine($@"
		O nome de p1 é :{p1.Name}
		O nome de p2 é :{p2.Name}");
	 }
 }