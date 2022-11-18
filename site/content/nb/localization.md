---
title: "Lokalisering"
description: "Automatiseringssett - Lokalisering"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 43D11FFC777543B7748C0F60574831E0EE19A278
---

**Status:** {{<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon">}} Arbeid pågår - Eksperimentell

{{<toc>}}

## Fremme inkludering og mangfold i automatiseringssettet ved hjelp av lokalisering

{{<border>}}

![Lokalisering av automatiseringssett](/images/automation-kit-localization.png)

{{</border>}}

Det er estimert av [FN](https://hr.un.org/unhq/languages/english) at 1,5 milliarder mennesker snakker engelsk. Men gitt verdens befolkning er anslått til å være [8 milliarder](https://www.un.org/en/desa/world-population-reach-8-billion-15-november-2022) innen november 2022 presenterer dette et klart behov for å støtte andre språk.

Power Platform Automation Kit-teamet fungerer som standard med amerikansk engelsk for innhold som ikke er en del av Microsoft Learn-plattformen. For å imøtekomme ikke-engelsktalende eksperimenterer vi med en automatisert prosess som konverterer innhold som er en del av vår automasjonsstarteropplevelse. Ved å bruke denne tilnærmingen tar vi sikte på å skalere til et bredere samfunn.

Det som hjelper oss som et team, er å få [tilbakemelding](/nb#provide-feedback) fra brukerfellesskapet vårt om viktigheten av lokalisering for deg. Selv om denne tilnærmingen ikke erstatter en profesjonell oversettelsesprosess, tar vi gjerne imot tilbakemeldinger du har på opplevelsen av at lokalisering gir deg i gang og bruker automatiseringssettet. Vi ser frem til å se hvordan vi kan støtte et bredere og mer mangfoldig sett med erfaringer når vi eksperimenterer og kontinuerlig forbedrer oss over tid.

Vi tar sikte på å bruke disse erfaringene og bruke dem på dashbordene og applikasjonene vi produserer som en del av settet. Ved å bruke den automatiserte oversettelsesprosessen kan vi produsere innhold som du kan importere til organisasjonen din, slik at du kan støtte og pleie flerspråklig bruk av automatiseringsprosjekter over hele verden.

## Mål

Et av hovedmålene med {{<product-name>}} er å støtte å være inkluderende via lokalisering av innhold. For å nå dette målet gjelder følgende:

- Innhold som driftes på [Startside](https://aka.ms/ak4pp/starter) levere automatisert oversettelse via Azure Cognitive Services og tilpassede tilordninger.

- Kjerneteamet for startnettsted vil jobbe i en-us og transformere innholdet til følgende språk:

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

- Gi en tilbakemeldingsmekanisme slik at det automatiserte genererte innholdet kan forbedres over tid.

- Ta tak i problemer med lokalisering tidlig, slik at innholdet flyttes til [Lær CoE-innhold for automatisering](https://aka.ms/AutomationCoE) innhold er allerede tilgjengelig i lokaliserte formater.

- Bruk erfaringene fra innholdet på startnettstedet til å forbedre andre Kit-ressurser, for eksempel rapporter eller programmer for instrumentbordmaler.

- Tillat en "crowd source" -modell av bidrag som tillater forbedret språktransformasjon.

- Bruk erfaringene til å tillate språkspesifikt "Kommunikasjonshub"-innhold for automatiseringspakken som kan importeres til organisasjonen.

## Nåværende tilstand

- Støtte fra amerikansk engelsk til britisk engelsk er ennå ikke implementert

- Standard ut av boksen Azure Cognitive Service-tekstoversettelse av kontekst for prøvespråk ovenfor

## Veikart

Vi planlegger å ta disse erfaringene og bruke dem på Power BI-instrumentbordene og Power Apps vi bruker, slik at vi som team kan skalere til automatiserte oversettelser med en tilbakemeldingssløyfe som lar oss gi bredere flerspråklig dekning over tid.

Du kan se vårt lokaliseringsetterslep på vår [GitHub-nettstedet](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aopen+is%3Aissue+label%3Alocalization).

## Spørsmål og svar

### **Spørsmål:** Er det lokaliserte innholdet profesjonelt oversatt innhold?

Nei, standardinnholdet opprettes på amerikansk engelsk og oversettes automatisk til andre språk ved hjelp av Azure Cognitive Services og tilordningstermer.

### **Spørsmål:** Hvordan kan jeg forbedre oversettelsen for språket mitt?

Vurder å gi tilbakemelding eller et bidrag for å hjelpe oss med å forbedre den lokaliserte språkversjonen din.

### **Spørsmål:** Hva er relasjonen til Microsoft Learn-innholdet?

Startsideinnholdet administreres av kjernen {{<product-name>}} bare team. Når innhold overføres til Microsoft Learn-plattformen, går det gjennom en egen innholdsgjennomgang og lokaliseringsprosess.

### **Spørsmål:** Kan andre språk legges til?

Ja, hvis språket støttes av [Språkstøtte for Azure Cognitive Service](https://learn.microsoft.com/azure/cognitive-services/language-support) så kan det legges til.

## Gi tilbakemelding

Hva skal du gi tilbakemelding på lokaliseringsprosessen?

{{<questions name="/content/nb/localization.json" completed="Takk for at du fullførte spørsmål" showNavigationButtons="false" locale="nb">}}