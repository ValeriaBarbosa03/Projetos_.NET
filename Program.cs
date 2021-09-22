using System;


namespace Agenda_Telefonica
{
    class Program 
    {
        static void Main(string[] args)
        {
            Contato[] contatos = new Contato[100];
            int i = 0;

            string opcaoEscolha = OpcaoUsuario();
 

            while (opcaoEscolha != "8")
            {
                switch (opcaoEscolha)
                {

                    case "1":
                        var contato = new Contato();

                        Console.WriteLine("Digite o primeiro nome do contato: ");
                        contato.Nome = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Digite o sobrenome do contato: ");
                        contato.Sobrenome = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Digite o telefone do contato: ");
                        if(long.TryParse(Console.ReadLine(), out long telefone))
                        {
                            contato.Telefone = telefone;
                            Console.WriteLine();
                        }

                        Console.WriteLine("Digite o tipo do contato: ");
                        foreach (var item in Enum.GetValues(typeof(TipodeContato)))
                        {
                            Console.WriteLine(item);
                            Console.WriteLine();

                        }
                        contato.Tipo = Console.ReadLine();
                      

                        Console.WriteLine("Digite o email do contato: ");
                        contato.Email = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Digite o bairro do contato: ");
                        contato.Bairro = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Digite a cidade do contato: ");
                        contato.Cidade = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Digite o estado do contato: ");
                        contato.Estado = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Observações: ");
                        contato.Observacoes = Console.ReadLine();
                        Console.WriteLine();

                        contatos[i] = contato;
                        i++;
                        break;



                    case "2":
                        var aniversario = new Program();

                        foreach (var info in contatos)
                        {

                            if (!string.IsNullOrEmpty(info.Nome))
                            {
                                Console.WriteLine($"Nome: {info.Nome} Tipo de Contato: {info.Tipo} Telefone: {info.Telefone} Email: {info.Email}");
                                Console.WriteLine(); 
                                
                            }
                        }
                        Console.WriteLine($"Faltam {aniversario.DiasParaAniversario()} dias para o aniversario");
                        Console.WriteLine();

                        break;

                    case "3":

                        BuscarNome("Maria", contatos);
      
                        break;
                        
                    case "4":
                        BuscaNomeCompleto("", "", contatos);

                            break;
                    case "5":
                        BuscaCidade("", contatos);
                        break;

                    case "6":
                        BuscaPorTipoDeContato("Celular", contatos);
                        break;
                    case "7":
                         RemoverContato(1, contatos);

                        break;

                    default:
                        throw new ArgumentOutOfRangeException();                 
                }

                 opcaoEscolha = OpcaoUsuario();
            }
        }

        private int DiasParaAniversario()
        {
            DateTime dataAniversario = new DateTime(DateTime.Today.Year, 08, 24);
            DateTime mes = new DateTime(DateTime.Today.Month);
            return (int) dataAniversario.Subtract(DateTime.Today).TotalDays;

        }

        private static int  RemoverContato(int i, Contato[] contatos)
        {
            foreach (var remover_contato in contatos)
            {
                    contatos[i]= remover_contato;
                    
            }
            Console.WriteLine("Contato removido");
            Console.WriteLine();

            return i;
        }

        private static void BuscaPorTipoDeContato(string tipoContato, Contato[] contatos)
        {
            foreach (var tipo_contato in contatos)
            {
                if (tipo_contato.Tipo == tipoContato)
                {
                    Console.WriteLine($"Nome: {tipo_contato.Nome} Tipo de Contato: {tipo_contato.Tipo} Telefone: {tipo_contato.Telefone} Email: {tipo_contato.Email}");
                    Console.WriteLine();
                }
            }
        }

        private static string BuscaCidade(string cidade, Contato[] contatos)
        {
            foreach (var busca_cidade in contatos)
            {
                if (busca_cidade.Cidade == cidade)
                { 
                    Console.WriteLine($"Nome: {busca_cidade.Nome} Tipo de Contato: {busca_cidade.Tipo} Cidade: {busca_cidade.Cidade} Telefone: {busca_cidade.Telefone} Email: {busca_cidade.Email}");
                    Console.WriteLine();
                }
            }
            return cidade;
        }

        private static string BuscaNomeCompleto(string nome, string sobrenome, Contato[] contatos)
        {
                foreach (var n_completo in contatos)
                {
                    if(n_completo.Nome == nome && n_completo.Sobrenome == sobrenome)
                {
                    Console.WriteLine($"Nome: {n_completo.Nome} Sobrenome: {n_completo.Sobrenome} Tipo de Contato: {n_completo.Tipo} Telefone: {n_completo.Telefone} Email: {n_completo.Email}");
                    Console.WriteLine();
                }
            }
            return sobrenome;
           
        }

        private static string BuscarNome(string nome, Contato[] contatos)
        {
            foreach (var c_nome in contatos)
            {
                if (c_nome.Nome == nome)
                {
                    Console.WriteLine($"Nome: {c_nome.Nome} Tipo de Contato: {c_nome.Tipo} Telefone: {c_nome.Telefone} Email: {c_nome.Email}");
                    Console.WriteLine();


                }
            }
            return nome;
        }
        private static string OpcaoUsuario()
        {
            Console.WriteLine("Escolha a opção desejada: ");
            Console.WriteLine();
            Console.WriteLine(" 1 - Inserir contato");
            Console.WriteLine(" 2 - Listar contatos");
            Console.WriteLine(" 3 - Buscar contato por primeiro nome" );
            Console.WriteLine(" 4 - Buscar contato por  nome completo");
            Console.WriteLine(" 5 - Buscar contato por cidade");
            Console.WriteLine(" 6 - Buscar contato por tipo de contato ");
            Console.WriteLine(" 7 - Remover contato");
            Console.WriteLine(" 8 - Sair");
            Console.WriteLine();
            string opcaoEscolha = Console.ReadLine();
            return opcaoEscolha;
        }
    }
}
