---
title: "Pakiety danych"
description: "Automation Kit — pakiety danych"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 16D52F35701BF93D5BAB05162D94D9E9866918C6
---

{{<toc>}}

## Wprowadzenie

Pakiety danych to wstępnie spakowany zestaw danych, który można opcjonalnie zainstalować w zainstalowanym zestawie Automation Kit w celu przyspieszenia użycia.

{{<border>}}
![Omówienie pakietów danych](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks.svg)
{{</border>}}

<br/>

Wprowadzone w ramach [listopad 2022](/pl/releases/november-2022), pakiety danych umożliwiają opcjonalne importowanie przykładowych danych.

Pakiet danych zwrotu z inwestycji (ROI) umożliwia szybkie zademonstrowanie planowania, pomiaru i monitorowania zwrotu z inwestycji za pośrednictwem pulpitu nawigacyjnego zestawu Automation Kit Power BI. Pierwszy pakiet danych można załadować za pomocą przycisku [Wprowadzenie](/pl#getting-started) poniżej.

W nadgodzinach dodamy inne pakiety danych do zaległości w celu ustalenia priorytetów i udokumentowania, w jaki sposób można współpracować przy publikowaniu pakietów danych dla społeczności.

## Mapa drogowa

{{<border>}}
![Mapa drogowa pakietów danych](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks-WhatsNext.svg?v=1)
{{</border>}}

<br/>

W przyszłych kamieniach milowych będziemy starali się ulepszyć pakiety danych, włączając je jako opcjonalną część procesu automatycznej instalacji zestawu Automation Kit.

Możliwość dołączenia pakietów Data Pack jako części instalacji umożliwi instalację opartą na sieci Web, a nie proces instalacji wiersza polecenia w tej wersji.

## Główne rozwiązanie zwrotu z inwestycji

Pakiet danych głównego rozwiązania zwrotu z inwestycji (ROI) zawiera projekty automatyzacji, maszyny i przykładowe dane telemetryczne programu Power Automate Desktop, dzięki czemu można uzyskać dostęp do kompleksowego procesu.

### Wprowadzenie

Aby rozpocząć pracę z tym pakietem danych

- Zainstaluj Zestaw twórców z [Źródło aplikacji](https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1) lub przez [Dowiedz się więcej o konfiguracji](https://learn.microsoft.com/power-platform/guidance/creator-kit/setup)

- Zainstaluj najnowszą wersję Automation Kit Main z [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases) Za pomocą [Dowiedz się więcej o konfiguracji](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/main)

- Instalowanie interfejsu wiersza polecenia platformy Power Platform przy użyciu [Dowiedz się więcej o konfiguracji](https://learn.microsoft.com/power-platform/developer/cli/introduction)

- Tworzenie uwierzytelniania w środowisku

```pwsh
pac auth create --url https://contoso.crm.dynamics.com/
```

- Pobierz **AutomationKit.zip** z [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases)

- Wyodrębnij plik **AutomationKit-SampleData.zip** z **AutomationKit.zip**

- Importowanie danych do środowiska

```pwsh
pac data import -d AutomationKit-SampleData.zip --environment https://contoso.crm.dynamics.com/ 
```

- Połącz pulpit nawigacyjny usługi Power BI pobrany z Twojego środowiska, aby eksplorować zaimportowane dane. Używać [Instalowanie pulpitu nawigacyjnego usługi Power BICreate Power BI Dashboard](/pl/get-started/install-powerbi-dashboard) Więcej informacji

## Sprzężenie zwrotne

{{<questions name="/content/pl/features/datapacks.json" completed="Dziękujemy za przekazanie opinii" showNavigationButtons="false" locale="pl">}}
