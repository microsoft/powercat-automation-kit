---
title: "Lokalisering"
description: "Automatiseringssett - Lokalisering"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: E807CB451AFD916D511FFBA8EAC5FA5C8C54BC47
---

**Status:** {{<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon">}} Arbeid pågår - Eksperimentell

{{<toc>}}

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

- Bruk erfaringene til å tillate språkspesifikt "Kommunikasjonshub"-innhold for automatiseringspakken.

## Nåværende tilstand

- Støtte fra amerikansk engelsk til britisk engelsk er ennå ikke implementert

- Standard ut av boksen Azure Cognitive Service-tekstoversettelse av kontekst for prøvespråk ovenfor

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
