---
title: "Lokalisering"
description: "Automatiseringssæt - Lokalisering"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Localization']
generated: 53AFF7C6E0B1889AF1A221C000C138D19F1390BA
---

**Status:** {{<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon">}} Igangværende arbejde - Eksperimentelt

{{<toc>}}

## Fremme af inklusion og mangfoldighed i automatiseringspakken ved hjælp af lokalisering

{{<border>}}

![Lokalisering af automatiseringssæt](/images/automation-kit-localization.png)

{{</border>}}

Det anslås af [FN](https://hr.un.org/unhq/languages/english) at 1,5 milliarder mennesker taler engelsk. Men i betragtning af verdens befolkning anslås at være [8 milliarder dollars](https://www.un.org/en/desa/world-population-reach-8-billion-15-november-2022) i november 2022 giver dette et klart behov for at understøtte andre sprog.

Power Platform Automation Kit-teamet arbejder som standard med amerikansk engelsk for indhold, der ikke er en del af Microsoft Learn-platformen. For at hjælpe med at imødekomme ikke-engelsktalende eksperimenterer vi med en automatiseret proces, der konverterer indhold, der er en del af vores automatiseringsstartoplevelse. Ved hjælp af denne tilgang sigter vi mod at skalere til et bredere samfund.

Det, der hjælper os som team, er at få [feedback](/da#provide-feedback) fra vores brugerfællesskab om vigtigheden af lokalisering for dig. Selvom denne tilgang ikke erstatter en professionel oversættelsesproces, vil vi gerne have al feedback, du har om den erfaring, som lokalisering giver dig til at komme i gang og bruge automatiseringssættet. Vi ser frem til at se, hvordan vi kan understøtte et bredere og mere forskelligartet sæt oplevelser, når vi eksperimenterer og løbende forbedrer os over tid.

Vi sigter mod at bruge disse læringer og anvende dem på de dashboards og applikationer, vi producerer som en del af sættet. Brug af den automatiserede oversættelsesproces giver os mulighed for at producere indhold, som du kan importere til din organisation, så du kan støtte og pleje flersproget vedtagelse af automatiseringsprojekter over hele verden.

## Mål

Et af kernemålene for {{<product-name>}} er at understøtte at være inkluderende via lokalisering af indhold. For at nå dette mål gælder følgende:

- Indhold, der hostes på [Startside](https://aka.ms/ak4pp/starter) leverer automatiseret oversættelse via Azure Cognitive Services og brugerdefinerede tilknytninger.

- Kerneteamet for startwebsted vil arbejde på en-us og omdanne indholdet til følgende sprog:

  - [Dansk](https://microsoft.github.io/powercat-automation-kit/da/)
  - [Nederlandsk](https://microsoft.github.io/powercat-automation-kit/nl/)
  - [Fransk](https://microsoft.github.io/powercat-automation-kit/fr/)
  - [Tysk](https://microsoft.github.io/powercat-automation-kit/de/) 
  - [Italiensk](https://microsoft.github.io/powercat-automation-kit/it/)
  - [Koreansk](https://microsoft.github.io/powercat-automation-kit/ko/)
  - [Japansk](https://microsoft.github.io/powercat-automation-kit/ja/)
  - [Norsk](https://microsoft.github.io/powercat-automation-kit/nb/)
  - [Polsk](https://microsoft.github.io/powercat-automation-kit/pl/)
  - [Forenklet kinesisk](https://microsoft.github.io/powercat-automation-kit/zh-hans)
  - [Spansk](https://microsoft.github.io/powercat-automation-kit/es/)
  - [Svensk](https://microsoft.github.io/powercat-automation-kit/sv/)

- Giv en feedbackmekanisme, der gør det muligt at forbedre det automatiserede genererede indhold over tid.

- Løs problemer med lokalisering tidligt, så efterhånden som indholdet flyttes til [Få mere at vide om CoE-indhold fra automatisering](https://aka.ms/AutomationCoE) Indhold er allerede tilgængeligt i lokaliserede formater.

- Brug læringen fra startwebstedets indhold til at forbedre andre Kit-aktiver, f.eks. dashboardskabelonrapporter eller -programmer.

- Tillad en "crowd source" -model for bidrag, der muliggør forbedret sprogtransformation.

- Brug læringen til at tillade sprogspecifikt "Communication Hub"-indhold til automatiseringspakken, der kan importeres til din organisation.

## Nuværende tilstand

- Amerikansk engelsk til britisk engelsk support er endnu ikke implementeret

- Standard standardtekstoversættelse af Azure Cognitive Service-tekst af kontekst til prøvesprog ovenfor

## Køreplan

Vi planlægger at tage disse erfaringer og anvende dem på de Power BI-dashboards og Power Apps, vi bruger, så vi som team kan skalere til automatiserede oversættelser med et feedbackloop, der giver os mulighed for at levere bredere flersproget dækning over tid.

Du kan se vores lokaliseringsefterslæb på vores [GitHub-websted](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aopen+is%3Aissue+label%3Alocalization).

## Spørgsmål og svar

### **Spørgsmål:** Er det lokaliserede indhold professionelt oversat indhold?

Nej, standardindholdet oprettes på amerikansk engelsk og oversættes automatisk til andre sprog ved hjælp af Azure Cognitive Services og tilknytningsudtryk.

### **Spørgsmål:** Hvordan kan jeg forbedre oversættelsen af mit sprog?

Overvej at give feedback eller et bidrag for at hjælpe os med at forbedre din lokaliserede sprogversion.

### **Spørgsmål:** Hvad er relationen til Microsoft Learn-indholdet?

Startwebstedets indhold administreres af {{<product-name>}} kun team og bidragydere. Når indhold overføres til Microsoft Learn-platformen, gennemgår det en separat indholdsgennemgangs- og lokaliseringsproces.

### **Spørgsmål:** Kan andre sprog tilføjes?

Ja, hvis sproget understøttes af [Sprogunderstøttelse af Azure Cognitive Service](https://learn.microsoft.com/azure/cognitive-services/language-support) så kunne det tilføjes.

## Giv feedback

Hvad skal jeg give feedback om lokaliseringsprocessen?

{{<questions name="/content/da/localization.json" completed="Tak fordi du udfyldte spørgsmål" showNavigationButtons="false" locale="da">}}
