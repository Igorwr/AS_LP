public class FuncionarioMP : Funcionario
{
    private double salarioHora;
    private double horasTrabalhadas;

    public FuncionarioMP(string nome, int matricula, double salarioHora, double horasTrabalhadas) :base (nome,matricula)
    {
        this.horasTrabalhadas = horasTrabalhadas;
        this.salarioHora = salarioHora;
    }

    public override double CalcularSalario()
    {
        return salarioHora*horasTrabalhadas;
    }
    public double CalcularBonus()
    {
        return CalcularSalario() * 0.05;
    }

    public override void ExibirInformacoes()
    {
        double salario = CalcularSalario();
        double bonus = CalcularBonus();
        double total = salario + bonus;
        Console.WriteLine($"Nome: {nome}\nMatricula: {matricula}\nSalario por hora: {salarioHora}\nHoras trabalhadas: {horasTrabalhadas}\nSalario Diario: {salario}");
    }
}