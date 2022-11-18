---
title: "Migracja RPA"
description: "Automation Kit - migracja RPA"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Migration', 'Guidance']
generated: 42940454F8C75C0160E5E7D94767DD18DFFC13C6
---

{{<toc>}}

<br/>

Na {{<product-name>}} **Moduł migracji** Zapewnia sprawdzony zestaw narzędzi i wskazówek opartych na kontaktach z klientami, aby przyspieszyć migrację. Wykorzystując możliwości Microsoft Power Platform, Microsoft Azure i szerszych usług Microsoft Cloud, możesz:

- Zrealizuj swoje cele polegające na zapewnieniu oszczędności.

- Zapewnienie barier ochronnych do planowania, migracji, monitorowania i konfigurowania modelu operacyjnego do bieżącego użytkowania.

- Wykorzystaj próbki konwersji, które możesz dostosować do swoich potrzeb w zakresie migracji.

## Migracja RPA Pierwsze kroki

![Przewodnik liderów biznesu po migracji do zrobotyzowanej automatyzacji procesów (RPA).](https://msflowblogscdn.azureedge.net/wp-content/uploads/2022/01/RPAWhitepaper_Img-241x300.png)

Możesz użyć poniższego łącza, aby zrozumieć proces migracji RPA dla Power Platform firmy Microsoft:

- [Sprawdzone metody modernizacji podejścia RPA za pomocą usługi Power Automate](https://powerautomate.microsoft.com/blog/proven-methods-to-modernize-your-rpa-approach-with-power-automate/)

- Oficjalny dokument do pobrania [Przewodnik liderów biznesu po migracji do zrobotyzowanej automatyzacji procesów (RPA).](https://aka.ms/PAD/RPAMigrationWhitepaper)

## Obszary zainteresowania

Poniższa lista zawiera przegląd obszarów, które priorytetowo traktujemy do uwzględnienia w zestawie Automation Kit, abyśmy mogli ulepszyć składniki, których można użyć podczas migracji.

> UWAGA: Te obszary zainteresowania mogą ulec znacznym zmianom. Zmiany te będą miały miejsce, stale otrzymujemy informacje zwrotne i ustalamy priorytety funkcji, aby spełnić potrzeby klientów

### Planowanie

- **Ocena** komponenty, które pomagają w fazie planowania, aby pomóc w określeniu, które rozwiązania automatyzacji z inwentarza automatyzacji należy migrować, aby uzyskać najlepszy początkowy wpływ.

### Zarządzanie i nadzór

- **Zwrot z inwestycji** ramy gromadzenia i monitorowania zwrotu z inwestycji w program pracy w zakresie migracji, tak aby zainteresowane strony były zaangażowane w proces migracji i mogły zmierzyć jego wpływ.

- **Rządzenie** Zestaw komponentów i wskazówek, które pomagają w cyklu życia aplikacji, dokumentacji i bieżącym monitorowaniu operacyjnym migrowanych rozwiązań.

### Konwersja

- **Integracja z chmurą** przykładowe komponenty, które można wykorzystać do przyspieszenia procesu konwersji w celu migracji rozwiązań do Power Platform, Microsoft Cloud.

- **Wymagania niefunkcjonalne** obejmujące podejście do testowania jakości, monitorowanie DevOps, dokumentację migrowanych rozwiązań

### Centrum Doskonałości Automatyzacji

Łącząc Power Automation Migration z Automation Center of Excellence, istnieje zestaw umiejętności Migration Developer, które pokrywają się z zestawem Automation Kit i akceleratorem ALM.

![Centrum Doskonałości Automatyzacji](/images/illustrations/automation-kit-migration.svg)

#### Deweloper migracji

Patrząc konkretnie na proces Migration Developer

{{<border>}}

![Automation Center of Excellence - Migration Developer](/images/illustrations/automation-kit-migration-developer.svg)

{{</border>}}

##### Ocena i planowanie

Ocena i plan rozpoczyna się od bezpłatnego skanowania istniejących inwestycji w automatyzację przy użyciu [Systemy BluePrint](https://www.blueprintsys.com/) w celu określenia bieżącej złożoności i zakresu. Korzystanie z tych informacji pomoże zaplanować początkowy zestaw rozwiązań automatyzacji, które można migrować do programu Power Automate Desktop.Using these information will help plan for the initial set of automation solutions that can be migrated to Power Automate Desktop.

##### Migrować

Proces migracji ze źródłowego systemu migracji do równoważnych akcji programu Power Automate Desktop. Wszelkie działania, które wymagają przejrzenia i zaktualizowania przez Dewelopera migracji, zostaną oznaczone jako komentarze TODO, aby można było łatwo zidentyfikować pozostałą pracę.

##### Kompilacja Finalizacja

Korzystając ze zidentyfikowanych komentarzy TODO, deweloper migracji wykonuje pozostałe kroki migracji, aby rozwiązanie działało w programie Power Automate Desktop.

##### Proces wdrażania

Korzystając z akceleratora ALM, rozwiązania można przenieść ze środowisk programistycznych do produkcyjnych, stosując sprawdzoną weryfikację, aby upewnić się, że elementy TODO zostały usunięte, a kontrole systemu docelowego i DLP zostały zastosowane.

Z punktu widzenia konserwacji można nadal stosować bieżące reguły zarządzania DLP i sprawdzania poprawności w celu dostrajania i aktualizowania wdrożonych rozwiązań w miarę upływu czasu.

#### Inne warstwy

Moduły migracji opierają się na istniejących wytycznych i narzędziach do obsługi ALM, komponentów infrastruktury wraz z bezpieczeństwem i ładem oraz raportowaniem operacyjnym i analizą.
