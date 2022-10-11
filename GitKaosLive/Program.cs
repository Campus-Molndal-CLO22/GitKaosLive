// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, GitKaosLive!");

// Git kommandon
// Init = Skapar ett repo lokalt
// Add = Lägger till senaste ändringar i git databasen
// Commit = lägger det i vår lokala repo
// Push = Skicka från lokala repot till servern



/*
             +----Peters Branch--->\
             |                      \
             +----Johans Branch-->\  \ pull request
             |                     \  \
    Master ------------------------------------------->
             |                           \/ merge  / pull request
            TestBranch -------------------->------->


 Git flow
 -------------

 Master ------------------------------------------------>
  \                                                    |
   Product - kundens kod -------------------------->/---->
    \                                              /
     Staging - test hos kunden--------------------->
      \                                         /
       Test - test teamet ---------------------->                  
        \                                    /
         Dev - utvecklarnas branch (allt nytt hamnar här)
              |                           /                   
            feature branches             / Pull request
                nya knappar-------------/
                Nya funktioner
                Bättre algoritmer
                mm


Git flow:
    - Master    -- kundens kod
    - Prod      -- Kod som körs hos kunden
    - Release   -- Kod som är redo att lerereras, används för att hålla koll på olika versioner
    - Staging   -- Kod som testas hos kunden
    - Test      -- Kod som testas av test teamet
    - Hotfix    -- Kod som fixar kritiska buggar (hittade på prod, release eller test)
    - Dev       -- Kod som utvecklarna pull-requestar till
    - Feature   -- Varje utvecklare har en feature branch för att koda och testa innan pull-request

Case exempel:
I ett projekt har man dessa brancher, Master, Prod, Staging, Test, Dev
varje kodare skapar en branch för vaje ny feature som ska implementeras.

När en kodare är klar med sin feature så gör hen en pull request till Dev branchen,
om det accepteras så mergas den in i Dev branchen och feature branchen tas bort.

När Dev branchen är klar för release, görs en pull-request till Test branchen,
om det accepteras så mergas den in i Test branchen tas bort.

När Testarna gjort sitt med Test branchen som nu är klar för release, 
görs en pull-request till Staging branchen, om det accepteras så mergas den in i Staging branchen.

Staging branches testas hos kunden tills man är säker på att allt fungerar som det ska,
och då gör man en pull-request till Prod. Om det accepteras så mergas den in i Prod branchen.

Viktigt att komma ihåg:
- Buggar i Test, staging och prod fixas i en hotfix branch som mergas in i alla brancher som är berörda.
- Buggar i Dev fixas i Dev branchen och mergas in i Dev branchen.
- Om merge failar vid pull request måste det lösas innan pull-request accepteras.
- För att vara säker kör man CI (Continuous integration) vilket innebär att
  koden kompileras och testas på servern (ex. Github) innan merge tillåts.

CI = Continuous integration, kör kodens test och kompilerar den på servern innan merge tillåts.
CD = Continuous deployment, kör kodens test och kompilerar den på servern innan den deployas till produktion.
Deploy = att publicera kod till produktion (exempelvis publicera en webbsida online).

*/
*/
*/


*/

