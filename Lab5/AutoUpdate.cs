namespace Lab5;

public class AutoUpdate
{
    // Этот метод называется "GetNewData" и принимает логический параметр "isConnected".
    public void GetNewData(bool isConnected)
    {
        // Это оператор if-else, который проверяет значение "isConnected".
        if (isConnected)
        {
            // Если "isConnected" равно true, то в консоль выводится сообщение "Данные получены".
            Console.WriteLine("Данные получены");
        }
        else
        {
            // Если "isConnected" равно false, то генерируется исключение "ServerConnectionException" с сообщением "Обрыв связи с сервером".
            throw new ServerConnectionException("Обрыв связи с сервером");
        }
    }
}