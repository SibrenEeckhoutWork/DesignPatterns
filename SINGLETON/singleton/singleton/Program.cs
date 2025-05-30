using singleton;

Singleton s1 = Singleton.Instance;
Singleton s2 = Singleton.Instance;

// Controleer of beide referenties naar hetzelfde object verwijzen
if (s1 == s2)
{
    Console.WriteLine("Both instances are the same.");
}

// Aanroepen van een methode van de singleton
s1.DoSomething();

