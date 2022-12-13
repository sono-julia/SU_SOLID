//Паттерны
#region Порождающие
/* Singleton - Одиночка
- можно создать только в единственном экземпляре
- т.е. на него только 1 ссылка
- при обращении к нему из разных мест, обращаемся к одному и тому же объекту
- исп. с БД (т.к. она одна) и в многопоточности (как?)
- Из памяти не сотрется, т.к. является Root объектом,
поэтому, чем больше синглтонов, тем больше засоряется память
- Можно исп. для репозиториев
 */
class Singleton
{
    private static Singleton instance;
    //конструктор:
    private Singleton()
    {
    }
    //метод (в нем вся фишка):
    public static Singleton GetInstance()
    {
        //нужно ограничивать доступ к методу других объектов, если что-то уже начало его исп.
        if(instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }
}
//Singleton s = Singleton.GetInstance();

/* Factory - Фабрика
- интерфейс отвечает за один метод
- реализация метода в отдельных кслассах
- доступ к интерфейсу через фабрику
 */
interface ISaver
{
    public bool Save(string s);
}
class PdfSaver : ISaver
{
    public bool Save(string s)
    {
        Console.WriteLine("Сохранен в PDF");
        return true;
    }
}
class ExcelSaver : ISaver
{
    public bool Save(string s)
    {
        Console.WriteLine("Сохранен в Excel");
        return true;
    }
}
class WordSaver : ISaver
{
    public bool Save(string s)
    {
        Console.WriteLine("Сохранен в Word");
        return true;
    }
}
class TextDocumentSaver : ISaver
{
    public bool Save(string s)
    {
        Console.WriteLine("Сохранен в TXT");
        return true;
    }
}
class SaverFactory
{
    public ISaver GetSaver(SaverType type)
    {
        ISaver saver = null;
        switch (type)
        {
            case SaverType.PDF:
                saver = new PdfSaver();
                break;
            case SaverType.EXCEL:
                saver = new ExcelSaver();
                break;
            case SaverType.WORD:
                saver = new WordSaver();
                break;
            case SaverType.TEXT:
                saver = new TextDocumentSaver();
                break;
            default:
                saver = new TextDocumentSaver();
                break;
        }
        return saver;
    }
}
enum SaverType
{
    PDF,
    EXCEL,
    WORD,
    TEXT,
}

//Использование фабрики:
//SaverFactory factory = new SaverFactory();
//ISaver saver = factory.GetSaver(SaverType.PDF);

/* Abstract factory - Абстрактная фабрика
 * Порождает другие фабрики
 * САМОСТОЯТЕЛЬНО
 */

/* Builder - Строитель
 * Пример: https://developer.alexanderklimov.ru/android/library/retrofit.php
 * Объяснение: https://www.youtube.com/watch?v=DX1HTfdA2Jo
 */

/* Prototype - Прототип
 * САМОСТОЯТЕЛЬНО
 */
#endregion





