using task3;

public class Program
{
    public static void Main(string[] args)
    {
        const string proKey    = "1234567890";
        const string expertKey = "0987654321";
        
        Console.WriteLine("Введите ключ активации Pro или Expert версии");
        Console.WriteLine("Для использования обычной версии нажмите Enter");

        string? key = Console.ReadLine();

        if (key == proKey)
        {
            DocumentWorker pro = new ProDocumentWorker();
            Console.WriteLine("Вас приветствует Pro-версия DocumentWorker");
        }
        else if (key == expertKey)
        {
            DocumentWorker exp = new ExpertDocumentWorker();
            Console.WriteLine("Вас приветствует Expert-версия DocumentWorker");
            exp.SaveDocument();
        }
        else
        {
            DocumentWorker common = new DocumentWorker();
            Console.WriteLine("Вас приветствует обычная версия DocumentWorker");
        }
    }
}