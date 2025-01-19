using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Elnevezési_konvenciók
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Az elnevezési konvenciók fontos szerepet játszanak a kód olvashatóságában és karbantarthatóságában.
            A C#-ban az elnevezési konvenciók segítenek abban, hogy a kód következetes és érthető legyen, 
            ami különösen fontos nagyobb projektekben és csapatmunkában.*/

            /*C# Elnevezési Konvenciók
            

             */

            /*
1. Osztályok
Elnevezési forma: PascalCase
Példa: UserAccount, CustomerManager, OrderProcessor
Használat: Osztályok neveit PascalCase formátumban írjuk, ahol minden szó első betűje nagy. 
Ez segít kiemelni az osztályokat a többi programozási elemtől és világosan jelzi, hogy egy új adattípusról van szó.

    public class UserAccount
    {
        // Osztály kódja
    }

2. Tulajdonságok (Properties)
Elnevezési forma: PascalCase
Példa: MaxValue, UserName, OrderDate, TotalAmount
Használat: A tulajdonságok neveit PascalCase formátumban írjuk, 
mivel azok nyilvános interfészek, amelyek az osztály állapotát reprezentálják. 
Ez a formátum biztosítja, hogy a tulajdonságok könnyen azonosíthatók legyenek és egyértelműek maradjanak a kódban.

    public int MaxValue { get; set; }
    public string UserName { get; set; }

3. Metódusok
Elnevezési forma: PascalCase
Példa: CalculateTotal, FetchUserData, UpdateOrderStatus
Használat: A metódusok neveit PascalCase formátumban írjuk, hogy azok világosan megkülönböztethetők 
 legyenek a változóktól és tulajdonságoktól, valamint jelöljék a metódusok funkcióját vagy műveletét.

    public void CalculateTotal()
    {
        // Metódus kódja
    }

    public string FetchUserData()
    {
        // Metódus kódja
    }

4. Változók
Elnevezési forma: camelCase
Példa: userAge, orderNumber, totalAmount
Használat: A változók neveit camelCase formátumban írjuk, ahol az első szó kis kezdőbetűvel kezdődik, 
míg a következő szavak nagy kezdőbetűsök. Ez segít megkülönböztetni a változókat az osztályoktól és tulajdonságoktól,
és biztosítja a kód olvashatóságát.

    int userAge = 30;
    string firstName = "John";

5. Privát mezők
Elnevezési forma: camelCase, gyakran aláhúzással kezdődnek (_)
Példa: _userName, _totalAmount, _orderNumber
Használat: A privát mezők neveit camelCase formátumban, de aláhúzással kezdve szokás írni.
            Ez a konvenció segít azonosítani a privát mezőket, és megkülönbözteti őket a nyilvános 
            tulajdonságoktól és metódusoktól.

    private int _maxValue;
    private string _userName;

6. Állandók (Constants)
Elnevezési forma: SCREAMING_SNAKE_CASE
Példa: MAX_LOGIN_ATTEMPTS, DEFAULT_USER_ROLE, PI
Használat: Az állandók neveit SCREAMING_SNAKE_CASE formátumban írjuk, ahol minden betű nagy és az 
            szavak aláhúzással vannak elválasztva. Ez a forma kiemeli az állandók változatlanságát 
            és globális jellegét a kódban.

    public const int MAX_LOGIN_ATTEMPTS = 5;
    public const string DEFAULT_USER_ROLE = "Guest";

7. Interfészek
Elnevezési forma: PascalCase, gyakran az I prefixszel kezdődnek
Példa: IUserService, IDataProvider, ILogger
Használat: Az interfészek neveit PascalCase formátumban írjuk, és gyakran `
            I` prefixet használunk az interfész neve előtt. Ez a konvenció segít azonosítani 
            az interfészeket és megkülönböztetni őket az osztályoktól.

    public interface IUserService
    {
        // Interface kódja
    }

8. Enumok
Elnevezési forma: PascalCase
Példa: OrderStatus, UserRole, LogLevel
Használat: Az enumok neveit PascalCase formátumban írjuk, mivel az enumok az adott értékek egy csoportját 
            jelölik, és PascalCase segít kiemelni őket a többi típus közül.


    public enum OrderStatus
    {
        Pending,
        Shipped,
        Delivered
    }
*/



        }
    }
}
