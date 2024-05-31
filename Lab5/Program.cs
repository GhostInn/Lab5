using System;

namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите 1, если сервер доступен, или 0, если сервер недоступен: ");

        int isConnected = Convert.ToInt32(Console.ReadLine());

        bool boolIsConnected = isConnected == 1;
        
        AutoUpdate autoUpdate = new AutoUpdate();

        try
        {
            autoUpdate.GetNewData(boolIsConnected);
        }

        catch (ServerConnectionException ex)
        {
            Console.WriteLine(ex.Message);
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadLine();
    }
}
