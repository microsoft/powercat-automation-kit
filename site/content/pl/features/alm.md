---
title: "Zarządzanie cyklem życia aplikacji (ALM)"
description: "Zestaw automatyki - ALM"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['ALM', 'Guidance']
generated: D3A4F6D207C148D3C321363A90995BEBC9D6EDD2
---

{{<slideStyles>}}

<div class="optional">

Ta strona zawiera omówienie składników, które mogą pomóc w korzystaniu z ALM z zestawem Automation Kit dla przepływów pracy programu Power Automate Desktop zawartych w [Rozwiązania Power Platform](https://learn.microsoft.com/power-platform/alm/solution-concepts-alm).

</div>

{{<presentation slides="1,2,3,4,5,6,7">}}

<div class="optional">

{{<presentationStyles>}}

## Streszczenie

Szukając rozwiązania ALM Power Platform zawierające składniki programu Power Automate Desktop

1. Zapoznaj się z funkcjami potoków Power Platform środowiska zarządzanego, aby skorzystać z funkcji produktu w skali przedsiębiorstwa w celu zarządzania rozwiązaniami w środowiskach i zarządzania nimi.

<br/>

2. W razie potrzeby zbadaj [Narzędzia Microsoft Power Platform Build Tools dla usługi Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools), [Akcje usługi GitHub dla usługi Microsoft Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions) lub [Power Platform CLI](https://learn.microsoft.com/power-platform/developer/cli/introduction) w celu integracji i automatyzacji procesów ALM DevOps.

<br/>

3. Rozważ użycie [Akcelerator ALM dla Power Platform](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-components). Akcelerator ALM udostępnia wstępnie utworzony zestaw szablonów usługi Azure DevOps, który automatyzuje wiele Power Platform zadań ALM przy użyciu zintegrowanego nadzoru kontroli źródła.

## Nauka z Power CAT

Możesz również przeczytać więcej, w jaki sposób my, jako zespół Power CAT, używamy ALM Accelerator do dostarczania [Zestaw automatyki Power CAT ALM](/pl/features/alm/powercat).

## Zasoby

[ALM Accelerator dla Power Platform Katalog szkoleń](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog)

## Mapa drogowa

Zespół zestawu Automation Kit współpracuje z zespołem ALM Accelerator, aby dodać zadania specyficzne dla programu Power Automate Desktop do istniejących szablonów, które obejmują:

- Porównanie definicji programu Power Automate Desktop obok siebie.

- Sprawdzanie reguł sprawdzania poprawności dla programu Power Automate Desktop.

- Wykonanie testów jednostkowych, integracyjnych i systemowych w ramach potoku CI/CD.

Przejrzyj nasze [Zaległości związane z zestawem automatyzacji ALM](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm).

## Sprzężenie zwrotne

{{<questions name="/content/pl/features/alm.json" completed="Dziękujemy za przekazanie opinii" showNavigationButtons="false" locale="pl">}}

</div>

{{<slide  id="slide1" audio="features/alm/managed-environments-overview.mp3" description="Managed Environments Overview" image="features/alm/managed-environments-overview.svg" >}}

Środowiska zarządzane umożliwiają usprawnienie i uproszczenie nadzoru na dużą skalę. Administratorzy mogą aktywować środowiska zarządzane za pomocą zaledwie kilku kliknięć i natychmiast włączyć funkcje, które zapewniają lepszą widoczność, większą kontrolę przy mniejszym wysiłku związanym z zarządzaniem wszystkimi zasobami o niskim kodzie.

Środowiska zarządzane są kluczową częścią rodziny Power Platform, w taki sam sposób, w jaki AI Builder wprowadził inteligencję do naszych produktów, a Dataverse zapewnia szkielet danych. Środowiska zarządzane usprawniają zarządzanie platformą na dużą skalę.

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/managed-environments-features.mp3" description="Managed Environments Features" image="features/alm/managed-environments-features.svg" >}}

Środowiska zarządzane zapewniają:Managed environments provide you:

- Większa widoczność dzięki wglądowi w użycie na stronie głównej, wiadomościom e-mail z podsumowaniem dla administratorów, raportom licencyjnym i widokom zasad dotyczących danych
- Większa kontrola dzięki limitom udostępniania dającym kontrolę nad tym, jak szeroko i z iloma osobami można udostępniać przepływy aplikacji kanwy i rozwiązań.
- Można również ograniczyć udostępnianie do ograniczonych grup zabezpieczeń.
- Konfigurowanie narzędzia sprawdzania rozwiązań na potrzeby sprawdzania zabezpieczeń lub niezawodności w celu automatycznego uruchamiania reguł za każdym razem, gdy rozwiązanie jest importowane do środowiska zarządzanego
- Dostosuj powitanie i udostępnianie środowiska kreatora, aby poprowadzić użytkowników właściwą ścieżką.
- Mniejszy wysiłek usprawnia, upraszcza i automatyzuje kroki po wyjęciu z pudełka za pomocą zaledwie kilku kliknięć. 
- Power Platform potoki umożliwiają uproszczenie procesu zarządzania cyklem życia aplikacji (ALM).

{{</slide>}}

{{<slide  id="slide3" cdnVideo="features/alm/managed-environments-power-platform-pipelines-demo.mp4" description="Power Platform Pipelines Demo" >}}

To rozwiązanie, z którym pracuję w Maker Portal.

Poszedłem dalej, aby wybrać ten potok, który został już skonfigurowany. Potoki to w zasadzie seria zautomatyzowanych kroków, które przenoszą pracę z jednego środowiska do drugiego. Ten potok przeniesie moje rozwiązanie ze środowiska programistycznego po lewej stronie do środowiska testowego. Jest też kolejny etap, aby przejść od testu do produkcji.

Lets deploy to test, select next and here I will confirm my connections to test the environment to sure I are using the right credentials. Następnie skonfiguruję zmienne środowiskowe, aby upewnić się, że na przykład wskazuję właściwą witrynę programu SharePoint w teście. Jest to ważne, jeśli strona była inna niż ta, której używałem w programowaniu. 

Po skonfigurowaniu wszystkiego mogę po prostu wybrać "Wdróż", a walidacje inspekcji wstępnej są uruchamiane automatycznie, aby upewnić się, że mam odpowiednie zależności, a rozwiązanie nie narusza zasad DLP w tym środowisku docelowym. Potok można również skonfigurować tak, aby przed uruchomieniem wdrożenia było wymagane zatwierdzenie. 

Wygląda na to, że wszystko się tutaj udało.

Po uruchomieniu potoku uzyskuję pełną widoczność i dziennik inspekcji wdrożeń w całej organizacji z kopią zapasową każdego rozwiązania i wersjonowaniem.

{{</slide>}}

{{<slide  id="slide4" audio="features/alm/managed-environments-feature-availability.mp3?v=1" description="Managed Environments Availability" image="features/alm/managed-environments-feature-availability.svg?v=1" >}}

Funkcje będą wprowadzane etapami. Niektóre z nich, takie jak podsumowania administracyjne i limity udostępniania, są dostępne już dziś. Reszta zostanie wprowadzona do końca roku.

W nadchodzących tygodniach i miesiącach zobaczysz statystyki użycia na stronie głównej. Nowe trendy w podsumowaniach administracyjnych i raportach dotyczących licencjonowanego użycia. Limity udostępniania zapewnią większą kontrolę i obsługę przepływów rozwiązań. Będzie można blokować niebezpieczne wdrożenia za pomocą narzędzia Solution Checker. Możliwości onboardingu i rurociągu dla producentów klientów również pojawią się jeszcze w tym roku.

{{</slide>}}

{{<slide  id="slide5" audio="features/alm/pipeline-extensibility.mp3?v=1" description="Pipeline Extensibility" image="features/alm/pipeline-extensibility.svg?v=1" >}}

W Power Platform należy wziąć pod uwagę kilka opcji wyboru ALM. Potoki Power Platform środowiska zarządzanego zapewniają zarządzanie cyklem życia aplikacji produktu.

Opcjonalnie można użyć punktów rozszerzeń potoków Power Platform środowiska zarządzanego w połączeniu z [Narzędzia kompilacji Power Platform dla usługi Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools)ten [Akcje usługi GitHub dla usługi Microsoft Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions) lub [Power Platform CLI](https://learn.microsoft.com/power-platform/developer/cli/introduction) , aby wdrożyć własne niestandardowe procesy ALM DevOps.

Wreszcie możesz skorzystać z [Akcelerator ALM dla Power Platform](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog) z zestawu CoE Kit, aby zapewnić wstępnie utworzone szablony i przykłady dla kompleksowego zarządzania obiektami ALM przy użyciu usługi Azure DevOps. Akcelerator ALM zapewnia wiele typowych scenariuszy tworzenia rozwiązań i zarządzania nimi w różnych środowiskach.

{{</slide>}}

{{<slide  id="slide6" audio="features/alm/alm-accelerator-for-power-platform-overview.mp3?v=1" description="ALM Accelerator for Power Platform Overview" image="features/alm/alm-accelerator-for-power-platform-overview.svg?v=1" >}}

Czym jest ALM Accelerator dla Power Platform?

Akcelerator ALM dla Power Platform obejmuje usługę Power Apps, która znajduje się na szczycie potoków Azure DevOps i kontroli źródła Git. Aplikacja zapewnia uproszczony interfejs dla twórców, którzy mogą regularnie eksportować składniki w swoich rozwiązaniach Power Platform w celu kontroli źródła i tworzenia żądań wdrożenia, aby ich praca została sprawdzona przed wdrożeniem w środowiskach docelowych.

{{</slide>}}

{{<slide  id="slide7" audio="features/alm/alm-accelerator-for-power-platform-workflow.mp3?v=1" description="ALM Accelerator for Power Platform Workflow" image="features/alm/alm-accelerator-for-power-platform-workflow.svg?v=1" >}}

Patrząc na przepływ pracy ALM Accelerator, zaczyna się on od środowisk programistycznych. Ich interakcja z procesem ALM odbywa się za pośrednictwem aplikacji ALM Accelerator Canvas App lub potoków środowiska zarządzanego

Twórcy używają aplikacji ALM Accelerator Canvas do zadań ALM, takich jak importowanie rozwiązania z kontroli źródła, eksportowanie zmian do kontroli źródła i tworzenie żądania ściągnięcia w celu scalenia zmian

Szablony akceleratora ALM dla potoków usługi Azure DevOps ułatwiają automatyzację zadań ALM na podstawie interakcji twórców z aplikacją ALM Accelerator Canvas

ALM Accelerator zawiera szablony potoków do obsługi 3-etapowego wdrożenia w środowisku produkcji.
Szablony można dostosowywać do konkretnych potrzeb i scenariuszy

ALM Accelerator for Power Platform to aplikacja kanwy, która znajduje się na szczycie potoków Azure DevOps, aby zapewnić uproszczony interfejs dla twórców do regularnego zatwierdzania i tworzenia żądań ściągnięcia dla ich prac programistycznych w Power Platform. 

Połączenie potoków Azure DevOps i aplikacji kanwy składa się na pełne rozwiązanie ALM Accelerator for Power Platform. 
Potoki i aplikacja są implementacjami referencyjnymi. Zostały one opracowane do użytku przez zespół programistów dla zestawu startowego CoE wewnętrznie, ale zostały otwarte i wydane w celu zademonstrowania, w jaki sposób można osiągnąć zdrowy ALM w Power Platform. Mogą być używane w niezmienionej postaci lub dostosowane do określonych scenariuszy biznesowych.

{{</slide>}}
