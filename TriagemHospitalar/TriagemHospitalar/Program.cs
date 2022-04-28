using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriagemHospitalar
{
    internal class Program
    {
        // Opções do menu
        enum menu { AddPaciente=1, RemovePacient, ListPacient  }
        static void Main(string[] args)
        {
            // Tela inicial do programa (menu)
            
            inicio:
            
            Console.WriteLine("Este programa faz a listagem e gerenciamento de pacientes.");
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1 - Adicionar Paciente \n2 - Remover Paciente \n3 - Listar Todos Pacientes");
            
            // Entrada de opções 
            int index = int.Parse(Console.ReadLine());
            menu option = (menu)index;

            switch (option)
            {
                // Opção para entrada de dados do paciente
                case menu.AddPaciente:
                    Pacient p = new Pacient();
                    string yn;
                    Console.WriteLine("Você optou por adicionar paciente? [s/n]"); // Retorno ao menu 
                    yn = Console.ReadLine();
                    if (yn == "n" || yn == "N") { goto inicio;}
                    else { Console.WriteLine("Vamos criar uma nova ficha então! :)"); }
                   
                    
                    Console.WriteLine("Insira aqui informações do Paciente"); // Criando Paciente               
                    Console.WriteLine("Insira o nome do paciente: "); // nome do paciente
                    p.NamePatient = Console.ReadLine();
                    
                    Console.WriteLine("Insira a data de nascimenito do paciente \n Dia: "); // dia 
                    p.dayOfBirth = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Mês: ");
                    p.monthOfBirth = Convert.ToInt32(Console.ReadLine()); // mes 
                    Console.WriteLine("Ano: ");
                    p.yearOfBirth = Convert.ToInt32(Console.ReadLine()); // ano

                    Console.WriteLine("Descrição do paciente: "); // descrição do paciente
                    p.Description = Console.ReadLine();

                prioridade:
                    int prioridade = 0;
                    Console.WriteLine("Nível de prioridade de atendimento: \n1 - Baixo \n2 - Médio\n3 - Alto");
                    prioridade = Convert.ToInt32(Console.ReadLine());   
                    if (prioridade > 3 ||prioridade < 1)
                        {
                        goto prioridade; 
                        }
                    else
                    {
                        p.Priority = prioridade;
                        p.ShowStats(); // Mostra a ficha
                        Console.ReadKey();
                        
                        goto inicio;
                    }

                   

                case menu.RemovePacient:
                Console.WriteLine("Insira aqui informações do Paciente");
                    Console.ReadKey();
                    break ;

                case menu.ListPacient:
                    
                    string yn1;
                    Console.WriteLine("Você optou por adicionar paciente? [s/n]"); // Retorno ao menu 
                    yn1 = Console.ReadLine();
                    if (yn1 == "n" || yn1 == "N") { goto inicio; }
                    else {Console.WriteLine("Vamos exibir uma lista então! :)");}

                    // Criar lista

                    Console.WriteLine("A lista de pacientes: ");
                    Lista lista = new Lista();
                    lista.ListPacients();
                    Console.ReadKey();

                    
                    break;
            }
            
            
        }
    }

}
