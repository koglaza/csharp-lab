/* zadanie 1 */
using System.Diagnostics.Metrics;

Console.WriteLine("Zmienne i typy danych");
byte byteVariable = 50;
int integralVariable = 300;
long longVariable = 100000000;
char charVariable1 = (char)87;
char charVariable2 = 'a';
double doubleVariable = 50.0005;
float floatVariable = 50e10F;
string stringVariable = "How you doing?";
// tutaj wpisz rozwiązanie

/* koniec zadania 1 */

/* zadanie 2 */
int num = 2147483647;
long bigNum = 88888888888;
string stringNum = "1024";

// zadeklaruj zmienną typu long i przypisz do niej zmienną num
// zadeklaruj zmienną typu int i przypisz do niej zmienną bigNum
// zadeklaruj zmienną typu int i przypisz do niej zmienną stringNum (zastosuj Parse)
// zbadaj zachowanie programu

/* koniec zadania 2 */

/* zadanie 3 */
int a = 18;
int b = 6;
decimal price = 10.56m;
double doubleVal = 10.56;
double radius = 5.0;
double time = 1234.45;
// zadeklaruj zmienną c, do której przypisz wynik dodawania a i b 
// zadeklaruj zmienną d, do której przypisz wynik odejmowania a i b 
// zadeklaruj zmienną e, do której przypisz wynik mnożenia a i b 
// zadeklaruj zmienną f, do której przypisz wynik dzielenia a i b 
// zadeklaruj zmienną g, do której przypisz wynik reszty z dzielenia a i b 
// wypisz na ekran c,d,e,f,g
// wypisz na ekran wynik zmiennej price pomnożonej przez samą siebie
// wypisz na ekran wynik zmiennej doubleVal pomnożonej przez samą siebie
// zastanów się skąd się bieże różnica
// wypisz na ekran wynik pola koła o promieniu równym radius
// W zmiennej time znajduje się czas w minutach. Oblicz wartości zmiennych hours, minutes i seconds na postawie zmiennej time.

/* koniec zadania 3 */

/* zadanie 4 */
int toIncrement = 3;
int toDivide = 5;
// wstaw do zmiennej toIncrement jej obecną wartość powiększoną o jeden (nie używając żadnej cyfry)
// wstaw do zmiennej toDivide jej obecną wartość podzieloną o nią samą (nie używając żadnej cyfry)

/* koniec zadania 4 */

/* zadanie 5 */
double degree = 45;
double sinValue;
// do zmiennej sinValue przypisz wartość funkcji sinus dla zmiennej degree wyrażonej w stopniach

/* koniec zadania 5 */

/* zadanie 6 */
int year = 2024;
int month = 5;
int day = 3;
int hour = 23;
int minute = 30;
// stwórz zmienną typu DateTime jako wartość złożoną z powyższych składowych
// następnie dodaj do niej 3 miesiące, odejmij 1 godzinę
// wypisz na ekran nazwę dnia tygodnia jaki przypada tego dnia

/* koniec zadania 6 */

/* zadanie 7 */
string firstPart = "This is";
string secondPart = "a string";
string thirdPart = "with capital letters.";
// stwórz nową zmienną typu string jako złączenie powyższych.
// pamiętaj o brakujących odstępach
// wypisz na ekran tekst nowej zmiennej DRUKOWANYMI LITERAMI
// oraz liczbę przedstawiającą długość tego ciągu znaków

/* koniec zadania 7 */

/* zadanie 8 */
double lengthA = 5;
double lengthB = 1;
double lengthC = 3;
// zadeklaruj zmienną typu bool, przypisz do niej wartość mówiącą czy z powyższych 3 odcinków da się zbudować trójkąt
// jeśli tak, to sprawdź czy jest to trójkąt prostokątny (kolejna zmienna bool)

/* koniec zadania 8 */

/* zadanie 9 */
string conditionalString = "To be or not to be?";
// jeśli długość ciągu znaków jest większa niż 10 to wyświetl na ekran ten tekst

/* koniec zadania 9 */

/* zadanie 10 */
int temperature = 22;
// jeśli temperatura jest większa niż 20`C wyświetl "ciepło", w przeciwnym wypadku "zimno"

/* koniec zadania 10 */

/* zadanie 11 */

/* koniec zadania 11 */

/* zadanie 12 */
int code = 4;
int quantity = 11;
decimal productPrice = 3.5m;
decimal sellPrice;

Console.WriteLine($"Price: {sellPrice}");
/* koniec zadania 12 */

/* zadanie 13 */
char hexNum = 'E';

switch (hexNum)
{
    case '0':
        Console.WriteLine($"Decimal number: 0");
        break;
    // ...
    
    default:
        Console.WriteLine($"Not a valid hexadecimal number!");
        break;
}

/* koniec zadania 13 */