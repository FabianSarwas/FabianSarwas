using System;
using System.ComponentModel.Design.Serialization;

class Program
{
    static void Main()
    {
        level1();
        level2();
        level3();
        level4();
        level5();
    }

    static void level1()
    {
        // 1. Hallo Welt
        Console.WriteLine("Hallo Welt!");

        // 2. Persönliche Begrüßung
        Console.WriteLine("Hallo, mein Name ist Tom!");

        // 3. Mehrere Zeilen
        Console.WriteLine("Ich lerne C#.");
        Console.WriteLine("Das macht Spaß!");
        Console.WriteLine("Bald kann ich programmieren!");

        // 4. Zahlen ausgeben
        Console.WriteLine("1");
        Console.WriteLine("2");
        Console.WriteLine("3");
        Console.WriteLine("4");
        Console.WriteLine("5");

        // 5. Rechnung ausgeben
        Console.WriteLine("5 + 3 = 8");

        // 6. ASCII-Kunst
        Console.WriteLine("  _____  ");
        Console.WriteLine(" ( o o ) ");
        Console.WriteLine("  \\_^_/  ");

        // 7. Zitat
        Console.WriteLine("\"Der einzige Weg, großartige Arbeit zu leisten, ist zu lieben, was man tut.\" - Steve Jobs");

        // 8. Formular
        Console.WriteLine("Name: Tom Neumann");
        Console.WriteLine("Alter: 25");
        Console.WriteLine("Wohnort: Berlin");

        // 9. Leerzeilen (Abstände)
        Console.WriteLine();
        Console.WriteLine("Dies ist eine Zeile mit Leerzeile darüber.");
        Console.WriteLine();
        Console.WriteLine("Und noch eine Leerzeile hier.");

        // 10. Kommentare (Beispiel unten)
        // Dies ist ein Kommentar, der vom Compiler ignoriert wird.
        // Console.WriteLine gibt Text auf der Konsole aus.
        // Mit WriteLine() wird automatisch ein Zeilenumbruch gemacht.


    }

    // Level 2: Variablen & Datentypen (11-20)

    static void level2()
    {
        //11. Integer-Variable: Erstelle eine Variable für dein Alter und gib sie aus.
        int alter = 34;
        Console.WriteLine("Alter: " + alter);

        //12. String-Variable: Speichere deinen Namen in einer Variable und gib ihn aus.

        string name = "Fabi";
        Console.WriteLine("Name: " + name);

        //13. Mehrere Variablen: Erstelle Variablen für Name, Alter und Stadt und gib alle aus.


        string stadt = "Berlin";

        Console.WriteLine("Name: " + name + ", Alter: " + alter + ", Stadt: " + stadt);

        //14. Rechnen mit Variablen: Erstelle zwei Zahlen-Variablen und gib ihre Summe aus.

        int a = 1;
        int b = 2;

        Console.WriteLine("Die Summe lautet: " + (a + b));

        //15. Variablen ändern: Erstelle eine Variable, weise ihr einen Wert zu, ändere den Wert und gib beide Werte aus.

        int punktzahl = 50;
        Console.WriteLine("Alter Wert: " + punktzahl);

        punktzahl = 75;
        Console.WriteLine("Neuer Wert: " + punktzahl);

        //16. Boolean-Variable: Erstelle eine bool-Variable (z.B. "istSchüler") und gib sie aus.

        bool istScheuler = true;

        Console.WriteLine("Ist Schüler: " + istScheuler);


        //17. Double-Variable: Erstelle eine Variable für eine Kommazahl (z.B. Temperatur) und gib sie aus.

        double Temperatur = 34.5;
        Console.WriteLine("Temperatur: " + Temperatur);


        //18. Konstante: Erstelle eine Konstante für Pi (3.14159) und verwende sie in einer Berechnung.


        const double pi = 3.14159;
        double radius = 5;
        double umfang = 2 * pi * radius;
        Console.WriteLine("Umfang eines Kreises: " + umfang);

        //19. String-Verkettung: Kombiniere mehrere Strings zu einem Satz.

        string satz = "Hallo, mein Name ist " + name + " und ich wohne in " + stadt + ".";
        Console.WriteLine(satz);


        //20. Grundrechenarten: Führe Addition, Subtraktion, Multiplikation und Division mit Variablen aus static void level2()

        Console.WriteLine("Addition: " + (alter + a));
        Console.WriteLine("Subtraktion: " + (alter - a));
        Console.WriteLine("Multiplikation: " + (radius * umfang));
        Console.WriteLine("Division: " + (pi / radius));

    }
    //Level 3: Benutzereingaben (21-30)

    static void level3()
    {

        //21. Name eingeben: Frage den Benutzer nach seinem Namen und begrüße ihn.
        Console.Write("Wie alt bist du? ");
        int alter = int.Parse(Console.ReadLine());
        Console.WriteLine($"Du bist {alter} Jahre alt.");

        // 23. Zwei Zahlen addieren: Lass den Benutzer zwei Zahlen eingeben und gib die Summe aus.

        Console.Write("Gib die erste Zahl ein: ");
        double zahl1 = double.Parse(Console.ReadLine());
        Console.Write("Gib die zweite Zahl ein: ");
        double zahl2 = double.Parse(Console.ReadLine());

        double summe = zahl1 + zahl2;
        Console.WriteLine($"Die Summe lautet: {summe} ");

        // 24. Lieblingsfarbe
        Console.Write("Was ist deine Lieblingsfarbe? ");
        string farbe = Console.ReadLine();
        Console.WriteLine($"Oh, {farbe} ist eine schöne Farbe!\n");

        // 25. Geburtsjahrberechnung
        Console.Write("Wie alt bist du? ");
        int alter = int.Parse(Console.ReadLine());
        int aktuellesJahr = DateTime.Now.Year;
        int geburtsjahr = aktuellesJahr - alter;
        Console.WriteLine($"Du wurdest ungefähr im Jahr {geburtsjahr} geboren.\n");

        // 26. Rechteck-Fläche
        Console.Write("Gib die Länge des Rechtecks ein: ");
        double laenge = double.Parse(Console.ReadLine());
        Console.Write("Gib die Breite des Rechtecks ein: ");
        double breite = double.Parse(Console.ReadLine());
        double flaeche = laenge * breite;
        Console.WriteLine($"Die Fläche des Rechtecks beträgt {flaeche}.\n");

        // 27. Temperaturumrechnung (Celsius → Fahrenheit)
        Console.Write("Gib die Temperatur in °C ein: ");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = celsius * 9 / 5 + 32;
        Console.WriteLine($"{celsius}°C entsprechen {fahrenheit}°F.\n");

        // 28. Begrüßung personalisieren
        Console.Write("Gib deinen Vornamen ein: ");
        string vorname = Console.ReadLine();
        Console.Write("Gib deinen Nachnamen ein: ");
        string nachname = Console.ReadLine();
        Console.WriteLine($"Hallo {vorname} {nachname}, schön dich kennenzulernen!\n");

        // 29. Einfacher Taschenrechner
        Console.Write("Gib die erste Zahl ein: ");
        double zahl1 = double.Parse(Console.ReadLine());
        Console.Write("Gib die zweite Zahl ein: ");
        double zahl2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"Summe: {zahl1 + zahl2}");
        Console.WriteLine($"Differenz: {zahl1 - zahl2}");
        Console.WriteLine($"Produkt: {zahl1 * zahl2}");
        Console.WriteLine($"Quotient: {zahl1 / zahl2}\n");

        // 30. Kreis-Umfang
        Console.Write("Gib den Radius des Kreises ein: ");
        double radius = double.Parse(Console.ReadLine());
        double umfang = 2 * Math.PI * radius;
        Console.WriteLine($"Der Umfang des Kreises beträgt {umfang}.\n")

        }
    static void level4()
    {

        // 31. Volljährigkeitsprüfung
        Console.Write("Wie alt bist du? ");
        int alter = int.Parse(Console.ReadLine());
        if (alter >= 18)
            Console.WriteLine("Du bist volljährig.\n");
        else
            Console.WriteLine("Du bist noch nicht volljährig.\n");

        // 32. Gerade oder ungerade
        Console.Write("Gib eine Zahl ein: ");
        int zahl = int.Parse(Console.ReadLine());
        if (zahl % 2 == 0)
            Console.WriteLine("Die Zahl ist gerade.\n");
        else
            Console.WriteLine("Die Zahl ist ungerade.\n");

        // 33. Positiv oder negativ
        Console.Write("Gib eine Zahl ein: ");
        double wert = double.Parse(Console.ReadLine());
        if (wert > 0)
            Console.WriteLine("Die Zahl ist positiv.\n");
        else if (wert < 0)
            Console.WriteLine("Die Zahl ist negativ.\n");
        else
            Console.WriteLine("Die Zahl ist null.\n");

        // 34. Maximum zweier Zahlen
        Console.Write("Gib die erste Zahl ein: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Gib die zweite Zahl ein: ");
        double b = double.Parse(Console.ReadLine());
        double max = (a > b) ? a : b;
        Console.WriteLine($"Die größere Zahl ist: {max}\n");

        // 35. Notenberechnung (0–100 Punkte)
        Console.Write("Gib deine Punktzahl (0–100) ein: ");
        int punkte = int.Parse(Console.ReadLine());
        if (punkte >= 90)
            Console.WriteLine("Note: 1 (A)\n");
        else if (punkte >= 80)
            Console.WriteLine("Note: 2 (B)\n");
        else if (punkte >= 65)
            Console.WriteLine("Note: 3 (C)\n");
        else if (punkte >= 50)
            Console.WriteLine("Note: 4 (D)\n");
        else if (punkte >= 30)
            Console.WriteLine("Note: 5 (E)\n");
        else
            Console.WriteLine("Note: 6 (F)\n");

        // 36. Schaltjahr
        Console.Write("Gib ein Jahr ein: ");
        int jahr = int.Parse(Console.ReadLine());
        if ((jahr % 4 == 0 && jahr % 100 != 0) || (jahr % 400 == 0))
            Console.WriteLine($"{jahr} ist ein Schaltjahr.\n");
        else
            Console.WriteLine($"{jahr} ist kein Schaltjahr.\n");

        // 37. Login-System
        string benutzername = "admin";
        string passwort = "1234";
        Console.Write("Benutzername: ");
        string eingabeName = Console.ReadLine();
        Console.Write("Passwort: ");
        string eingabePass = Console.ReadLine();
        if (eingabeName == benutzername && eingabePass == passwort)
            Console.WriteLine("Zugriff gewährt.\n");
        else
            Console.WriteLine("Zugriff verweigert.\n");

        // 38. Rabattrechner
        Console.Write("Gib den Einkaufswert in € ein: ");
        double einkauf = double.Parse(Console.ReadLine());
        if (einkauf >= 50)
        {
            double rabatt = einkauf * 0.1;
            double endpreis = einkauf - rabatt;
            Console.WriteLine($"Du bekommst 10% Rabatt! Neuer Preis: {endpreis}€\n");
        }
        else
            Console.WriteLine("Kein Rabatt. Preis bleibt gleich.\n");

        // 39. BMI-Bewertung
        Console.Write("Gib dein Gewicht (kg) ein: ");
        double gewicht = double.Parse(Console.ReadLine());
        Console.Write("Gib deine Größe (m) ein: ");
        double groesse = double.Parse(Console.ReadLine());
        double bmi = gewicht / (groesse * groesse);
        Console.WriteLine($"Dein BMI beträgt: {bmi:F1}");
        if (bmi < 18.5)
            Console.WriteLine("Untergewicht.\n");
        else if (bmi < 25)
            Console.WriteLine("Normalgewicht.\n");
        else
            Console.WriteLine("Übergewicht.\n");

        // 40. Temperatur-Warnung
        Console.Write("Gib die Temperatur in °C ein: ");
        double temperatur = double.Parse(Console.ReadLine());
        if (temperatur > 30)
            Console.WriteLine("Achtung! Es ist sehr heiß!\n");
        else if (temperatur < 0)
            Console.WriteLine("Warnung: Es ist unter dem Gefrierpunkt!\n");
        else
            Console.WriteLine("Die Temperatur ist angenehm.\n");

    }

    static void level5()
    {

        // 41. Zahlen 1-10
        Console.WriteLine("Zahlen 1–10:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        // 42. Countdown 10–0
        Console.WriteLine("Countdown:");
        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Start!\n");

        // 43. Gerade Zahlen 2–20
        Console.WriteLine(" Gerade Zahlen:");
        for (int i = 2; i <= 20; i += 2)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        // 44. Einmaleins einer Zahl
        Console.Write("Gib eine Zahl für das Einmaleins ein: ");
        int zahl = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{zahl} x {i} = {zahl * i}");
        }
        Console.WriteLine();

        // 45. Summe 1–100
        Console.WriteLine("Summe aller Zahlen von 1 bis 100:");
        int summe = 0;
        for (int i = 1; i <= 100; i++)
        {
            summe += i;
        }
        Console.WriteLine($"Summe = {summe}\n");

        // 46. Fakultät
        Console.Write("Gib eine Zahl für die Fakultät ein: ");
        int n = int.Parse(Console.ReadLine());
        long fakultaet = 1;
        for (int i = 1; i <= n; i++)
        {
            fakultaet *= i;
        }
        Console.WriteLine($"{n}! = {fakultaet}\n");

        // 47. Zahlenraten (feste Zahl, z. B. 7)
        Console.WriteLine("Zahlenraten:");
        int geheimzahl = 7;
        int versuch = 0;
        int eingabe = -1;
        while (eingabe != geheimzahl)
        {
            Console.Write("Rate die Zahl (1–10): ");
            eingabe = int.Parse(Console.ReadLine());
            versuch++;
            if (eingabe < geheimzahl)
                Console.WriteLine("Zu niedrig!");
            else if (eingabe > geheimzahl)
                Console.WriteLine("Zu hoch!");
            else
                Console.WriteLine($"Richtig! Du hast {versuch} Versuche gebraucht.\n");
        }

        // 48. Durchschnitt von 5 Zahlen
        Console.WriteLine("Durchschnitt von 5 Zahlen:");
        double sum = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Zahl {i}: ");
            sum += double.Parse(Console.ReadLine());
        }
        double durchschnitt = sum / 5;
        Console.WriteLine($"Der Durchschnitt beträgt: {durchschnitt}\n");

        // 49. Quadratzahlen 1–10
        Console.WriteLine("Quadratzahlen:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i}² = {i * i}");
        }
        Console.WriteLine();

        // 50. Passwort-Wiederholung (while-Schleife)
        Console.WriteLine("Passwort-Wiederholung:");
        string korrektesPasswort = "geheim";
        string eingabePasswort = "";
        while (eingabePasswort != korrektesPasswort)
        {
            Console.Write("Bitte Passwort eingeben: ");
            eingabePasswort = Console.ReadLine();
            if (eingabePasswort != korrektesPasswort)
                Console.WriteLine("Falsch, versuche es erneut!");
        }
        Console.WriteLine("Zugriff erlaubt");




    }


}

