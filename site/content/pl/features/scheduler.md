---
title: "Harmonogram"
description: "Automation Kit - Scheduler"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: 00B15DA73732A60B73A09229CEF9B843E259A121
---

{{<toc>}}

## Wprowadzenie

Harmonogram zestawu Automation Kit umożliwia wyświetlanie harmonogramu cyklicznych przepływów Power Automate Cloud wewnątrz rozwiązań, które obejmują wywołania przepływów programu Power Automate Desktop.

Ta funkcja została wprowadzona jako część [luty 2023](/pl/releases/february-2023), Późniejsze wersje będą nadal ulepszać i rozwijać funkcjonalność harmonogramu.

{{<border>}}
![Harmonogram](/images/schedule.png)
{{</border>}}

Kluczowe funkcje harmonogramu to:

- Możliwość przeglądania harmonogramu cyklicznych przepływów w chmurze
- Wyświetlanie harmonogramu według widoku Dzień, Tydzień, Miesiąc i Harmonogram
- Wyświetlanie stanu zaplanowanych przepływów (Powodzenie, Niepowodzenie lub Zaplanowane)
- Wyświetlanie czasu trwania uruchomienia usługi Cloud Flow
- Wyświetl szczegóły wszelkich błędów.

## Notatki

W przypadku bieżącej wersji obowiązują następujące uwagi

1. Wyświetlane są tylko rozwiązania Power Automate Desktop i Power Automate zawarte w rozwiązaniu
1. Co najmniej jeden program Power Automate Desktop został zarejestrowany i wykonany

## Instalować

Aby zainstalować rozwiązanie harmonogramu, możesz wykonać następujące czynności:

1. Zapewnianie struktury składników Power Apps <a href="https://learn.microsoft.com/en-us/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">Czytaj całość</a>
1. Zestaw twórców został zainstalowany w środowisku docelowym. <a href="https://appsource.microsoft.com/en-us/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">Instalowanie ze źródła aplikacjiInstall from App Source</a>
1. Plik AutomationKit.zip został pobrany z sekcji Zasoby najnowszej wersji <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">Wydanie usługi GitHub</a>
1. Zaimportowano najnowszą wersję AutomationKitScheduler_*_zarządzane.zip plik za pomocą. <a href='https://learn.microsoft.com/en-us/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">Czytaj całość</a>

## Mapa drogowa

Możesz odwiedzić nasze <a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">Problemy z usługą GitHub</a> , aby wyświetlić proponowane nowe funkcje.

Możesz dodać nowy <a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">Żądanie funkcji harmonogramu</a>

## Sprzężenie zwrotne

{{<questions name="/content/pl/features/scheduler.json" completed="Dziękujemy za przekazanie opinii" showNavigationButtons="false" locale="pl">}}
