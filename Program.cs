using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Queda_Livre
{
    class Program
    {
        class Passageiro
        {
            private string cpf, telefone;
            private string nome, endereco, horario;
            private int poltrona, voo;
            public Passageiro() //Construtor Para Iniciar as vari�veis
            {
                cpf = "0";
                telefone = "0";
                nome = "Zerado";
                endereco = "Zerado";
                horario = "00:00";
                poltrona = 0;
                voo = 0;
            }// Fim do Construtor
            //Metodos para retornar os valotes
            public string OCPF()
            {
                return (cpf);
            }
            public string ONome()
            {
                return (nome);
            }
            public string OEnd()
            {
                return (endereco);
            }
            public string OHorario()
            {
                return (horario);
            }
            public int OPoltrona()
            {
                return (poltrona);
            }
            public int OVoo()
            {
                return (voo);
            }
            public string OTel()
            {
                return (telefone);
            } // Fim dos metodos para retornar os valores
            public void CadastraCPF(string c)
            {
                cpf = c;
            }
            public void CadastraNome(string no)
            {
                nome = no;
            }
            public void CadastraEnd(string end)
            {
                endereco = end;
            }
            public void CadastraHorario(string h)
            {
                horario = h;
            }
            public void CadastraPoltrona(int p)
            {
                poltrona = p;
            }
            public void CadastraVoo(int v)
            {
                voo = v;
            }
            public void CadastraTel(string tel)
            {
                telefone = tel;
            }
        }

        static void Cadastra(List<Passageiro> voo)
        {
            Passageiro Padrao = new Passageiro();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Write("Informe o numero do CPF: ");
            Padrao.CadastraCPF(Console.ReadLine());
            Console.Write("Informe o nome do passageiro: ");
            Padrao.CadastraNome(Console.ReadLine());
            Console.Write("Informe o endereço: ");
            Padrao.CadastraEnd(Console.ReadLine());
            Console.Write("Informe o horario: ");
            Padrao.CadastraHorario(Console.ReadLine());
            Console.Write("Informe o numero da poltrona: ");
            Padrao.CadastraPoltrona(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Informe o numero do telefone: ");
            Padrao.CadastraTel(Console.ReadLine());
            voo.Add(Padrao);
            Console.ResetColor();
        }

        //listas de voos e espera
        static List<Passageiro> Voo1 = new List<Passageiro>();
        static List<Passageiro> Voo2 = new List<Passageiro>();
        static List<Passageiro> Voo3 = new List<Passageiro>();
        static Queue<Passageiro> FilaEsperaV1 = new Queue<Passageiro>();
        static Queue<Passageiro> FilaEsperaV2 = new Queue<Passageiro>();
        static Queue<Passageiro> FilaEsperaV3 = new Queue<Passageiro>();
        static Passageiro Padrao = new Passageiro();
        // Fim das listas de voos e espera
        static void AbrePrograma()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\t\t     Bem Vindo | Compania Aérea Queda Livre!\n\t\t\t\t Carregando...");
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.Clear();
        }
        static void MenuPrincipal()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("[1] Vizualizar a lista de passageiros:");
            Console.WriteLine("[2] Pesquisar passageiro por CPF:");
            Console.WriteLine("[3] Pesquisar passageiro por nome:");
            Console.WriteLine("[4] Cadastrar passageiro:");
            Console.WriteLine("[5] Excluir passageiro:");
            Console.WriteLine("[6] Consultar a lista de espera:\n");
            Console.WriteLine("[Esc] Sai\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tDigite sua opção:");
            Console.ResetColor();
        }
        static void ImprimeLista(List<Passageiro> Voo)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            if (Voo.Count == 0)
            {
                Console.WriteLine("Nenhum passageiro cadastrado neste voo.");
            }
            else
            {
                foreach (Passageiro reg in Voo)
                {
                    Console.Write("\n\t| CPF: " + reg.OCPF() + "\n");
                    Console.Write("\t| Nome: " + reg.ONome() + "\n");
                    Console.Write("\t| Endereço: " + reg.OEnd() + "\n");
                    Console.Write("\t| Telefone: " + reg.OTel() + "\n");
                    Console.Write("\t| Horario do Voo: " + reg.OHorario() + "\n");
                    Console.Write("\t| Poltrona: " + reg.OPoltrona() + "\n");
                }
            }
            Console.ResetColor();
         }
        static void SubMenu2()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tDigite uma opcao: ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("1-Para o Vôo 1: \n2-Para Vôo 2: \n3-Para Vôo 3: \n4-Para fila de espera: \nESC-Para voltar. ");
            Console.ResetColor();
        }

        static void ImprimeFila(Queue<Passageiro> Voo)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            if (Voo.Count == 0)
            {
                Console.WriteLine("A fila de espera está vazia.");
            }
            else
            {
                foreach (Passageiro reg in Voo)
                {
                    Console.Write("\n\t| CPF: " + reg.OCPF() + "\n");
                    Console.Write("\t| Nome: " + reg.ONome() + "\n");
                    Console.Write("\t| Endereço: " + reg.OEnd() + "\n");
                    Console.Write("\t| Telefone: " + reg.OTel() + "\n");
                    Console.Write("\t| Horario do Voo: " + reg.OHorario() + "\n");
                    Console.Write("\t| Poltrona: " + reg.OPoltrona() + "\n");
                }
            }
            Console.ResetColor();
        }
        static void SubMenu3()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tDigite uma opcao: ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("1-Para o Vôo 1: \n2-Para Vôo 2: \n3-Para Vôo 3: \nESC-Para voltar. ");
            Console.ResetColor();
        }

        static void ProcurarCPF(List<Passageiro> Voo, string numero)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            bool encontrado = false;
            foreach (Passageiro reg in Voo)
            {
                if (reg.OCPF() == numero)
                {
                    Console.Clear();
                    Console.Write("\n\t| CPF: " + reg.OCPF() + "\n");
                    Console.Write("\t| Nome: " + reg.ONome() + "\n");
                    Console.Write("\t| Endereço: " + reg.OEnd() + "\n");
                    Console.Write("\t| Telefone: " + reg.OTel() + "\n");
                    Console.Write("\t| Horario do Voo: " + reg.OHorario() + "\n");
                    Console.Write("\t| Poltrona: " + reg.OPoltrona() + "\n");
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("O passageiro não consta na lista!");
            }
            Console.ResetColor();
        }

        static void ProcurarNome(List<Passageiro> Voo, string no)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            bool encontrado = false;
            foreach (Passageiro reg in Voo)
            {
                if (reg.ONome().Equals(no, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    Console.Write("\n\t| CPF: " + reg.OCPF() + "\n");
                    Console.Write("\t| Nome: " + reg.ONome() + "\n");
                    Console.Write("\t| Endereço: " + reg.OEnd() + "\n");
                    Console.Write("\t| Telefone: " + reg.OTel() + "\n");
                    Console.Write("\t| Horario do Voo: " + reg.OHorario() + "\n");
                    Console.Write("\t| Poltrona: " + reg.OPoltrona() + "\n");
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("O passageiro não consta na lista!");
            }
            Console.ResetColor();
        }

        static void ExcluirPassageiro(List<Passageiro> Voo, Queue<Passageiro> Fila)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite o numero do CPF a ser excluído:");
            Console.ResetColor();
            string cpf = Console.ReadLine();
            Passageiro encontrado = null;
            foreach (Passageiro p in Voo)
            {
                if (p.OCPF() == cpf)
                {
                    encontrado = p;
                    break;
                }
            }
            if (encontrado != null)
            {
                Voo.Remove(encontrado);
                Console.WriteLine("Passageiro removido com sucesso.");
                if (Fila.Count > 0)
                {
                    Passageiro promovido = Fila.Dequeue();
                    Voo.Add(promovido);
                    Console.WriteLine("Um passageiro da fila de espera foi promovido para o voo.");
                }
            }
            else
            {
                Console.WriteLine("Passageiro não encontrado neste voo.");
            }
        }


        static void Main(string[] args)
        {
            Console.Title = "Cia. Aérea Queda Livre";
            AbrePrograma();
            Voo1.Add(Padrao);
            Voo1.Add(Padrao);
            while (true) //inicio do menu
            {
                MenuPrincipal(); // MENU PRINCIPAL
                ConsoleKeyInfo teclado = Console.ReadKey();
                char opcao = Convert.ToChar(teclado.KeyChar);
                if (teclado.Key == ConsoleKey.Escape) // TESTANDO SE O USUARIO QUER SAIR DO PROGRAMA
                {
                    Console.Clear();
                    Console.WriteLine("\t saindo do programa..............");
                    Console.ReadKey();
                    break;
                }
                
                else if (opcao=='1') // CASO ESCOLHA A PRIMEIRA OPÇÃO
                {
                    SubMenu2();
                    teclado = Console.ReadKey();
                    opcao = Convert.ToChar(teclado.KeyChar);
                    if(opcao == '1') // IMPRIME VOO 1
                    {
                        ImprimeLista(Voo1); // IMPRIMINDO A LISTA DO VOO1
                    }
                    else if (opcao == '2') // IMPRIME VOO 2
                    {
                        ImprimeLista(Voo2); // IMPRIMINDO A LISTA DO VOO2
                    }
                    else if (opcao == '3') // IMPRIME VOO 3
                    {
                        ImprimeLista(Voo3);// IMPRIMINDO A LISTA DO VOO3
                    }
                    else if (opcao == '4') // IMPRIME FILA DE ESPERA
                    {
                        SubMenu3(); // SUB MENU PARA FILA DE ESPERA
                        teclado = Console.ReadKey(); // LENDO A TECLA
                        opcao = Convert.ToChar(teclado.KeyChar);
                        if (opcao == '1') // IMPRIME FILA PARA O VOO 1
                        {
                            ImprimeFila(FilaEsperaV1);
                        }
                        else if (opcao == '2') // IMPRIME FILA PARA O VOO 2
                        {
                            ImprimeFila(FilaEsperaV2);
                        }
                        else if (opcao == '3') // IMPRIME FILA PARA O VOO 3
                        {
                            ImprimeFila(FilaEsperaV3);
                        }
                    }
                    Console.ReadKey();
                }
                else if (opcao == '2')
                {
                    Console.Clear();
                    SubMenu3();
                    teclado = Console.ReadKey();
                    opcao = Convert.ToChar(teclado.KeyChar);
                    string pesquisar;
                    if (opcao == '1')
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tDigite o numero do CPF a ser procurado");
                        pesquisar = Console.ReadLine();
                        ProcurarCPF(Voo1, pesquisar);
                        Console.ResetColor();
                    }
                    else if (opcao == '2')
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tDigite o numero do CPF a ser procurado");
                        pesquisar = Console.ReadLine();
                        ProcurarCPF(Voo2, pesquisar);
                        Console.ResetColor();
                    }
                    else if (opcao == '3')
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tDigite o numero do CPF a ser procurado");
                        pesquisar = Console.ReadLine();
                        ProcurarCPF(Voo3, pesquisar);
                        Console.ResetColor();
                    }
                }
                else if (opcao == '3')
                {
                    Console.Clear();
                    SubMenu3();
                    teclado = Console.ReadKey();
                    opcao = Convert.ToChar(teclado.KeyChar);
                    string pes;
                    if (opcao == '1')
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tDigite o nome a ser procurado");
                        pes = Console.ReadLine();
                        ProcurarNome(Voo1, pes);
                        Console.ResetColor();
                    }
                    else if (opcao == '2')
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tDigite o nome a ser procurado");
                        pes = Console.ReadLine();
                        ProcurarNome(Voo2, pes);
                        Console.ResetColor();
                    }
                    else if (opcao == '3')
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tDigite o nome a ser procurado");
                        pes = Console.ReadLine();
                        ProcurarNome(Voo3, pes);
                        Console.ResetColor();
                    }
                }

                else if (opcao == '4') // para cadastrar
                {
                    SubMenu3();
                    teclado = Console.ReadKey();
                    opcao = Convert.ToChar(teclado.KeyChar);
                    if(opcao == '1') 
                        {
                            Cadastra(Voo1); 
                        }
                    else if (opcao == '2')
                        {
                            Cadastra(Voo2);
                        }
                    else if (opcao == '3')
                        {
                            Cadastra(Voo3);
                        }
                    else if (teclado.Key == ConsoleKey.Escape)
                        {
                            // volta ao menu
                        }
                   Console.ResetColor();
                }
                else if (opcao == '5') // excluir passageiro
                {
                    SubMenu3();
                    teclado = Console.ReadKey();
                    opcao = Convert.ToChar(teclado.KeyChar);
                    if (opcao == '1')
                    {
                        ExcluirPassageiro(Voo1, FilaEsperaV1);
                    }
                    else if (opcao == '2')
                    {
                        ExcluirPassageiro(Voo2, FilaEsperaV2);
                    }
                    else if (opcao == '3')
                    {
                        ExcluirPassageiro(Voo3, FilaEsperaV3);
                    }
                    Console.ReadKey();
                }
                else if (opcao == '6') // consultar lista de espera
                {
                    SubMenu3();
                    teclado = Console.ReadKey();
                    opcao = Convert.ToChar(teclado.KeyChar);
                    if (opcao == '1')
                    {
                        ImprimeFila(FilaEsperaV1);
                    }
                    else if (opcao == '2')
                    {
                        ImprimeFila(FilaEsperaV2);
                    }
                    else if (opcao == '3')
                    {
                        ImprimeFila(FilaEsperaV3);
                    }
                    Console.ReadKey();
                }
                Console.Clear();
            }//fim do menu
            Console.ReadKey();
        }
    }
}