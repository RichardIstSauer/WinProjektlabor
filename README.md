# WinProjektlabor
![image](https://user-images.githubusercontent.com/42067245/115446637-cea80f00-a217-11eb-917e-46a8d45e31b3.png)
Das Projektlabor am Berufskolleg Rheine ist eine
offene Lernumgebung für Schülerinnen und
Schüler. Hier haben „Maker“ einen Ort
geschaffen, wo eigene Projekte kreativ
verwirklicht werden können.
Das Projektlabor wächst zunehmend um neue
Maker, Lehrerinnen- und Lehrer, die Projekte
unterstützen, und angeschafftes Inventar.
Ein digitales System soll helfen, die Übersicht zu
behalten. In einer ersten Software mit zugehöriger Datenbank, sollen Ben utzerrechte für die
Nutzung der Maschinen im Projektlabor gesteuert werden. Beispielsweise ist nicht jeder Maker
berechtigt, die CNC-Drehmaschine zu bedienen. Nur ein „Keymember“ mit Administratorrechten soll
in der Lage sein, Rechte für den Zugriff auf bestimmte Maschinen an einen Maker zu vergeben.
Zugriffe auf Maschinen können mit einen USB-Button (im Projekt ein vorbereiteter USB-Stick,
später evtl. ein RFID-Chip) gesteuert werden. Jeder Maker soll in Zukunft einen personalisierten
USB-Button erhalten, über den er identifiziert wird und damit die Rechte zur Bedienung einer
Maschine erhält.
Sowohl Rechteverwaltung als auch Logs (Benutzer und Nutzungszeit einer Maschine) werden in
einer Datenbank verwaltet. Die Datenbank liegt als MySQL-Dump vor (projektlabor.sql).
Sie entwickeln eine C#-Windows-Forms-Software für die Verwaltung der Daten. Dabei sollen Sie
sich systematisch mit dem Lesen- und Schreiben der Daten, Entscheidungen über geeignete
Datenformate und Darstellungsmöglichkeiten der Daten befassen. In einem Fachgespräch sollen
Sie Ihre Planungen und systemischen Entscheidungen darlegen und begründen und gegen
Alternativen abwägen können.
Für die Datenbankoperationen steht Ihnen als programmiertechnische Hilfestellung die Klasse
Dbase.cs mit nützlichen Methoden zur Verfügung. Nützliche Methoden zur automatischen
Erkennung von USB-Sticks stehen in dem Programm WinUsbDetect zur Verfügung.
