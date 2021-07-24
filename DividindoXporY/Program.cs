using System;

class Desafio {
    static void Main() {
        Console.WriteLine("Informe a quantidade de pares de valores inteiros (X e Y):");          
        int limit = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < limit; i++) 
        {
            Console.WriteLine("Informe 2 valores:");            
            string[] line = Console.ReadLine().Split(" ");
            double X = double.Parse(line[0]);
            double Y = double.Parse(line[1]);
            if (Y == 0) 
            {
                Console.WriteLine("divisao impossivel");
            } 
            else 
            {
                double divisao = X/Y; // Digite aqui o calculo da divisao
                Console.WriteLine(divisao.ToString("0.0"));
            }
        }
    }
}
