namespace Lab5;

public class AutoUpdate
{
    public void GetNewData(bool isConnected)
    {
        if (isConnected)
        {
            Console.WriteLine("Данные получены");
        }
        else
        {
            throw new ServerConnectionException("Обрыв связи с сервером");
        }
    }
}
