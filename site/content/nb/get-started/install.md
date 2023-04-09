---
title: "Kommandolinje Installer"
description: "Automatiseringssett - Installer"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Install']
generated: BBA164EE25537E568BEC4EE4FC9CAA168C26E18B
---

Hvis du vil installere den nyeste versjonen av automatiseringssettet ved hjelp av kommandolinjen, kan du bruke følgende trinn nedenfor. Hvis du ikke kan bruke kommandolinjeverktøyene, kan du bruke de manuelle trinnene som er dokumentert i [Veiledning for oppsett](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/prerequisites).

1. Sørg for at du har <a ref='https://learn.microsoft.com/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature' target="_blank">Aktivere Power Apps-komponentrammeverkfunksjonen</a> i miljøene du vil installere automatiseringssettet for både hoved- og satellittmiljøer.

1. Sørg for at <a href="https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1?tab=Reviews" target="_blank">Creator Kit installert</a> i miljøene du vil installere i

1. Åpne den nyeste versjonen fra <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">Utgivelser av automatiseringssett GitHub</a>

1. Last ned **AutomationKitInstall.zip** fra delen Aktiva

1. I Windows Utforsker velger du den nedlastede **AutomationKitInstall.zip** og åpne dialogboksen Egenskaper

1. Velg ikonet **Oppheve** knapp

1. Velge **AutomationKitInstall.zip** og bruk kontekstmenyen til å **Pakk ut alle**

1. Sørg for at du har <a href="https://learn.microsoft.com/power-platform/developer/cli/introduction" target="_blank">Power Platform CLI</a> Installert

1. Utfør powershell-skriptet ved hjelp av følgende kommandolinje

```cmd
cd AutomationKitInstall
powershell Install_AutomationKit.ps1
```

NOTAT:
1. Avhengig av din PowerShell-kjøringspolicy må du kanskje kjøre følgende kommando

```cmd
Unblock-File Install_AutomationKit.ps1
```

1. PowerShell-skriptet vil be deg om å opprette en installasjonskonfigurasjonsfil ved hjelp av [Installasjonsprogrammet](/nb/get-started/setup). Oppsettkonfigurasjonssidene gir deg følgende

    - Velg konfigurasjon for hoved- eller satellittløsninger
   
    - Velg brukere du vil tilordne til sikkerhetsgrupper
   
    - Opprette tilkoblinger som kreves for å installere løsningen
    
    - Definere miljøvariabler
    
    - Eventuelt definere om eksempeldata skal importeres
    
    - Eventuelt Aktiver Power Automate-flyter i løsningene bør være aktivert

1. Når du har fullført konfigurasjonstrinnene for webområdet, kan du kopiere nedlastede **automatisering-kit-main-install.json** eller **automatisering-kit-satellitt-install.json** -filen til **AutomationKitInstall** mappen ovenfor

1. Når filen er lastet ned skriptet vil be om **y** for å installere hovedløsningen, **n** Slik installerer du satellittløsning

1. Installasjonen vil deretter laste opp starte installasjonen med de definerte innstillingene

## Tilbakemelding

Ønsker å gi tilbakemelding på [Installasjonsprosess](/nb/get-started/setup)? Spørsmålene nedenfor hjelper oss med å forbedre prosessen.

{{<questions name="/content/nb/get-started/setup-feedback.json" completed="Takk for at du gir tilbakemelding" showNavigationButtons="false" locale="nb">}}
