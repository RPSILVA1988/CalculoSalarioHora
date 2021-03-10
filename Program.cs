using System;
using System.Globalization;

namespace CalculoSalarioHora
{
	class Program
	{
		static void Main(string[] args)
		{
			// Seção de Declarações das variáveis
			int matricula, horas;
			double valorHora, salario;

			// Seção de Comandos, procedimento, funções, operadores, etc...
			Console.Write("Digite a matrícula do Funcionário: ");
			matricula = int.Parse(Console.ReadLine());
			Console.Write("Digite quantidade de horas trabalhadas: ");
			horas = int.Parse(Console.ReadLine());
			Console.Write("Digite o valor da hora do Funcionário: ");
			valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			salario = valorHora * horas;
						
			Console.WriteLine("MATRICULA = " + matricula);
			Console.WriteLine("SALARIO = R$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
			
			Console.ReadLine();
		}
	}
}