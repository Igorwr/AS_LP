public class FuncionarioTI : Funcionario, IBonus
{
    private double salariomensal;
    public FuncionarioTI (string nome, int matricula, double salariomensal) :base(nome, matricula)
    {
        this.salariomensal = salariomensal;
    }
    public override double CalcularSalario()
    {
        return salariomensal;
    }

    public double CalcularBonus()
    {
        return salariomensal * 0.10;
    }
    public override void ExibirInformacoes()
    {
        double salario = CalcularSalario();
        double bonus = CalcularBonus();
        double total = salario + bonus;
        Console.WriteLine($"O nome do funcionário: {nome}\nO numero de matricula:{matricula}\nSalario Mensal: {salariomensal}");
    }
    
}