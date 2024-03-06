# C# Övningssamling - Inkapsling, arv och polymorfism

Löpande i uppgifterna finns några kunskapsfrågor (startar med “F:”).Dessa frågor besvaras som
kommentarer i koden.Koden behöver inte ta emot inputfrån en användare.

## 3.1) Inkapsling

1. Skapa en klassPersonoch ge den följande privatafält:
    age, fName, lName, height, weight
Skapa publika properties med _get_ och _set_ som hämtareller sätter tilldelad variabel.
Instansiera en person i _Program.cs_ , kommer du direktåt variablerna?
Implementera validering i de skapade properties:
● Age kan bara tilldelas ett värde större än 0.
● FName är obligatorisk och får inte vara mindre än 2 tecken eller längre än 10
tecken.
● LName är obligatorisk och får inte vara mindre än 3 tecken eller större än 15
tecken.
Kasta ett undantag av typen ArgumentException i varje property om dess
validering inte fullföljs, undantaget ska innehålla ett beskrivande
meddelande.
Se till att hantera undantagen i Program-klassen med en try-catch block.
2. För att inkapsla Person-objekten ytterligare skall vi skapa klassenPersonHandler-
    en klass vars syfte är att skapa och hantera dina Person-objekt.
    I _PersonHandler-klassen_ skapa metoden:
       public void SetAge(Person pers, int age)
    Använd den inskickade personens _Age property_ för attsätta personens _age-attribut_
    via _SetAge-metoden_. Istället för att enbart användaen _property_ har vi nu
    abstraherat med två lager.
3. I _PersonHandler_ , skriv en metod som skapar en personmed angivna värden:
    public Person CreatePerson(int _age_ , string _fname_ ,
       string _lname_ , double _height_ , double _weight_ )
4. Fortsätt skapa metoder i _PersonHandler_ för att kunnahantera samtliga
    operationer som man kan vilja göra med en _Person_.


5. När denna klass är klar, kommentera bort er tidigare instans av _Person_ från
    Program.cs, och instansiera istället en _PersonHandler_. Skapa därigenom några
    personer och testa era metoder.

## 3.2) Polymorfism

1. Skapa den abstrakta klassenUserError
2. Skapa den abstrakta metodenUEMessage()som har returtypen _string._
3. Skapa en vanlig klassNumericInputError som ärverfrånUserError
4. Skriv enoverride förUEMessage()så att den returerar _“You tried to use a_
    _numeric input in a text only field. This fired an error!”_
5. Skapa en vanlig klassTextInputError som ärver frånUserError
6. Skriv enoverride förUEMessage()så att den returerar _“You tried to use a text_
    _input in a numeric only field. This fired an error!”_
7. I Program.cs Main-metod: Skapa en lista medUserErrors och populera den med
    instanser avNumericInputError ochTextInputError.
8. Skriv ut samtliga UserErrorsUEMessage()genom enforeach loop.
9. Skapa nu tre egna klasser med tre egna definitioner påUEMessage()
10.Testa och se så det fungerar.

## 3.3) Arv

1. Skapa abstrakta klassenAnimal
2. Fyll klassenAnimalmed egenskaper (properties) somalla djur bör ha. Tex namn,
    vikt, ålder.
3. Skapa en abstrakt metod som heterDoSound().
4. Lägg till en konstruktor.
5. Skapa Subklasserna (ärver frånAnimal):Horse, Dog, Hedgehog, Wormoch
    Bird, Wolf.
6. Ge dessa minst en unik egenskap var. Vilken egenskap det är är inte det viktiga här.
    Exempel Worm: IsPoisonous, Hedgehog: NrOfSpikes , Bird: WingSpan osv.
7. Implementera så attDoSound()metoden skriver ut hurdjuret låter..
8. Skapa nu följande tre klasser:Pelican, FlamingoochSwan. Dessa ska ärva
    från Bird.
9. Ge dessa minst en unik egenskap var.
10.Skapa gränssnittet (interface)IPersonmed en metoddeklarationTalk();



11.Skapa klassenWolfmansom ärver frånWolfoch implementerarIPerson
gränssnittet.
12.ImplementeraTalk()som skriver ut vadWolfmansäger.

13. **F:** Om vi under utvecklingen kommer fram till att samtligafåglar behöver ett nytt
    attribut, i vilken klass bör vi lägga det?
14. **F:** Om alla djur behöver det nya attributet, vart skulleman lägga det då?

## 3.4) Mer polymorfism

1. Skapa metodenStats() i klassenAnimal som har returtypen _string._
    Metoden ska kunna _overridas_ i dess Subklasser. Metodenska returnera alla
    egenskaper ( _properties)_ som djuret har.
2. Skriv en _override_ förStats() i subklasserna förAnimalså den returnerar alla
    _properties_ för det djuret.
3. Skapa en listaAnimalsi Program.cs som tar emot djur.
4. Skapa några djur (av olika typ) i din lista.
5. Skriv ut vilka djur som finns i listan med hjälp av en _foreach-loop_
6. Anropa ävenAnimals Sound() metod i foreach-loopen.
7. Gör en check i for-loopen ifall ett djur även är av typenIPerson,om den är det
    type-casta tillIPersonoch anropa dessTalk() metod.
8. Skapa en lista för hundar.
9. **F:** Försök att lägga till en häst i listan av hundar.Varför fungerar inte det?
10. **F:** Vilken typ måste listan vara för att alla klasserskall kunna lagras tillsammans?
11.Skriv ut samtligaAnimals Stats() genom en foreachloop.
12.Testa och se så det fungerar.
13. **F:** Förklara vad det är som händer.
14.Skriv utStats() metoden enbart för alla hundar genomen foreach på
    Animals.
15.Skapa en ny metod med valfritt namn i klassenDogsom endast returnerar en valfri
    sträng.
16.Kommer du åt den metoden frånAnimals listan?
17. **F:** Varför inte?
18.Hitta ett sätt att skriva ut din nya metod för dog genom en foreach påAnimals.

Lycka till!


