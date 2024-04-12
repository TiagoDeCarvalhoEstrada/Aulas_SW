using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerFolhaDePagamento
{
    internal class Informacoes
    {
        public string Nome { get; set; }
        public double Sal { get; set; }
        public double HED { get; set; }
        public double HEN { get; set; }
        public double ND { get; set; }
        public double Fal { get; set; }
        public double DE { get; set; }
        public double REF { get; set; }
        public double Val { get; set; }

        public string FL()
        {
            Console.WriteLine("Digite o nome do funcionário");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário");
            Sal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite as horas extras diurnas: ");
            HED = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite as horas extras noturnas: ");
            HEN = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o número de dependentes");
            ND = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o total de faltas em horas: ");
            Fal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite os descontos habituais: ");
            DE = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite os gastos com refeições");
            REF = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o total de vales retirados no mês: ");
            Val = Convert.ToDouble(Console.ReadLine());

            double HoraExtra = HED * Sal / 160 + HEN * 1.2 * Sal / 160;
            double SalF = ND * 0.05 * 1371;
            double SalB = Sal + HoraExtra + SalF;
            double INAMPS = 0.08 * Sal;
            double faltas = Fal * Sal / 160;
            double imposto_de_renda = 0.08 * Sal;
            double DescontoTotal = INAMPS + faltas + REF + Val + DE + imposto_de_renda;

            double SalarioLiquido = SalB - DescontoTotal;

            return $"Nome: {Nome}\nSalário: {Sal}\nHoras Extras: {HoraExtra}\nSalário Família: {SalF}\nSalário Bruto: {SalB} \nSalário Final: {SalarioLiquido} ";

        }
    }
}
