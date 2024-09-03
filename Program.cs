namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        // Lag en variabel av datatypen integer og tildel den et vilkårlig heltall
        int ranNum = 50;
        Console.WriteLine(ranNum);

        // Lag en variabel av datatypen string og tilden en vilkårlig tekst
        string ranTxt = "Random text is random!";
        Console.WriteLine(ranTxt);

        // Lag en variabel av datatypen double og tilden et vilkårlig tall, både desimal og heltall er gyldig med denne typen
        double ranDbl = 9.99D;
        Console.WriteLine(ranDbl);

        // Lag en variabel av datatypen char og tildel den en vilkårlig karakter(bokstav)
        char k = 'K';
        Console.WriteLine(k);

        // Lag et Array av datatypen integer og skriv ut verdiene med en vanlig for-løkke
        int[] myIntArray = { 1, 2, 3, 4, 5, 6};
        for(int i = 0; i < myIntArray.Length; i++)
        {
            Console.WriteLine(myIntArray[i]);
        }

        // Lag et Array av datatypen string og skriv ut verdiene med en foreach-løkke
        string[] myStringArray = {"Hello", "This", "Is", "Doge"};
        foreach(string myString in myStringArray)
        {
            Console.WriteLine(myString);
        }

        // Lag en List av datatypen string og tildel verdier ved hjelp av List sin innebygde metode "Add()"
        // Legg til flere strings i listen deres
        // Skriv ut verdiene i listen ved hjelp av en foreach-løkke
        List<string> stringList = new List<string>(); 
        stringList.Add("Value One");
        stringList.Add("Value Two");
        stringList.Add("Value Three");

        foreach (string strings in stringList)
        {
            Console.WriteLine(strings);
        }

        // Lag en metode(?) av typen integer som legger sammen to tall, int a og int b
            MyMethod();
            

        // Lag en metode(?) av typen string som skrive ut en liten hilsen til brukeren ved å bruke en parametervariabel.
           MySecondMethod();
      
        }
static void MyMethod()
        {
            int a = 10, b = 20;
            Console.WriteLine(a + b);
        }

static void MySecondMethod()
{
        Console.WriteLine("Write your name:");
        string userName = Console.ReadLine();
        Console.WriteLine("Hello " + userName + ". You are great!");   
}

}


