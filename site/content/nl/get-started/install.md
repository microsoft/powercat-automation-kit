---
title: "Installatie op de opdrachtregel"
description: "Automation Kit - Installeren"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Install']
generated: 10CE5DBCADF4F09FCAA4261FD8FBEBDE34B6FB2E
---

Als u de nieuwste versie van de Automation Kit wilt installeren via de opdrachtregel, kunt u de onderstaande stappen uitvoeren. Als u de opdrachtregelprogramma's niet kunt gebruiken, kunt u de handmatige stappen gebruiken die zijn beschreven in [Richtlijnen voor het instellen](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/prerequisites).

1. Zorg ervoor dat je <a ref='https://learn.microsoft.com/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature' target="_blank">De frameworkfunctie voor Power Apps-onderdelen inschakelen</a> in de omgevingen waarin u de Automation Kit voor zowel hoofd- als satellietomgevingen wilt installeren.

1. Zorg ervoor dat de <a href="https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1?tab=Reviews" target="_blank">Creator Kit geïnstalleerd</a> in de omgevingen waarin u wilt installeren

1. Open de nieuwste versie van de <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">Automation Kit GitHub-releases</a>

1. Download de **AutomationKitInstalleer.zip** in de sectie Activa

1. Selecteer in Windows Verkenner de gedownloade **AutomationKitInstalleer.zip** en open het dialoogvenster met eigenschappen

1. Selecteer de **Deblokkeren** knoop

1. Selecteren **AutomationKitInstalleer.zip** en gebruik het contextmenu om **Alles extraheren**

1. Zorg ervoor dat u de <a href="https://learn.microsoft.com/power-platform/developer/cli/introduction" target="_blank">Power Platform CLI</a> Geïnstalleerd

1. Voer het powershell-script uit met behulp van de volgende opdrachtregel

```cmd
cd AutomationKitInstall
powershell Install_AutomationKit.ps1
```

NOTITIE:
1. Afhankelijk van uw PowerShell-uitvoeringsbeleid moet u mogelijk de volgende opdracht uitvoeren

```cmd
Unblock-File Install_AutomationKit.ps1
```

1. Het PowerShell-script vraagt u een installatieconfiguratiebestand te maken met behulp van [Setup installeren](/nl/get-started/setup). De configuratiepagina's voor de installatie bieden u het volgende

    - Selecteer configuratie voor hoofd- of satellietoplossingen
   
    - Gebruikers selecteren om toe te wijzen aan beveiligingsgroepen
   
    - Verbindingen maken die nodig zijn om de oplossing te installeren
    
    - Omgevingsvariabelen definiëren
    
    - Optioneel definiëren of voorbeeldgegevens moeten worden geïmporteerd
    
    - Optioneel Power Automate-stromen inschakelen in de oplossingen moet zijn ingeschakeld

1. Nadat u de stappen voor het instellen van de website hebt voltooid, kunt u gedownloade **automation-kit-main-install.json** of **automation-kit-satellite-install.json** bestand naar de **AutomationKitInstalleer** map boven

1. Zodra het bestand is gedownload, zal het script vragen om **y** om de hoofdoplossing te installeren, **n** om satellietoplossing te installeren

1. De installatie zal dan uploaden start de installatie met de gedefinieerde instellingen

## Terugkoppeling

Wilt u feedback geven op de [installatieproces](/nl/get-started/setup)? De onderstaande vragen helpen ons het proces te verbeteren.

{{<questions name="/content/nl/get-started/setup-feedback.json" completed="Bedankt voor het geven van feedback" showNavigationButtons="false" locale="nl">}}
