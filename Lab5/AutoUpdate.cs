namespace Lab5;

public class AutoUpdate
{
    // Создание метода "Получить новые данные" с логическим параметром
    // Этот метод называется "GetNewData" и принимает логический параметр "isConnected".
    public void GetNewData(bool isConnected)
    {
        // Это оператор if-else, который проверяет значение "isConnected".
        if (isConnected)
        {
            // Вывести сообщение "Данные получены" если параметр – истина
            // Если "isConnected" равно true, то в консоль выводится сообщение "Данные получены".
            Console.WriteLine("Данные получены");
        }
        else
        {
            // Запустить исключение "Обрыв связи с сервером"
            // Если "isConnected" равно false, то генерируется исключение "ServerConnectionException" с сообщением "Обрыв связи с сервером".
            throw new ServerConnectionException("Обрыв связи с сервером");
        }
    }
}