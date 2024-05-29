namespace Lab5;

public class ServerConnectionException : Exception
{
    // Этот конструктор вызывает конструктор базового класса с указанным сообщением об ошибке.
    public ServerConnectionException(string message) : base(message)
    {
    }
}