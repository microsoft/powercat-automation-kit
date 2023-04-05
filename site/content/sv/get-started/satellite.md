---
title: "Satellit - Kom igång"
description: "Automation Kit - Satellit - Kom igång"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Satellite']
generated: 6883D16022FA80683F6DFF779929B1FC8B73E83F
---

# Överblick

Välkommen till startsidan för satellitlösningen. Det här avsnittet beskriver viktiga ändringar som gjordes i april 2023 och senare versioner. Efter april 2023 har vi tagit bort behovet av Azure Key Vault för att lagra Azure Application-klient-, program-ID och Azure Application hemlig information.

## Konstruktions

Vår lärsida beskriver [Konstruktions](https://learn.microsoft.com/power-automate/guidance/automation-kit/overview/introduction#conceptual-design) av {{<product-name>}}. Nyckelelementet i lösningen är den Power Platform huvudmiljön.

Det finns vanligtvis flera satellitproduktionsmiljöer som kör dina automationsprojekt. Beroende på din miljöstrategi kan dessa också vara utvecklings- eller testmiljöer.

Mellan dessa miljöer finns en synkroniseringsprocess i nära realtid som omfattar moln- eller datorflödestelemetri, dator- och datorgruppsanvändning och granskningsloggar. Power BI-instrumentpanelen för Automation Kit visar den här informationen.

## Vad har förändrats

Som en del av lösningen [[Automation Kit – Funktion]: Azure Key Vault alternativ för satellitmiljöer](https://github.com/microsoft/powercat-automation-kit/issues/84) Azure Key Vault krävs inte längre. Detta är viktigt eftersom det avsevärt minskar installationens komplexitet och hur säkerheten hanteras för att hämta lösningsartefakter när du använder Automation Solution Manager.

## Vad är detsamma?

När nyckelelementen är desamma som de äldre versionerna före april 2023 och april 2023 är behovet av ett Azure Active Directory program.

En [Programmets användare](https://learn.microsoft.com/power-platform/admin/manage-application-users) är en typ av användare i Power Platform som identifieras genom att attributet ApplicationId finns i systemanvändarposten. Programanvändare skapas i Azure Active Directory (Azure AD) och används för att autentisera och auktorisera åtkomst till Power Platform. De används vanligtvis för att representera ett program eller en tjänst som behöver komma åt data eller utföra åtgärder i Power Platform för användare eller andra program.

Programanvändaren används av Automation Solution Manager så att du kan fråga lösningskomponenterna i en miljö så att du kan göra det möjligt för en användare att mäta en distribuerad Power Platform lösning.

## Installera

Den [Installera kommandoraden](/sv/get-started/install) för satellitlösningar kommer att be dig om Azure Active Directory programnamn och Azure Active Directory program-ID. Med hjälp av denna information kommer den att:

1. Lägga till Azure Active Directory som programanvändare
1. Lägga till programanvändaren i rollen Systemadministratör
1. Lägg till användar-ID för programanvändaren i miljövariabeln **Solution Manager-artefakter som läses användar-ID**

Den nya rollen dataverse roll **Användare av Automation Solution Manager** har lagts till som gör att användare kan anropa det nya anpassade API:et Dataverse GetDataverseSolutionArtifacts som frågar lösningsartefakter med hjälp av den angivna miljövariabeln **Solution Manager-artefakter som läses användar-ID**.

Om du vill installera satelitte-lösningen manuellt måste följande ändringar göras i [Ställ in satelliter](https://learn.microsoft.com/en-us/power-automate/guidance/automation-kit/setup/satellite) instruktioner.

1. Hoppa över steget "Lägg till en ny klienthemlighet" eftersom detta inte längre behövs för april 2023 eller senare.
1. Hoppa över steget för att skapa hemligheter i Azure Key Vault.
1. Lägg till användar-ID för programanvändaren i **Solution Manager-artefakter som läses användar-ID** miljövariabel.

## Efter installationen

Se till att användare som ska köra Automation Solution Manager-programmet beviljas **Användare av Automation Solution Manager** Dataverse säkerhetsroll.

## Tidigare utgåvor

Före lanseringen i april 2023 krävde installationer av satellitlösningen miljövariabler av typen hemlig. Detta krävde en [Azure Key Vault](https://learn.microsoft.com/power-apps/maker/data-platform/environmentvariables#use-azure-key-vault-secrets-preview) för att lagra värdena för Klientorganisations-ID, Program-ID och Programhemlighet. För att använda den här funktionen krävs också [Prerequistes](https://learn.microsoft.com/en-us/power-apps/maker/data-platform/environmentvariables#prerequisites) av Azure Key Vault är im samma klientorganisation, konfiguration av Microsoft.PowerPlatform som resursprovider.

I versionerna från mars 2023 eller äldre användes Azure Key Vault för att lagra ett klientorganisations-ID, APplications-ID och programhemlighet. Med hjälp av dessa värden begärdes en åtkomsttoken för att fråga dataverse så att den kunde returnera listan över lösningskomponenter.

## Rekommendationer

För befintliga användare rekommenderar vi att du förenklar pågående hantering och tar bort behovet av ett beroende av Azure Key Vault att du uppgraderar den befintliga satellitinstallationen till april 2023 eller senare för att dra nytta av de nya funktionerna.
