public class Directories
{
    public static List<Person> directory = new List<Person>();//Person nesnesini alan bir liste oluşturduk.
    public void Directory()//Directory fonksiyonunu oluşturduk.
    {
        Menu actions = new Menu();//Menu'den bir instance oluşturduk.
        directory.Add(new Person("Aliş", "Veliş", "01234567890"));//directory listesine Person ekledik.
        directory.Add(new Person("Muriş", "Keniş", "01234567890"));
        directory.Add(new Person("Cemiş", "Mehmiş", "01234567890"));
        directory.Add(new Person("Muhiş", "Hakiş", "01234567890"));
        directory.Add(new Person("Kemiş", "Rabiş", "01234567890"));
        actions.Menu1(ref directory);//Menu1 fonksiyonunu directory referansı ile kullandık.
    }
}