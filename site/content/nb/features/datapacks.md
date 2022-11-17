---
title: "Datapakker"
description: "Automatiseringssett – datapakker"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 59DCC2AA961720CBEBCC57AD3C8C2B774F7B3FD1
---

{{<toc>}}

## Introduksjon

Datapakker er ferdigpakkede sett med data som eventuelt kan installeres i det installerte automatiseringssettet for å få fart på bruken.

{{<border>}}
![Oversikt over datapakker](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks.svg)
{{</border>}}

<br/>

Introdusert som en del av [desember 2022](/nb/releases/november-2022), gir datapakker deg muligheten til å importere eksempeldata valgfritt.

Med datapakken Avkastning på investering (ROI) kan du raskt demonstrere planlegging, måling og overvåking av avkastning på investeringen via Automation Kit Power BI-instrumentbordet. Du kan laste inn din første datapakke ved hjelp av [Komme i gang](/nb#getting-started) nedenfor.

Overtid vil vi legge til andre datapakker i etterslepet for prioritering og dokumentere hvordan du kan samarbeide om publisering av datapakker til fellesskapet.

## Veikart

{{<border>}}
![Veikart for datapakker](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks-WhatsNext.svg?v=1)
{{</border>}}

<br/>

I fremtidige milepæler vil vi prøve å forbedre datapakkene ved å inkludere dem som en valgfri del av den automatiserte installasjonsprosessen for automatiseringssett.

Muligheten til å inkludere datapakker som en del av installasjonen vil tillate en nettbasert installasjon, i stedet for kommandolinjeinstallasjonsprosessen for denne utgivelsen.

## Avkastning på investeringen Hovedløsning

Return on Investment (ROI)-datapakken for hovedløsningen inkluderer automatiseringsprosjekter, maskiner og eksempel på Power Automate Desktop-telemetri, slik at du kan få tak i den fullstendige prosessen.

### Komme i gang

Slik kommer du i gang med denne datapakken

- Installer skapersettet fra [App-kilde](https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1) eller via [Veiledning for å lære konfigurering](https://learn.microsoft.com/power-platform/guidance/creator-kit/setup)

- Installer den nyeste versjonen av Automation Kit Main fra [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases) Bruke [Veiledning for å lære konfigurering](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/main)

- Installer Power Platform kommandolinjegrensesnitt ved hjelp av [Veiledning for å lære konfigurering](https://learn.microsoft.com/power-platform/developer/cli/introduction)

- Opprett godkjenning i miljøet

```pwsh
pac auth create --url https://contoso.crm.dynamics.com/
```

- Last ned **Automatiseringssett.zip** fra [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases)

- Pakk ut filen **AutomationKit-SampleData.zip** fra **Automatiseringssett.zip**

- Importere dataene til miljøet

```pwsh
pac data import -d AutomationKit-SampleData.zip --environment https://contoso.crm.dynamics.com/ 
```

- Koble til Power BI-instrumentbordet som er lastet ned fra, med miljøet for å utforske de importerte dataene. Bruk [Installere Power BI-instrumentbord](/nb/get-started/install-powerbi-dashboard) for mer informasjon

## Tilbakemelding

{{<questions name="/content/nb/features/datapacks.json" completed="Takk for at du gir tilbakemelding" showNavigationButtons="false" locale="nb">}}
