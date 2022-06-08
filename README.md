# Stage Cipher - Azure reporting
Welkom bij de GitHub repository voor de stage omtrent Azure reporting. In deze repository zijn verschillende test applicaties te vinden die gebruikt zijn om monitoring binnen Azure te demonstreren. Daarnaast worden er ook enkele sjablonen weergegeven.

## Inhoudsopgave
De verschillende onderdelen die behandeld worden in de README:   
1. [Inleiding;](#inleiding)
2. [Meerwaarde repository;](#meerwaarde-repository)
3. [Verdeling repository;](#verdeling-repository)
4. [Uitleg Proof of Concept;](#uitleg-proof-of-concept)
5. [Activeren test applicaties](#activeren-test-applicaties)
6. [Conclusie.](#conclusie)


## Inleiding
Dit is een product voor de afstudeer stage van Cipher over Azure reporting. Cipher wilt middels consequente monitoring problemen (vroegtijdig) detecteren. Dit zodat deze problemen opgepakt kunnen worden en 100% uptime en beschikbaarheid van hun klant-oplossingen gewaarborgd kan worden. Er is gewenst dat de monitoring op een gestandaardiseerde en consequente manier kan worden toegepast, zodat Cipher zo min mogelijk tijd en onderhoud nodig heeft voor deze klant-oplossingen (dit is namelijk geen hoofdtaak voor Cipher).

Deze stage betreft een duur van 20 weken en is uitgevoerd door Giuseppe Collura (hbo-ICT student aan Zuyd hogeschool met profileringsrichting development).

## Meerwaarde repository
Deze repository kan door Cipher gebruikt worden om de Proof of Concept te reproduceren. Om de Proof of Concept te reproduceren is het wel van belang om de handleiding uit het portfolio te gebruiken.  
Daarnaast dient dit als extra bewijslast voor de opgestelde Proof of Concept, naast het document wat hier specifiek voor is opgesteld (`Bewijslast PoC V1.0.docx`).

## Verdeling repository
De repository is opgedeeld in twee verschillende onderdelen.  
1. De test applicaties:  
    Deze applicaties worden gebruikt om het principe van monitoring te demonstreren.  
    Om de demonstratie succesvol te laten verlopen, zijn er bewust verschillende fouten gemaakt binnen de applicaties. Dit zodat uit de monitoring kan blijken of deze fouten ook gevonden kunnen worden.
2. Sjablonen:  
    De sjablonen kunnen gebruikt worden om monitoring snel en effectief uit te rollen. Daarnaast zorgen de sjablonen voor een standaard die consequent toegepast kan worden. Vanuit de handleiding wordt er geregeld verwezen naar de sjablonen. Afhankelijk van de verandering que behoeften kunnen deze sjablonen aangepast worden. 

## Uitleg Proof of Concept
De Proof of Concept bestaat uit twee verschillende onderdelen. Zo bestaat het uit twee test applicaties en een gehele implementatie van de monitoring. Met behulp van deze monitoring kunnen de verschillende problemen in de test applicaties achterhaald worden. De implementatie van deze monitoring is uitgevoerd binnen de Cloud diensten van Microsoft genaamd Azure. Omdat de implementatie heeft plaatsgevonden binnen Azure is er een document opgesteld waarmee bewijslast wordt geleverd.  
Binnen de monitoring komen verschillende aspecten aan bod zoals:
- Verzamelen van metriek en logs, zodat problemen achterhaald kunnen worden;
- Waarschuwingen waarmee men op de hoogte wordt gehouden van mogelijke problemen;
- Inzichtelijk maken van het gedrag van een applicatie middels dashboards;   
    Waarbij dit gedrag automatisch wordt vertaalt richting de klant om transparantheid te bieden.
- Complexe inzichten van werkmappen waarmee problemen achterhaald kunnen worden.


## Activeren test applicaties
De test applicaties kunnen geraadpleegd worden via de volgende links wanneer de servers nog actief zijn:
- [Test applicatie 1](https://monitoring-webapp-azure-internship-cipher-1.azurewebsites.net)
- [Test applicatie 2](https://monitoring-webapp-azure-internship-cipher-2.azurewebsites.net)

Als de servers niet meer actief zijn is het ook mogelijk om de test applicaties op een eigen machine te laten draaien. Stap 1 en 2 zijn alleen nodig wanneer er ook monitoring wordt ingericht, anders kunnen deze stappen worden overgeslagen. 
1. Navigeer naar:
    - `Internship-Cipher-V1.0/Test Applicaties/Internship-Azure-Cipher/Pages/Shared/_Layout.cshtml`
    - `Internship-Cipher-V1.0/Test Applicaties/Internship-Azure-Cipher2/Pages/Shared/_Layout.cshtml`
2. Verander beide bestanden de `connectionString` naar de bijbehorend connectionstring van een de nieuwe application insights resources,
3. Open de terminal en vul in: `dotnet watch  run --urls=https://localhost:5001/`


## Conclusie
Uit de Proof of Concept blijkt dat het mogelijk is om op een consequente en gestandaardiseerde manier problemen achterhaald kunnen worden, zoals gewenst wordt door Cipher. Hiermee wordt dan ook de doelstelling van het project behaald (de doelstelliing wordt uitgewekt binnen de verschillende producten uit het portfolio).

____
_Voor vragen kunt u terecht bij: Giuseppe.Collura@innervate.nl_