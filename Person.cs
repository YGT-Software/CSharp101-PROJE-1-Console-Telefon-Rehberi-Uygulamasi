public class Person
{
    string name, surName, number;

    public string Ad { get => name; set => name = value; }
    public string Soyad { get => surName; set => surName = value; }
    public string Numara { get => number; set => number = value; }
    public Person(string name, string surName, string number)//Person nesnesini oluşturduk.
    {
        Ad = name;
        Soyad = surName;
        Numara = number;
    }
}