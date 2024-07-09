
#nullable disable
public class Program
{
    static void Main(string[] args)
    {
        Empresa empresa = new Empresa();

        Console.WriteLine("Qual é o seu nome?");
        string usuario = Console.ReadLine();

        while(true)
        {
            
            
            Console.WriteLine($"Seja Bem-vindo {usuario} esse é o seu menu: ");
            Console.WriteLine("1 - Adicionar funcionário de tempo integral");
            Console.WriteLine("2 - Adicionar funcionário de meio período");
            Console.WriteLine("3 - Remover funcionario");
            Console.WriteLine("4 - Exibir informações de todos os funcionários");
            Console.WriteLine("5 - Adicionar projeto(s) a um funcionário");
            Console.WriteLine("6 - Sair do programa");
            Console.Write("Digite a opção desejada: ");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o nome do funcionário que vai trabalhar em tempo integral: ");
                    string nomeIntegral = Console.ReadLine();
                    Console.Write("Digite a matrícula desse funcionário: ");
                    int matriculaIntegral = int.Parse(Console.ReadLine());
                    Console.Write("Digite o salário mensal do funcionário: ");
                    double salarioMensalIntegral = double.Parse(Console.ReadLine());

                    FuncionarioTI funcionarioIntegral = new FuncionarioTI(nomeIntegral, matriculaIntegral, salarioMensalIntegral);
                    empresa.AdicionarFuncionario(funcionarioIntegral);
                    Console.WriteLine("Funcionário adicionado com sucesso!");
                    break;

                case 2:
                    Console.WriteLine("Digite o nome do funcionario que vai trabalhar em meio periodo");
                    string nomeMP = Console.ReadLine();
                    Console.WriteLine("Digite a matrícula desse funcionário: ");
                    int matriculaMP = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor que o funcionario vai receber por hora: ");
                    double valorHoraMP = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a quantidade de horas que o funcionario vai trabalhar por dia: ");
                    int horasTrabalhadaMP = int.Parse(Console.ReadLine());
                    
                    FuncionarioMP funcionarioMP = new FuncionarioMP(nomeMP, matriculaMP,valorHoraMP,horasTrabalhadaMP);
                    empresa.AdicionarFuncionario(funcionarioMP);
                    Console.WriteLine("Funcionario adicionado com sucesso!");
                    break;

                case 3:
                    Console.WriteLine("Digite o nome do funcionario que deseja remover: ");
                    int matriculaRemover = int.Parse(Console.ReadLine());
                    empresa.RemoverFuncionario(matriculaRemover);
                    break;

                case 4:
                    Console.WriteLine("Essas são as informações de todos os funcionarios: ");
                    empresa.ExibirFuncionarios();
                    break;

                case 5:
                    Console.WriteLine("Digite o numero de matricula do funcionario");
                    int matriculaProjeto = int.Parse(Console.ReadLine());

                    Funcionario funcionarioEncontrado = empresa.EncontrarFuncPorMatri(matriculaProjeto);
                    if (funcionarioEncontrado != null)
                    {
                        Console.WriteLine("Digite o nome do projeto que vai ser adicionado para o funcionario: ");
                        string nomeProjeto = Console.ReadLine();

                        funcionarioEncontrado.AdicionarProjeto(nomeProjeto);
                        Console.WriteLine($"O projeto {nomeProjeto} foi adicionado com sucesso para o funcionario {funcionarioEncontrado.nome}");
                    }
                    else
                    {
                        Console.WriteLine("Funcionario não foi encontrado, verifique a matricula informada.");
                    }
                    break;
                case 6:
                    Console.WriteLine("Programa encerrado!");
                    return;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;


                    
            
            }
        }
    }
}