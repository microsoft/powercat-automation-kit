---
title: "Satellite - Pierwsze kroki"
description: "Automation Kit - Satellite - Pierwsze kroki"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Satellite']
generated: 6883D16022FA80683F6DFF779929B1FC8B73E83F
---

# Przegląd

Witamy na stronie startowej rozwiązania satelitarnego. W tej sekcji omówiono ważne zmiany wprowadzone w kwietniu 2023 r. i późniejszych wersjach. Po kwietniu 2023 r. usunęliśmy konieczność przechowywania w usłudze Azure Key Vault informacji o dzierżawie aplikacji platformy Azure, identyfikatorze aplikacji i wpisach tajnych aplikacji platformy Azure.

## Projekt koncepcyjny

Nasza strona szkoleniowa przedstawia [Projekt koncepcyjny](https://learn.microsoft.com/power-automate/guidance/automation-kit/overview/introduction#conceptual-design) z {{<product-name>}}. Kluczowym elementem rozwiązania jest Power Platform główne środowisko.

Zwykle istnieje kilka środowisk produkcji satelitarnej, które obsługują projekty automatyzacji. W zależności od strategii środowiska mogą to być również środowiska programistyczne lub testowe.

Między tymi środowiskami istnieje proces synchronizacji w czasie zbliżonym do rzeczywistego, który obejmuje telemetrię przepływu w chmurze lub na pulpicie, użycie maszyny i grupy maszyn oraz dzienniki inspekcji. Pulpit nawigacyjny usługi Power BI dla zestawu Automation Kit wyświetla te informacje.

## Co się zmieniło

W ramach rozwiązywania problemów [[Zestaw Automation Kit — funkcja]: alternatywa usługi Azure Key Vault dla środowisk satelitarnych](https://github.com/microsoft/powercat-automation-kit/issues/84) Usługa Azure Key Vault nie jest już wymagana. Jest to ważne, ponieważ znacznie zmniejsza złożoność instalacji i sposób zarządzania zabezpieczeniami w celu uzyskania artefaktów rozwiązania podczas korzystania z Menedżera rozwiązań automatyzacji.

## Co jest takie samo?

Gdy kluczowe elementy są takie same, starsze wersje sprzed kwietnia 2023 r. i kwietnia 2023 r. są potrzebne aplikacji usługi Azure Active Directory.

A [Użytkownik aplikacji](https://learn.microsoft.com/power-platform/admin/manage-application-users) jest typem użytkownika w Power Platform identyfikowanym przez obecność atrybutu ApplicationId w systemowym rekordzie użytkownika. Użytkownicy aplikacji są tworzeni w usłudze Azure Active Directory (Azure AD) i służą do uwierzytelniania i autoryzowania dostępu do Power Platform. Są one zwykle używane do reprezentowania aplikacji lub usługi, która musi uzyskiwać dostęp do danych lub wykonywać operacje w Power Platform w imieniu użytkowników lub innych aplikacji.

W szczególności użytkownik aplikacji jest używany przez Menedżera rozwiązań automatyzacji, aby umożliwić wysyłanie zapytań do składników rozwiązania w środowisku, dzięki czemu można umożliwić użytkownikowi pomiar wdrożonego rozwiązania Power Platform.

## Instalować

Ten [Instalacja z wiersza poleceń](/pl/get-started/install) dla rozwiązań satelitarnych wyświetli monit o podanie nazwy aplikacji usługi Azure Active Directory i identyfikatora aplikacji usługi Azure Active Directory. Korzystając z tych informacji, będzie:

1. Dodawanie aplikacji usługi Azure Active Directory jako użytkownika aplikacjiAdd the Azure Active Directory application as an Application User
1. Dodawanie użytkownika aplikacji do roli administratora systemu
1. Dodawanie identyfikatora użytkownika aplikacji do zmiennej środowiskowej **Artefakty menedżera rozwiązań odczytują identyfikator użytkownika**

Nowa rola dataverse roli **Użytkownik usługi Automation Solution Manager** został dodany, który umożliwia użytkownikom wywoływanie nowego niestandardowego interfejsu API Dataverse GetDataverseSolutionArtifacts, który będzie wysyłać zapytania do artefaktów rozwiązania przy użyciu dostarczonej zmiennej środowiskowej **Artefakty menedżera rozwiązań odczytują identyfikator użytkownika**.

Jeśli chcesz zainstalować rozwiązanie satelity ręcznie, należy wprowadzić następujące zmiany w [Konfigurowanie satelitów](https://learn.microsoft.com/en-us/power-automate/guidance/automation-kit/setup/satellite) Instrukcje.

1. Pomiń krok "Dodaj nowy klucz tajny klienta", ponieważ nie jest on już potrzebny w kwietniu 2023 r. lub nowszym.
1. Pomiń krok tworzenia wpisów tajnych w usłudze Azure Key Vault.Skip the step to create Secrets in the Azure Key Vault.
1. Dodaj identyfikator użytkownika aplikacji do **Artefakty menedżera rozwiązań odczytują identyfikator użytkownika** zmienna środowiskowa.

## Po instalacji

Upewnij się, że użytkownikom, którzy będą uruchamiać aplikację Automation Solution Manager, przyznano **Użytkownik usługi Automation Solution Manager** Rola zabezpieczeń Dataverse.

## Poprzednie wydania

Przed wydaniem w kwietniu 2023 r. instalacje rozwiązania Satellite wymagały zmiennych środowiskowych typu secret. Wymagało to [Azure Key Vault](https://learn.microsoft.com/power-apps/maker/data-platform/environmentvariables#use-azure-key-vault-secrets-preview) , aby zapisać wartości identyfikatora dzierżawy, identyfikatora aplikacji i klucza tajnego aplikacji. Aby korzystać z tej funkcji, wymagane jest również [Wymagania wstępne](https://learn.microsoft.com/en-us/power-apps/maker/data-platform/environmentvariables#prerequisites) usługi Azure Key Vault jest tą samą dzierżawą, konfiguracja Microsoft.PowerPlatform jako dostawcy zasobów.

W wersjach z marca 2023 r. lub starszych usługa Azure Key Vault była używana do przechowywania identyfikatora dzierżawy, identyfikatora APplication i klucza tajnego aplikacji. Korzystając z tych wartości, zażądano tokenu dostępu do zapytania dataverse, aby mógł zwrócić listę składników rozwiązania.

## Zalecenia

W przypadku istniejących użytkowników zaleca się uproszczenie bieżącego zarządzania i usunięcie potrzeby zależności usługi Azure Key Vault polegającej na uaktualnieniu istniejącej instalacji satelitarnej do kwietnia 2023 r. lub nowszej w celu skorzystania z nowych funkcji.
