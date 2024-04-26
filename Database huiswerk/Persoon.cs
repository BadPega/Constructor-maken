using System;

class Persoon

    private string naam;
    private int leeftijd;
    private char geslacht;
    private bool isStudent;
    private double gemiddeldCijfer;

    public Persoon(string naam, int leeftijd, char geslacht, bool isStudent, double gemiddeldCijfer)
    {
        this.naam = naam;
        this.leeftijd = leeftijd;
        this.geslacht = geslacht;
        this.isStudent = isStudent;
        this.gemiddeldCijfer = gemiddeldCijfer;
    }

 Persoon persoon1 = new Persoon("Stefan Milovic", 25, 'M', true, 7.2);
 Persoon persoon2 = new Persoon("Joey Fleming", 30, 'M', false, 6.5);
 Persoon persoon3 = new Persoon("Poka Hontas", 22, 'V', true, 8.1);

 Console.WriteLine(persoon1);
 Console.WriteLine(persoon2);
 Console.WriteLine(persoon3);