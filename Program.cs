using System;
using System.Collections.Generic;

namespace sharptodo
{
  class Program
  {
    static string showMenu()
    {
      Console.WriteLine("1. Listar | 2. Agregar | 3. Completar | 4. Salir");
      string menu = Console.ReadLine();
      return menu;
    }

    static void addTarea(List<Task> tareas)
    {
      Console.WriteLine("Ingrese nombre tarea:");
      string desc = Console.ReadLine();
      tareas.Add(new Task(desc));
    }

    static void completeTarea(List<Task> tareas)
    {
      Console.WriteLine("Ingrese numero tarea:");
      string input = Console.ReadLine();
      int index = int.Parse(input) - 1;
      tareas[index].setDone(true);
    }

    static void listarTareas(List<Task> tareas)
    {
      int index = 1;

      foreach (Task tarea in tareas)
      {
        Console.WriteLine(index + ". " + tarea.toText());
        index++;
      }
    }

    static void Main(string[] args)
    {
      List<Task> tareas = new List<Task>();
      bool exit = false;

      do
      {
        string option = showMenu();

        Console.WriteLine();

        switch (option)
        {
          case "1":
            listarTareas(tareas);
            break;

          case "2":
            addTarea(tareas);
            break;

          case "3":
            completeTarea(tareas);
            break;

          default:
            exit = true;
            break;

        }

        Console.WriteLine();
      } while (!exit);
    }
  }
}
