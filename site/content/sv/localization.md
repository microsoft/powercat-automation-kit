---
title: "Lokalisering"
description: "Automation Kit - Lokalisering"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 95F13FA4929A43C1DBF775B8119315DDEB91E0F5
---

**Status:** {{<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon">}} Pågående arbete - Experimentellt

{{<toc>}}

## Mål

Ett av de viktigaste målen för {{<product-name>}} är att stödja inkludering via lokalisering av innehåll. För att uppnå detta mål gäller följande:

- Innehåll som finns på [Startsida](https://aka.ms/ak4pp/starter) tillhandahålla automatiserad översättning via Azure Cognitive Services och anpassade mappningar.

- Kärnteamet för startwebbplatsinnehåll kommer att arbeta i en-us och omvandla innehållet till följande språk:

  - [Danska](https://microsoft.github.io/powercat-automation-kit/da/)
  - [Nederländska](https://microsoft.github.io/powercat-automation-kit/nl/)
  - [Franska](https://microsoft.github.io/powercat-automation-kit/fr/)
  - [Italienska](https://microsoft.github.io/powercat-automation-kit/it/)
  - [Koreanska](https://microsoft.github.io/powercat-automation-kit/ko/)
  - [Japanska](https://microsoft.github.io/powercat-automation-kit/ja/)
  - [Norska](https://microsoft.github.io/powercat-automation-kit/nb/)
  - [Polska](https://microsoft.github.io/powercat-automation-kit/pl/)
  - [Förenklad kinesiska](https://microsoft.github.io/powercat-automation-kit/zh-hans)
  - [Spanska](https://microsoft.github.io/powercat-automation-kit/es/)
  - [Svenska](https://microsoft.github.io/powercat-automation-kit/sv/)

- Ge en feedbackmekanism så att det automatiskt genererade innehållet kan förbättras över tid.

- Ta itu med problem med lokalisering tidigt så att när innehållet flyttas till [Lär dig CoE-innehåll för automatisering](https://aka.ms/AutomationCoE) Innehållet är redan tillgängligt i lokaliserade format.

- Använd lärdomarna från startwebbplatsens innehåll för att förbättra andra Kit-tillgångar, till exempel instrumentpanelsmallrapporter eller program.

- Tillåt en "crowd source"-modell av bidrag som möjliggör förbättrad språkomvandling.

- Använd lärdomarna för att tillåta språkspecifikt "Communication Hub"-innehåll för Automation Kit.

## Främja inkludering och mångfald i Automation Kit med hjälp av lokalisering

{{<border>}}

![Lokalisering av automatiseringssats](/images/automation-kit-localization.png)

{{</border>}}

Det uppskattas av [Förenta Nationerna](https://hr.un.org/unhq/languages/english) att 1,5 miljarder människor talar engelska. Men med tanke på att världens befolkning uppskattas vara [8 miljarder](https://www.un.org/en/desa/world-population-reach-8-billion-15-november-2022) senast i november 2022 är detta tydligt ett behov av att stödja andra språk.

Som ett litet team fungerar Automation Kit som standard med amerikansk engelska för innehåll som inte ingår i Microsoft Lean-plattformen. För att hjälpa till att tillgodose icke-engelsktalande har vi automatiserat processen att konvertera innehåll som ingår i denna webbplats.

Det som hjälper oss i ett team är att få feedback från vår användargrupp om vikten av lokalisering för dig. Vi tar gärna emot all feedback du har om erfarenheterna nedan och ser fram emot att se hur vi kan stödja en bredare och mer varierad uppsättning lokaliseringar över tid.

## Nuvarande tillstånd

- Stöd för amerikansk engelska till brittisk engelska har ännu inte implementerats

- Standard i förväg Azure Cognitive Service textöversättning av kontext för utvärderingsspråk ovan

## Fråga och svar

### **Fråga:** Är det lokaliserade innehållet professionellt översatt innehåll?

Nej, standardinnehållet skapas på amerikansk engelska och översätts automatiskt till andra språk med hjälp av Azure Cognitive Services och mappningstermer.

### **Fråga:** Hur kan jag förbättra översättningen för mitt språk?

Överväg att ge feedback eller ett bidrag som hjälper oss att förbättra din lokaliserade språkversion.

### **Fråga:** Vad är relationen till Microsoft Learn innehåll?

Innehållet på startsidan hanteras av kärnan {{<product-name>}} endast laget. När innehåll migreras till Microsoft Learn-plattformen går det igenom en separat innehållsgransknings- och lokaliseringsprocess.

### **Fråga:** Kan andra språk läggas till?

Ja, om språket stöds av [Språkstöd för Azure Cognitive Service](https://learn.microsoft.com/azure/cognitive-services/language-support) då kan det tilläggas.

## Ge feedback

Vad ska man ge feedback om lokaliseringsprocessen?

{{<questions name="/content/sv/localization.json" completed="Tack för att du fyller i frågor" showNavigationButtons="false" locale="sv">}}
