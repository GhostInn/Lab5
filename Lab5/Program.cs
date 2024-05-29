using System;

namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        // Эта строка кода выводит в консоль приглашение для ввода данных.
        Console.Write("Введите 1, если сервер доступен, или 0, если сервер недоступен: ");

        // Здесь считывается строка с консоли и преобразуется в целое число.
        int isConnected = Convert.ToInt32(Console.ReadLine());

        // Эта строка кода преобразует целое число в логическое значение.
        bool boolIsConnected = isConnected == 1 ? true : false;

        // Создать экземпляр класса и запустить метод
        // Здесь создается экземпляр класса AutoUpdate.
        AutoUpdate autoUpdate = new AutoUpdate();

        // Это блок оператора try-catch, который используется для обработки исключений.
        try
        {
            // Здесь вызывается метод GetNewData экземпляра класса AutoUpdate и передается логическое значение.
            autoUpdate.GetNewData(boolIsConnected);
        }

        // Этот блок catch перехватывает исключения типа ServerConnectionException.
        catch (ServerConnectionException ex)
        {
            // Сообщение исключения (свойство Message) вывести в консоль
            // Здесь в консоль выводится сообщение об ошибке, которое содержится в исключении.
            Console.WriteLine(ex.Message);
        }

        // Этот блок catch перехватывает все остальные исключения.
        catch (Exception ex)
        {
            // Для всех остальных возможных в задаче исключений перехватывать Exception
            // Здесь в консоль выводится сообщение об ошибке, которое содержится в исключении.
            Console.WriteLine(ex.Message);
        }

        // Эта строка кода останавливает выполнение программы и ожидает ввода данных с консоли.
        Console.ReadLine();
    }
}