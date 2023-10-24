using System;
using System.Collections.Generic;

class Tarefa
{
    public string Dia { get; set; }
    public string Horario { get; set; }
    public string Descricao { get; set; }
}


class ListaTarefa
{
    static void Main(string[] args)
    {
        string day;
        string task;
        string dayTask;
        string hourTask;
        string okTask;
        string doList;

        List<Tarefa> tarefas = new List<Tarefa>();

        do
        {
            Console.WriteLine("Bem vindo ao Sistema de Lista de Tarefa!");
            Console.WriteLine("Deseja anotar alguma tarefa diaria ou semanal?");
            day = Console.ReadLine().ToLower();
        } while (day != "diaria" && day != "semanal");
        

        if (day == "diaria")
        {
            do
            {
                Console.WriteLine("Digite horário: ");
                hourTask = Console.ReadLine();
                Console.WriteLine("Digite a Tarefa: ");
                task = Console.ReadLine();

                tarefas.Add(new Tarefa { Dia = "Diaria", Horario = hourTask, Descricao = task });

                Console.WriteLine(" ");
                Console.WriteLine("Tarefa: " + task + "\nHorário: " + hourTask);
                Console.WriteLine("Deseja processar as tarefas? (sim/nao)");
                okTask = Console.ReadLine().ToLower();
            } while (okTask == "nao");

            Console.WriteLine("Tarefas processadas");
        }
        else if (day == "semanal")
        {
            do
            {
                Console.WriteLine("Digite o dia da Tarefa: ");
                dayTask = Console.ReadLine();
                Console.WriteLine("Digite o horário da tarefa: ");
                hourTask = Console.ReadLine();
                Console.WriteLine("Digite a tarefa");
                task = Console.ReadLine();

                tarefas.Add(new Tarefa { Dia = dayTask, Horario = hourTask, Descricao = task });

                Console.WriteLine("\nDia: " + dayTask);
                Console.WriteLine("Horário: " + hourTask);
                Console.WriteLine("Tarefa: " + task);


                Console.WriteLine("Deseja processar as tarefas? (sim/nao)");
                okTask = Console.ReadLine().ToLower();
            } while (okTask == "nao");

            Console.WriteLine("Tarefas processadas...");
        }
        else
        {
            Console.WriteLine("Opção inválida. Tente novamente.");
        }

        Console.WriteLine("Gostaria de ver a lista de tarefas? (sim/nao)");
        doList = Console.ReadLine();

        if (doList == "sim")
        {
            Console.WriteLine("Lista de Tarefas:");
            foreach (var tarefa in tarefas)
            {
                Console.WriteLine($"Dia: {tarefa.Dia}, Horario {tarefa.Horario}, Tarefa: {tarefa.Descricao}");
            }
        }
        else
        {
            Console.WriteLine("Finalizando programa");
        }

        
    }
}

