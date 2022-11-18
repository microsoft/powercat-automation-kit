---
title: "Lokalisering"
description: "Automation Kit - Lokalisering"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 2FF2232A3FA22363BFD644FE7880F83097A8BBBB
---

**Status:** {{<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon">}} Pågående arbete - Experimentellt

{{<toc>}}

## Främja inkludering och mångfald i Automation Kit med hjälp av lokalisering

{{<border>}}

![Lokalisering av automatiseringssats](/images/automation-kit-localization.png)

{{</border>}}

Det uppskattas av [Förenta Nationerna](https://hr.un.org/unhq/languages/english) att 1,5 miljarder människor talar engelska. Men med tanke på att världens befolkning uppskattas vara [8 miljarder](https://www.un.org/en/desa/world-population-reach-8-billion-15-november-2022) senast i november 2022 utgör detta ett tydligt behov av att stödja andra språk.

Power Platform Automation Kit-teamet arbetar som standard med amerikansk engelska för innehåll som inte ingår i Microsoft Learn-plattformen. För att tillgodose icke-engelsktalande experimenterar vi med en automatiserad process som konverterar innehåll som är en del av vår Automation-startupplevelse. Med hjälp av detta tillvägagångssätt strävar vi efter att skala till ett bredare samhälle.

Det som hjälper oss som team är att få [feedback](/sv#provide-feedback) från vår användargrupp om vikten av lokalisering för dig. Även om den här metoden inte ersätter en professionell översättningsprocess, tar vi gärna emot all feedback du har om den erfarenhet du får av att komma igång och använda Automation Kit. Vi ser fram emot att se hur vi kan stödja en bredare och mer varierad uppsättning upplevelser när vi experimenterar och ständigt förbättras över tiden.

Vi strävar efter att använda dessa lärdomar och tillämpa dem på de instrumentpaneler och applikationer som vi producerar som en del av paketet. Genom att använda den automatiska översättningsprocessen kan vi producera innehåll som du kan importera till din organisation så att du kan stödja och vårda flerspråkig användning av Automation-projekt över hela världen.

## Mål

Ett av de viktigaste målen för {{<product-name>}} är att stödja inkludering via lokalisering av innehåll. För att uppnå detta mål gäller följande:

- Innehåll som finns på [Startsida](https://aka.ms/ak4pp/starter) tillhandahåller automatiserad översättning via Azure Cognitive Services och anpassade mappningar.

- Kärnteamet för startwebbplatsinnehåll kommer att arbeta i en-us och omvandla innehållet till följande språk:

  - [Danska](https://microsoft.github.io/powercat-automation-kit/da/)
  - [Nederländska](https://microsoft.github.io/powercat-automation-kit/nl/)
  - [Franska](https://microsoft.github.io/powercat-automation-kit/fr/)
  - [Tyska](https://microsoft.github.io/powercat-automation-kit/de/) 
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

- Använd lärdomarna för att tillåta språkspecifikt "Communication Hub"-innehåll för Automation Kit som kan importeras till din organisation.

## Nuvarande tillstånd

- Stöd för amerikansk engelska till brittisk engelska har ännu inte implementerats

- Standard i förväg Azure Cognitive Service textöversättning av kontext för utvärderingsspråk ovan

## Färdplan

Vi planerar att ta dessa lärdomar och tillämpa dem på de Power BI-instrumentpaneler och Power Apps som vi använder så att vi som team kan skala till automatiserade översättningar med en feedbackloop som gör att vi kan tillhandahålla bredare flerspråkig täckning över tid.

Du kan se vår lokaliseringseftersläpning på vår [GitHub-webbplats](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aopen+is%3Aissue+label%3Alocalization).

## Fråga och svar

### **Fråga:** Är det lokaliserade innehållet professionellt översatt innehåll?

Nej, standardinnehållet skapas på amerikansk engelska och översätts automatiskt till andra språk med hjälp av Azure Cognitive Services och mappningstermer.

### **Fråga:** Hur kan jag förbättra översättningen för mitt språk?

Överväg att ge feedback eller ett bidrag som hjälper oss att förbättra din lokaliserade språkversion.

### **Fråga:** Vad är relationen till Microsoft Learn innehåll?

Startwebbplatsens innehåll hanteras av {{<product-name>}} endast team och bidragsgivare. När innehåll migreras till Microsoft Learn-plattformen går det igenom en separat innehållsgransknings- och lokaliseringsprocess.

### **Fråga:** Kan andra språk läggas till?

Ja, om språket stöds av [Språkstöd för Azure Cognitive Service](https://learn.microsoft.com/azure/cognitive-services/language-support) då kan det tilläggas.

## Ge feedback

Vad ska man ge feedback om lokaliseringsprocessen?

{{<questions name="/content/sv/localization.json" completed="Tack för att du fyller i frågor" showNavigationButtons="false" locale="sv">}}
