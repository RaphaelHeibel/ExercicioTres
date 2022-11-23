namespace ExercicioTres
{
    public class Program
    {
        static void Main(string[] args)
        {


            StreamWriter x;
            StreamReader y;

            string Caminho = "C:\\Users\\Rapha\\arq.txt";

            x = File.CreateText(Caminho);

            var input = new char[30];
            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == '0')
                    break;
                input[i] = Console.ReadKey().KeyChar;
            }

            x.Close();

            x = File.AppendText(Caminho);
            foreach (var item in input)
            {
                x.WriteLine(item);
            }
            x.Close();

            y = File.OpenText(Caminho);

            while (y.EndOfStream != true)
            {
                string linha = y.ReadLine();
                Console.WriteLine(linha);
            }

        }
    }
}
