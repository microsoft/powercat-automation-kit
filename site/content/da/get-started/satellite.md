---
title: "Satellit - Kom godt i gang"
description: "Automation Kit - Satellit - Kom godt i gang"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Satellite']
generated: 425608BE149AA6D640338A5F34EB704ADDAAAEF5
---

# Overblik

Velkommen til startsiden for satellitløsningen. Dette afsnit dækker vigtige ændringer, der er foretaget i april 2023 og senere udgivelser. Efter april 2023 har vi fjernet behovet for, at Azure Key Vault gemmer oplysninger om Azure Application tenant, Application ID og Azure Application Secret.

## Konceptuelt design

Vores læringsside skitserer [Konceptuelt design](https://learn.microsoft.com/power-automate/guidance/automation-kit/overview/introduction#conceptual-design) af {{<product-name>}}. Nøgleelementet i løsningen er det Power Platform hovedmiljø.

Der er normalt flere satellitproduktionsmiljøer, der kører dine automatiseringsprojekter. Afhængigt af din miljøstrategi kan disse også være udviklings- eller testmiljøer.

Mellem disse miljøer er der en synkroniseringsproces i næsten realtid, der omfatter cloud- eller desktopflowtelemetri, brug af maskin- og maskingrupper og overvågningslogfiler. Power BI-dashboardet til Automation Kit viser disse oplysninger.

## Hvad har ændret sig

Som en del af løsningen [[Automation Kit – funktion]: Azure Key Vault-alternativ til satellitmiljøer](https://github.com/microsoft/powercat-automation-kit/issues/84) Azure Key Vault er ikke længere påkrævet. Dette er vigtigt, da det reducerer kompleksiteten af installationen betydeligt, og hvordan sikkerheden administreres for at hente løsningsartefakter, når du bruger Automation Solution Manager.

## Hvad er det samme?

Når nøgleelementerne er de samme, er de ældre udgivelser før april 2023 og april 2023 behovet for et Azure Active Directory-program.

En [Applikationsbruger](https://learn.microsoft.com/power-platform/admin/manage-application-users) er en type bruger i Power Platform, der identificeres ved tilstedeværelsen af attributten ApplicationId i systembrugerposten. Programbrugere oprettes i Azure Active Directory (Azure AD) og bruges til at godkende og godkende adgang til Power Platform. De bruges typisk til at repræsentere et program eller en tjeneste, der skal have adgang til data eller udføre handlinger i Power Platform på vegne af brugere eller andre applikationer.

Programbrugeren bruges specifikt af Automation Solution Manager til at give dig mulighed for at forespørge på løsningskomponenterne i et miljø, så du kan gøre det muligt for en bruger at måle en installeret Power Platform løsning.

## Installere

Den [Installation af kommandolinje](/da/get-started/install) for satellitløsninger beder dig om Azure Active Directory-programnavnet og Azure Active Directory-program-id'et. Ved hjælp af disse oplysninger vil den:

1. Tilføj Azure Active Directory-programmet som programbruger
1. Føj programbrugeren til rollen Systemadministrator
1. Føj programbrugerens bruger-id til miljøvariablen **Løsningsstyringsartefakter Læs bruger-id**

Dataverse-rollen i den nye rolle **Bruger af Automation Solution Manager** er blevet tilføjet, der giver brugerne mulighed for at kalde den nye brugerdefinerede API Dataverse GetDataverseSolutionArtifacts, der forespørger på løsningsartefakter ved hjælp af den angivne miljøvariabel **Løsningsstyringsartefakter Læs bruger-id**.

Hvis du ønsker at installere satelitte-løsningen manuelt, skal der foretages følgende ændringer i [Opsæt satellitter](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/satellite) Instruktioner.

1. Spring trinnet "Tilføj en ny klienthemmelighed" over, da dette ikke længere er nødvendigt for april 2023 eller nyere.
1. Spring trinnet over for at oprette hemmeligheder i Azure Key Vault.
1. Føj programbrugerens bruger-id til ikonet **Løsningsstyringsartefakter Læs bruger-id** miljø variabel.

## Efter installation

Sørg for, at den eller de brugere, der skal køre programmet Automation Solution Manager, tildeles **Bruger af Automation Solution Manager** Dataverse-sikkerhedsrolle.

## Tidligere udgivelser

Før udgivelsen i april 2023 krævede installationer af satellitløsningen miljøvariabler af typen hemmelige. Dette krævede en [Azure Key Vault](https://learn.microsoft.com/power-apps/maker/data-platform/environmentvariables#use-azure-key-vault-secrets-preview) for at gemme værdierne for lejer-id, program-id og programhemmelighed. For at bruge denne funktion kræves også [Prerequistes](https://learn.microsoft.com/power-apps/maker/data-platform/environmentvariables#prerequisites) af Azure Key Vault, der er im den samme lejer, konfiguration af Microsoft.PowerPlatform som ressourceudbyder.

I marts 2023-versionerne eller ældre blev Azure Key Vault brugt til at gemme et lejer-id, APplications-id og programhemmelighed. Ved hjælp af disse værdier blev der anmodet om et adgangstoken til at forespørge på dataverse, så det kunne returnere listen over løsningskomponenter.

## Anbefalinger

For eksisterende brugere anbefales det at forenkle den løbende administration og fjerne behovet for en afhængighed af Azure Key Vault, at du opgraderer den eksisterende satellitinstallation til april 2023 eller nyere for at drage fordel af de nye funktioner.
