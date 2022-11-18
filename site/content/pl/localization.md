---
title: "Lokalizacji"
description: "Automation Kit - Lokalizacja"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 43D11FFC777543B7748C0F60574831E0EE19A278
---

**Stan:** {{<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon">}} Prace w toku - eksperymentalne

{{<toc>}}

## Promowanie integracji i różnorodności w Automation Kit za pomocą lokalizacji

{{<border>}}

![Lokalizacja zestawu Automation Kit](/images/automation-kit-localization.png)

{{</border>}}

Szacuje się ją według [Organizacja Narodów Zjednoczonych](https://hr.un.org/unhq/languages/english) że 1,5 miliarda ludzi mówi po angielsku. Biorąc jednak pod uwagę, że populacja świata jest szacowana na [8 miliardów](https://www.un.org/en/desa/world-population-reach-8-billion-15-november-2022) do listopada 2022 r. wskazuje to na wyraźną potrzebę obsługi innych języków.

Zespół zestawu Power Platform Automation Kit domyślnie pracuje z angielskim (USA) w przypadku zawartości, która nie jest częścią platformy Microsoft Learn. Aby zaspokoić potrzeby osób nieanglojęzycznych, eksperymentujemy z automatycznym procesem, który konwertuje treści, które są częścią naszego środowiska startowego Automation. Stosując to podejście, staramy się skalować do szerszej społeczności.

To, co pomaga nam jako zespołowi, to uzyskać [sprzężenie zwrotne](/pl#provide-feedback) od naszej społeczności użytkowników na temat znaczenia lokalizacji dla Ciebie. Chociaż takie podejście nie zastępuje profesjonalnego procesu tłumaczenia, będziemy wdzięczni za wszelkie informacje zwrotne na temat doświadczenia, jakie zapewnia lokalizacja rozpoczynająca pracę i korzystanie z zestawu Automation Kit. Z niecierpliwością czekamy na to, jak możemy wspierać szerszy i bardziej zróżnicowany zestaw doświadczeń, eksperymentując i stale ulepszając się w czasie.

Naszym celem jest wykorzystanie tych wiedzy i zastosowanie ich do pulpitów nawigacyjnych i aplikacji, które tworzymy w ramach zestawu. Korzystanie z automatycznego procesu tłumaczenia pozwoli nam tworzyć treści, które będziesz mógł zaimportować do swojej organizacji, abyś mógł wspierać i pielęgnować wielojęzyczne wdrażanie projektów automatyzacji na całym świecie.

## Cele

Jednym z głównych celów {{<product-name>}} ma wspierać inkluzywność poprzez lokalizację treści. Aby osiągnąć ten cel, należy zastosować następujące zasady:

- Zawartość hostowana na [Strona startowa](https://aka.ms/ak4pp/starter) zapewniają automatyczne tłumaczenie za pośrednictwem usług Azure Cognitive Services i mapowań niestandardowych.

- Główny zespół ds. zawartości witryny startowej będzie pracował w en-us i przekształcał zawartość na następujące języki:

  - [Duński](https://microsoft.github.io/powercat-automation-kit/da/)
  - [Holenderski](https://microsoft.github.io/powercat-automation-kit/nl/)
  - [Francuski](https://microsoft.github.io/powercat-automation-kit/fr/)
  - [Włoski](https://microsoft.github.io/powercat-automation-kit/it/)
  - [Koreański](https://microsoft.github.io/powercat-automation-kit/ko/)
  - [Japoński](https://microsoft.github.io/powercat-automation-kit/ja/)
  - [Norweski](https://microsoft.github.io/powercat-automation-kit/nb/)
  - [Polski](https://microsoft.github.io/powercat-automation-kit/pl/)
  - [Chiński uproszczony](https://microsoft.github.io/powercat-automation-kit/zh-hans)
  - [Hiszpański](https://microsoft.github.io/powercat-automation-kit/es/)
  - [Szwedzki](https://microsoft.github.io/powercat-automation-kit/sv/)

- Zapewnij mechanizm informacji zwrotnej, aby umożliwić ulepszanie automatycznie generowanych treści w miarę upływu czasu.

- Wcześnie rozwiązuj problemy z lokalizacją, aby w miarę przenoszenia treści do [Dowiedz się więcej o automatyzacji CoE](https://aka.ms/AutomationCoE) Zawartość jest już dostępna w zlokalizowanych formatach.

- Wykorzystaj wnioski z zawartości witryny startowej, aby ulepszyć inne zasoby zestawu, takie jak szablony pulpitów nawigacyjnych, raporty lub aplikacje.

- Pozwól na model "crowd source" wkładów, który pozwala na lepszą transformację językową.

- Skorzystaj z tych informacji, aby zezwolić na specyficzną dla języka zawartość "Centrum komunikacyjnego" dla zestawu Automation Kit, którą można zaimportować do organizacji.

## Stan obecny

- Obsługa amerykańskiego angielskiego na brytyjski angielski nie została jeszcze wdrożona

- Domyślne tłumaczenie tekstu kontekstu dla języków próbnych powyżej

## Mapa drogowa

Planujemy wykorzystać te wnioski i zastosować je do pulpitów nawigacyjnych usługi Power BI i usługi Power Apps, których używamy, abyśmy jako zespół mogli skalować do tłumaczeń automatycznych z pętlą opinii, która pozwala nam z czasem zapewnić szerszy wielojęzyczny zasięg.

Możesz zobaczyć nasze zaległości lokalizacyjne na naszej stronie [Witryna GitHub](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aopen+is%3Aissue+label%3Alocalization).

## Pytanie i odpowiedź

### **Pytanie:** Czy zlokalizowana treść jest profesjonalnie przetłumaczona?

Nie, zawartość domyślna jest tworzona w języku angielskim (USA) i automatycznie tłumaczona na inne języki przy użyciu usług Azure Cognitive Services i terminów mapowania.

### **Pytanie:** Jak mogę poprawić tłumaczenie dla mojego języka?

Rozważ przekazanie opinii lub wkładu, który pomoże nam ulepszyć Twoją zlokalizowaną wersję językową.

### **Pytanie:** Jaki jest związek z zawartością Microsoft Learn?

Zawartość strony startowej jest zarządzana przez rdzeń {{<product-name>}} tylko zespół. Podczas migracji zawartości na platformę Microsoft Learn przechodzi oddzielny proces przeglądu i lokalizacji zawartości.

### **Pytanie:** Czy można dodać inne języki?

Tak, jeśli język jest obsługiwany przez [Obsługa języków w usłudze Azure Cognitive Service](https://learn.microsoft.com/azure/cognitive-services/language-support) Wtedy można by go dodać.

## Przekaż opinię

Co przekazać opinii na temat procesu lokalizacji?

{{<questions name="/content/pl/localization.json" completed="Dziękujemy za wypełnienie pytań" showNavigationButtons="false" locale="pl">}}
