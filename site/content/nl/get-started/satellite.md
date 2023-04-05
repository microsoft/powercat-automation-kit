---
title: "Satelliet - Aan de slag"
description: "Automation Kit - Satelliet - Aan de slag"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Satellite']
generated: D34A3BCCCE29730419418EAC4DDC091FAB118A83
---

# Overzicht

Welkom op de startpagina voor de satellietoplossing. In dit gedeelte worden belangrijke wijzigingen behandeld die in april 2023 en latere releases zijn aangebracht. Na april 2023 hebben we de noodzaak voor Azure Key Vault verwijderd om Azure Application-tenant, Application Id en geheime informatie over Azure Application op te slaan.

## Conceptueel ontwerp

Onze leerpagina schetst de [Conceptueel ontwerp](https://learn.microsoft.com/power-automate/guidance/automation-kit/overview/introduction#conceptual-design) van de {{productnaam}}. Het belangrijkste element van de oplossing is de Power Platform hoofdomgeving.

Er zijn meestal verschillende satellietproductieomgevingen die uw automatiseringsprojecten uitvoeren. Afhankelijk van uw omgevingsstrategie kunnen dit ook ontwikkel- of testomgevingen zijn.

Tussen deze omgevingen is er een bijna realtime synchronisatieproces dat cloud- of desktopstroomtelemetrie, machine- en machinegroepgebruik en auditlogboeken omvat. Op het Power BI-dashboard voor de Automation Kit wordt deze informatie weergegeven.

## Wat is er veranderd?

Als onderdeel van het oplossen [[Automation Kit - Functie]: Azure Key Vault-alternatief voor satellietomgevingen](https://github.com/microsoft/powercat-automation-kit/issues/84) Azure Key Vault is niet langer vereist. Dit is belangrijk omdat het de complexiteit van de installatie aanzienlijk vermindert en hoe de beveiliging wordt beheerd om oplossingsartefacten te verkrijgen bij het gebruik van de Automation Solution Manager.

## Wat is hetzelfde?

Zodra de belangrijkste elementen hetzelfde zijn als de oudere releases van vóór april 2023 en april 2023, is er behoefte aan een Azure Active Directory-toepassing.

Een [applicatie gebruiker](https://learn.microsoft.com/power-platform/admin/manage-application-users) is een type gebruiker in de Power Platform dat wordt geïdentificeerd door de aanwezigheid van het kenmerk ApplicationId in de systeemgebruikersrecord. Toepassingsgebruikers worden gemaakt in Azure Active Directory (Azure AD) en worden gebruikt om de toegang tot de Power Platform te verifiëren en te autoriseren. Ze worden meestal gebruikt om een toepassing of service te vertegenwoordigen die toegang moet krijgen tot gegevens of bewerkingen moet uitvoeren in de Power Platform namens gebruikers of andere toepassingen.

Specifiek wordt de toepassingsgebruiker gebruikt door automation solution manager om u in staat te stellen de oplossingsonderdelen in een omgeving op te vragen, zodat u een gebruiker in staat kunt stellen een geïmplementeerde Power Platform oplossing te meten.

## Installeren

De [opdrachtregel installeren](/nl/get-started/install) voor satellietoplossingen wordt u gevraagd om de Naam van azure Active Directory-toepassing en azure Active Directory-toepassings-id. Met behulp van deze informatie wordt het volgende gedaan:

1. De Azure Active Directory-toepassing toevoegen als toepassingsgebruiker
1. De toepassingsgebruiker toevoegen aan de rol systeembeheerder
1. De gebruikers-id van de toepassingsgebruiker toevoegen aan de omgevingsvariabele **Oplossingsbeheerartefacten Lees gebruikers-id**

De nieuwe rol dataverse rol **Gebruiker van Automation Solution Manager** is toegevoegd waarmee gebruikers de nieuwe Dataverse GetDataverseSolutionArtifacts Custom API kunnen aanroepen die oplossingsartefacten opvraagt met behulp van de meegeleverde omgevingsvariabele **Oplossingsbeheerartefacten Lees gebruikers-id**.

Als u de satelitte-oplossing handmatig wilt installeren, moeten de volgende wijzigingen worden aangebracht in de [Satellieten instellen](https://learn.microsoft.com/en-us/power-automate/guidance/automation-kit/setup/satellite) aanwijzingen.

1. Sla de stap "Een nieuw clientgeheim toevoegen" over, omdat dit niet langer nodig is voor april 2023 of nieuwer.
1. Sla de stap over om geheimen te maken in de Azure Key Vault.
1. Voeg de gebruikers-id van de toepassingsgebruiker toe aan de **Oplossingsbeheerartefacten Lees gebruikers-id** Omgevingsvariabele.

## Na installatie

Zorg ervoor dat de gebruiker(s) die de Automation Solution Manager-toepassing uitvoeren, de **Gebruiker van Automation Solution Manager** Dataverse beveiligingsrol.

## Vorige releases

Vóór de release van april 2023 vereisten installaties van satellite solution omgevingsvariabelen van type secret. Hiervoor was een [Azure Key Vault](https://learn.microsoft.com/power-apps/maker/data-platform/environmentvariables#use-azure-key-vault-secrets-preview) om de waarden voor tenant-id, toepassings-id en toepassingsgeheim op te slaan. Om deze functie te gebruiken, was ook de [prerequistes](https://learn.microsoft.com/en-us/power-apps/maker/data-platform/environmentvariables#prerequisites) of de Azure Key Vault is dezelfde tenant, setup van Microsoft.PowerPlatform als resource provider.

In de releases van maart 2023 of ouder werd de Azure Key Vault gebruikt om een tenant-id, APplication Id en Application Secret op te slaan. Met behulp van deze waarden werd een toegangstoken gevraagd om gegevensversum op te vragen, zodat het de lijst met oplossingsonderdelen kon retourneren.

## Aanbevelingen

Voor bestaande gebruikers wordt aanbevolen om doorlopend beheer te vereenvoudigen en de noodzaak van een afhankelijkheid van Azure Key Vault weg te nemen dat u de bestaande satellietinstallatie upgradet naar april 2023 of later om te profiteren van de nieuwe functies.
