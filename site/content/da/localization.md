---
title: "Lokalisering"
description: "Automatiseringssæt - Lokalisering"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: E807CB451AFD916D511FFBA8EAC5FA5C8C54BC47
---

**Status:** {{<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon">}} Igangværende arbejde - Eksperimentelt

{{<toc>}}

## Mål

Et af kernemålene for {{<product-name>}} er at understøtte at være inkluderende via lokalisering af indhold. For at nå dette mål gælder følgende:

- Indhold, der hostes på [Startside](https://aka.ms/ak4pp/starter) levere automatiseret oversættelse via Azure Cognitive Services og brugerdefinerede tilknytninger.

- Kerneteamet for startwebsted vil arbejde på en-us og omdanne indholdet til følgende sprog:

  - [Dansk](https://microsoft.github.io/powercat-automation-kit/da/)
  - [Nederlandsk](https://microsoft.github.io/powercat-automation-kit/nl/)
  - [Fransk](https://microsoft.github.io/powercat-automation-kit/fr/)
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

- Brug læringen til at give mulighed for sprogspecifikt "Communication Hub"-indhold til automatiseringssættet.

## Nuværende tilstand

- Amerikansk engelsk til britisk engelsk support er endnu ikke implementeret

- Standard standardtekstoversættelse af Azure Cognitive Service-tekst af kontekst til prøvesprog ovenfor

## Spørgsmål og svar

### **Spørgsmål:** Er det lokaliserede indhold professionelt oversat indhold?

Nej, standardindholdet oprettes på amerikansk engelsk og oversættes automatisk til andre sprog ved hjælp af Azure Cognitive Services og tilknytningsudtryk.

### **Spørgsmål:** Hvordan kan jeg forbedre oversættelsen af mit sprog?

Overvej at give feedback eller et bidrag for at hjælpe os med at forbedre din lokaliserede sprogversion.

### **Spørgsmål:** Hvad er relationen til Microsoft Learn-indholdet?

Startsidens indhold administreres af kernen {{<product-name>}} kun hold. Når indhold overføres til Microsoft Learn-platformen, gennemgår det en separat indholdsgennemgangs- og lokaliseringsproces.

### **Spørgsmål:** Kan andre sprog tilføjes?

Ja, hvis sproget understøttes af [Sprogunderstøttelse af Azure Cognitive Service](https://learn.microsoft.com/azure/cognitive-services/language-support) så kunne det tilføjes.

## Giv feedback

Hvad skal jeg give feedback om lokaliseringsprocessen?

{{<questions name="/content/da/localization.json" completed="Tak fordi du udfyldte spørgsmål" showNavigationButtons="false" locale="da">}}
