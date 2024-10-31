
using System.Runtime.Intrinsics;

int opcao; 
VeiculoDAO vDAO = new VeiculoDAO();
do
{
    Console.Clear();

    Console.WriteLine("--- LISTA DE VEICULOS ---");
    Console.WriteLine("Digite [1] para Cadastrar Veículos");
    Console.WriteLine("Digite [2] para Listar os Veículos");
    Console.WriteLine("Digite [3] para Excluir Veículos");
    Console.WriteLine("Digite [4] para Consultar Veículos");
    Console.WriteLine("Digite [0] para Sair...");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            {
                Console.Clear();
                Console.WriteLine("--- CADASTRAR VEICULO ---\n");

                
                Console.Write("Informe a placa: ");
                string placa = Console.ReadLine();

                Console.Write("Número do Motor: ");
                string nMotor = Console.ReadLine();

                Console.Write("Número do NIV: ");
                string niv = Console.ReadLine();

                Console.Write("Número do Renavam: ");
                string renavan = Console.ReadLine();

                Console.Write("Modelo: ");
                string modelo = Console.ReadLine();

                Console.Write("Marca: ");
                string marca = Console.ReadLine();

                Veiculo v1 = new Veiculo(placa, nMotor, niv, renavan, modelo, marca);
                vDAO.Cadastrar(v1);
               
                break;
            }

        case 2:
            {
                Console.Clear();

                Console.WriteLine("--- LISTA DE VEICULOS ---\n");

                List<Veiculo> veiculos = vDAO.ListarTodos();
                foreach (Veiculo v in veiculos)
                {
                    Console.WriteLine($"Placa: {v.placa}");
                    Console.WriteLine($"Nº Motor: {v.nMotor}");
                    Console.WriteLine($"NIV: {v.niv}");
                    Console.WriteLine($"Renavam: {v.renavam}");
                    Console.WriteLine($"Modelo: {v.modelo}");
                    Console.WriteLine($"Marca: {v.marca}");
                    Console.WriteLine();
                }
                Console.ReadKey();
                break;
            }

        case 3:
            {
                Console.Clear();

                Console.WriteLine("--- EXCLUIR VEICULOS ---\n");
                Console.Write("Digite a placa do Veículo: ");
                string placa = Console.ReadLine();

                vDAO.Excluir(placa);

                break;
            }

        case 4:
            {
                Console.Clear();
                Console.WriteLine("--- CONSULTAR VEICULOS ---\n");
                
                Console.Write("Digite a placa do Veículo: \n");
                string placa = Console.ReadLine();

                Veiculo vplaca = vDAO.Consultar(placa);

                Console.WriteLine($"Placa: {vplaca.placa}");
                Console.WriteLine($"Nº Motor: {vplaca.nMotor}");
                Console.WriteLine($"NIV: {vplaca.niv}");
                Console.WriteLine($"Renavam: {vplaca.renavam}");
                Console.WriteLine($"Modelo: {vplaca.modelo}");
                Console.WriteLine($"Marca: {vplaca.marca}");
               

                Console.ReadKey();
                break;
            }

        case 0:
            {
                Console.WriteLine("Obrigado pela interação!");
                Console.ReadKey();
                break;
            }

        default:
            break;
    }

} while (opcao != 0);