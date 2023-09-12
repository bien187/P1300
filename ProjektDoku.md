# Projekt-Dokumentation



| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|  16.08     | 0.0.1   | Planen des Spielablaufs |
|  23.08     | 0.0.2   | Grobe Umsetzung des Spiels in C#                                      |
|  30.08     | 0.0.3   |            Finden der eigenen Erweiterungen und grobe Implementierung von Diesen                                                |
| 06.09     | 1.0.0   |           Ausbesserung des Codes und der Funktionen                                                   |
 
## 1 Informieren

### 1.1 Ihr Projekt

Im Rahmen des Projektes 1300 im Fach Lernatelier, habe ich ein Zahlen-Rate-Spiel erstellt.



### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |    Muss             |   Funktional   | Als Benutzer möchte ich, dass eine Zahl zwischen 1 und 100 generiert wird. |
| 2 |          Muss          |    Funktional  |     Als Benutzer möchte ich, dass ich diese Zahl erraten kann.                               |
| 3 |              Muss      |   Funktional   | Als Benutzer möchte ich, dass mir Tipps ausgegeben werden.  |
| 4 |              Muss      |   Qualität   | Als Benutzer möchte ich die Möglichkeit haben, die Hintergrundfarbe zu ändern.  |
| 5 |              Muss      |  Qualität    | Als Benutzer möchte ich nach jeder Runde gefragt werden, ob ich nochmal spielen möchte.  |



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
|  1.1    |   Der Benutzer startet das Spiel           |  Start der Applikation       |  Es wird eine zufällige Zahl generiert.                 |
|  2.1   |  Der Benutzer errät die Zahl            |     Eingabe der Zahl    |   Es wird Ausgegeben, dass die Zahl erraten wurde.                |
| 3.1  |    Der Benutzer gibt eine Zahl ein          |   Eingabe einer Zahl      |  Es wird ein Tipp ausgegeben, der dem Benutzer sagt, ob die Zahl höher oder tiefer ist.                 |
| 4.1  |   Der Benutzer startet das Spiel           |   Start der Applikation      |  Der Titel erscheint und der Benutzer kann die Hintergrundfarbe ändern.                 |
|  5.1    |  Der Benutzer errät die Zahl            |  Eingabe der Zahl       |  Der Benutzer wird gefragt ob er noch eine Runde spielen möchte.                 |




## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  16.08     |   Ben Mueller        |   Planen des Spielablaufs           |      120'         |
|  2.A    |   23.08    |    Ben Mueller       |    Grobe Umsetzung des Spiels in C#                                                 |      180'         |
|    3.A  |   30.08    |    Ben Mueller       |     Finden der eigenen Erweiterungen und grobe Implementierung von Diesen              |    120'           |
|   4.A   |   06.09    |    Ben Mueller       |       Ausbesserung des Codes und der Funktionen             |    90'           |


Total: 510'


## 3 Entscheiden



## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |   16.08    |   Ben Mueller        |      120'         |       90'            |
| 2.A  |   23.08    |   Ben Mueller         |         180'      |      180'             |
| 3.A  |   30.08    |   Ben Mueller         |             120'  |     150'              |
| 4.A  |  06.09     |   Ben Mueller         |             90'  |       120'            |



## 5 Kontrollieren

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |  06.09      |   keine Fehler       |  Ben Mueller      |
| 2.1  | 06.09       |   keine Fehler       |  Ben Mueller      |
| 3.1  |   06.09     |   keine Fehler       |  Ben Mueller      |
| 4.1  |   06.09     |   keine Fehler       |  Ben Mueller      |
| 5.1  |  06.09      |   keine Fehler       |  Ben Mueller      |
