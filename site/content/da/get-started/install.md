---
title: "Installere"
description: "Automationssæt - Installer"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Install']
generated: 458A6A6E57855817B73D18C0F0A5855DDAFC40DE
---

For at installere den nyeste version af Automation Kit skal du bruge følgende trin nedenfor. Hvis du ikke kan bruge kommandolinjeværktøjerne, kan du bruge de manuelle trin, der er beskrevet i [Vejledning til opsætning](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/prerequisites).

1. Sørg for, at du har <a ref='https://learn.microsoft.com/en-us/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature' target="_blank">Aktivere Power Apps-komponentstrukturfunktionen</a> i de miljøer, du vil installere automatiseringspakken til både hoved- og satellitmiljøer.

1. Sørg for, at <a href="https://appsource.microsoft.com/en-us/product/dynamics-365/microsoftpowercatarch.creatorkit1?tab=Reviews" target="_blank">Creator Kit installeret</a> ind i de miljøer, du ønsker at installere i

1. Åbn den seneste version fra <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">Automation Kit GitHub-udgivelser</a>

1. Download **AutomationKitInstall.zip** fra afsnittet Aktiver

1. I Windows Stifinder skal du vælge den downloadede **AutomationKitInstall.zip** , og åbn dialogboksen egenskaber

1. Vælg ikonet **Unblock** knap

1. Markere **AutomationKitInstall.zip** og brug kontekstmenu til at **Uddrag Alle**

1. Sørg for, at du har <a href="https://learn.microsoft.com/en-us/power-platform/developer/cli/introduction" target="_blank">Power Platform CLI</a> Installeret

1. Udfør powershell-scriptet ved hjælp af følgende kommandolinje

```cmd
cd AutomationKitInstall
powershell Install_AutomationKit.ps1
```

SEDDEL:
1. Afhængigt af din PowerShell-udførelsespolitik skal du muligvis køre følgende kommando

```cmd
Unblock-File Install_AutomationKit.ps1
```

1. PowerShell-scriptet beder dig om at oprette en installationskonfigurationsfil ved hjælp af [Installer opsætning](/da/get-started/setup). Konfigurationssiderne for opsætning giver dig følgende

    - Vælg konfiguration til hoved- eller satellitløsninger
   
    - Vælg brugere, der skal tildeles til sikkerhedsgrupper
   
    - Opret forbindelser, der kræves for at installere løsningen
    
    - Definere miljøvariabler
    
    - Definer valgfrit, om eksempeldata skal importeres
    
    - Aktivér Power Automate-flow, der er indeholdt i løsningerne, skal være aktiveret

1. Når du har fuldført opsætningen, kopieres **automation-kit-main-install.json** eller **automation-kit-satellite-install.json** fil til **AutomationKitInstaller** mappe ovenfor

1. Når filen er downloadet, vil scriptet bede om **y** at installere hovedløsningen, **n** Sådan installeres satellitløsning

1. Installationen uploader derefter starten af installationen med de definerede indstillinger

## Feedback

Ønsker at give feedback på [opsætningsproces](/da/get-started/setup)? Spørgsmålene nedenfor hjælper os med at forbedre processen.

{{<questions name="/content/da/get-started/setup-feedback.json" completed="Tak, fordi du gav feedback" showNavigationButtons=true locale="da">}}
