using System;


namespace Agenda_Telefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda[] contatos = new Agenda[100];
            int i = 0;

            string opcaoEscolha = OpcaoUsuario();


            while (opcaoEscolha != "8")
            {
                switch (opcaoEscolha)
                {

                    case "1":
                        var contato = new Agenda();

                        Console.WriteLine("Digite o primeiro nome do contato: ");
                        contato.PrimeiroNome = Console.ReadLine();

                        Console.WriteLine("Digite o sobrenome do contato: ");
                        contato.Sobrenome = Console.ReadLine();

                        Console.WriteLine("Digite o telefone do contato: ");
                        if(long.TryParse(Console.ReadLine(), out long telefone))
                        {
                            contato.Telefone = telefone;
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

                        Console.WriteLine("Digite o bairro do contato: ");
                        contato.Bairro = Console.ReadLine();

                        Console.WriteLine("Digite a cidade do contato: ");
                        contato.Cidade = Console.ReadLine();

                        Console.WriteLine("Digite o estado do contato: ");
                        contato.Estado = Console.ReadLine();

                        Console.WriteLine("Digite o data de nascimento no formato: dd-MM-aaaa ");
                        contato.Data = Console.ReadLine();

                        Console.WriteLine("Observações: ");
                        contato.Observacoes = Console.ReadLine();

                        contatos[i] = contato;
                        i++;
                        break;



                    case "2":
                        foreach (var info in contatos)
                        {

                            if (!string.IsNullOrEmpty(info.PrimeiroNome))
                            {
                                Console.WriteLine($"Nome: {info.PrimeiroNome} Tipo de Contato: {info.Tipo} Telefone: {info.Telefone} Email: {info.Email}");
                                Console.WriteLine();
                            }


                        }
                        break;


                    default:
                        throw new ArgumentOutOfRangeException();                 
                }

                 opcaoEscolha = OpcaoUsuario();
            }
        }


        private static string OpcaoUsuario()
        {
            Console.Write("Escolha a opção desejada: ");
            Console.WriteLine();
            Console.Write(" 1 - Inserir contato");
            Console.Write(" 2 - Listar contatos");
            Console.Write(" 3 - Buscar contato por nome completo");
            Console.Write(" 4 - Buscar contato por tipo de contato");
            Console.Write(" 5 - Buscar contato por cidade");
            Console.Write(" 6 - Buscar contato por primeiro nome");
            Console.Write(" 7 - Remover contato");
            Console.Write(" 8 - Sair");
            Console.WriteLine();
            string opcaoEscolha = Console.ReadLine();
            return opcaoEscolha;
        }
    }
}
