---
title: "Zarządzanie cyklem życia aplikacji Power CAT (ALM)"
description: "Zestaw automatyki - ALM Power CAT"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['ALM', 'Guidance', 'PowerCAT']
generated: A0E76BCFAC2095473353C3F9B49077A67DC58228
---

{{<slideStyles>}}

<div class="optional">

Zestaw Automation Kit wykorzystuje [Akcelerator ALM](https://aka.ms/aa4pp) aby zapewnić funkcjonalność ALM dla rozwiązań, które obejmują Power Automate Desktop

</div>

{{<presentation slides="1,2">}}


<div class="optional">

{{<presentationStyles>}}

## Proces wdrażania usługi GitHub

Podobnie jak w przypadku innych zestawów zarządzanych przez Power CAT, {{<product-name>}} używa akceleratora ALM do wdrażania wydań w naszych publicznych wydaniach usługi GitHub.}} uses the ALM Accelerator, to deploy releases to our public GitHub releases.

Nasz wewnętrzny proces ma Power Platform środowisko dla rozwoju, testowania i produkcji. Gdy będziemy gotowi do wydania, nasze zintegrowane usługi GitHub Actions pakują zarządzane i niezarządzane rozwiązania wdrożeniowe wraz z informacjami o wersji automatycznie dla wersji roboczej usługi GitHub.Once we are ready for a release our integrated GitHub Actions, the managed and unmanaged deployment solutions along with release notes automatically for a GitHub Draft release.

Gdy wersja robocza jest gotowa, możemy opublikować nowe wersje lub poprawki w razie potrzeby.

### Co to oznacza dla Ciebie

Teraz, gdy mamy już tę automatyzację, zautomatyzowana wersja ALM ma następujące korzyści:

- Wgląd w cały kod źródłowy niskiego kodu, który składa się na Automation Kit, dzięki czemu możesz zbadać, w jaki sposób zbudowaliśmy zestaw.

- Usprawniony proces automatyzacji, który może szybko reagować na błędy lub problemy i w razie potrzeby dostarczać poprawki.

- Automatyczna kompilacja wszystkich błędów i funkcji, które są zawarte w wydaniu.

- Uwzględniamy Power Apps, Power Automate, Dataverse i Power Automate Desktop jako część naszego procesu ALM na potrzeby ciągłej integracji / ciągłego wdrażania.

## Mapa drogowa

Możesz zbadać nasze otwarte elementy zaległości związane z ALM w naszym [Rejestr problemów z GitHub](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm)

Ogólnie rzecz biorąc, opieramy się na istniejących gotowych funkcjach Power Platform i Microsoft DevOps razem ALM Accelerator. Ta kombinacja pozwala nam skupić się na konkretnych rozszerzeniach, które pomagają w hiperautomatyce.

## Sprzężenie zwrotne

{{<questions name="/content/pl/features/alm/powercat.json" completed="Dziękujemy za przekazanie opinii" showNavigationButtons="false" locale="pl">}}

</div>

{{<slide  id="slide1" audio="features/alm/powercat/overview.mp3" description="Power CAT ALM Overview" localImage="/images/illustrations/alm-roadmap-2022-11.svg" >}}

Zespół Power CAT używa akceleratora ALM do budowy i wdrażania każdego z naszych [Zwalnia](https://github.com/microsoft/powercat-automation-kit/releases).

Każda wersja promuje zmiany od naszego rozwoju do środowisk testowych i produkcyjnych. Rozwiązania Power Platform wewnątrz zestawu używają zautomatyzowanego procesu do pakowania zasobów do wdrożenia w publicznych wydaniach GitHub.The  solutions inside the kit use an automated process to package assets for deployment to public GitHub releases.

W przyszłych kamieniach milowych będziemy rozwijać istniejącą platformę [Funkcje ALM](/pl/features/alm) , aby podać przykłady uwzględniania reguł sprawdzania poprawności i wizualnego porównania próbek RPA w ramach procesu DevOps.  

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/powercat/release-process.mp3" description="Power CAT Automation Kit Release Checker" localImage="/images/illustrations/alm-powercat-process.svg" >}}

Poniżej przedstawiono kluczowe kroki w procesie wydawania zestawu Automation Kit:

1. Zmiany wprowadzone w naszym środowisku Power Platform Dev są zapisywane w gałęzi w publicznym repozytorium GitHub

2. Gdy zmiany są gotowe do włączenia do wersji testowej, są scalane z główną gałęzią za pomocą żądania ściągnięcia. Przed ukończeniem żądania ściągnięcia potok sprawdzania poprawności usługi Azure DevOps musi zostać pomyślnie ukończony, a żądanie ściągnięcia przejrzane.

3. Gdy żądanie ściągnięcia przejdzie automatyczne kontrole i otrzyma zatwierdzenie przeglądu, może zostać połączone z główną gałęzią. To scalanie wyzwala testowy potok kompilacji usługi Azure DevOps, który publikuje kompilację zarządzaną w środowisku Power Platform testowego.

4. Po testach wewnętrznych potok produkcyjny usługi Azure DevOps jest wyzwalany ręcznie w celu wygenerowania wdrożenia Power Platform produkcyjnego.

5. Gdy wersja jest gotowa, potok Azure DevOps tworzy wersję roboczą zawierającą informacje o wersji i zasoby kompilacji. Ostateczna kompilacja wydania zamknie wszystkie otwarte problemy i zamknie kamień milowy. Opublikowany tag kompilacji repozytorium GitHub z zastosowaną etykietą Miesiąc i rok.

{{</slide>}}
