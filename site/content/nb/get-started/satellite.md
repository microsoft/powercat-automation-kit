---
title: "Satellitt - Kom i gang"
description: "Automatiseringssett - Satellitt - Kom i gang"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Satellite']
generated: D34A3BCCCE29730419418EAC4DDC091FAB118A83
---

# Oversikt

Velkommen til startsiden for satellittløsningen. Denne delen dekker viktige endringer som ble gjort i april 2023 og senere utgivelser. Etter april 2023 har vi fjernet behovet for Azure Key Vault for å lagre Azure-programleier, program-ID og hemmelig informasjon om Azure-apper.

## Konseptuell design

Vår læringsside skisserer [Konseptuell design](https://learn.microsoft.com/power-automate/guidance/automation-kit/overview/introduction#conceptual-design) til {{produktnavn}}. Nøkkelelementet i løsningen er det Power Platform hovedmiljøet.

Det er vanligvis flere satellittproduksjonsmiljøer som kjører automatiseringsprosjektene dine. Avhengig av miljøstrategien kan dette også være utviklings- eller testmiljøer.

Mellom disse miljøene er det en synkroniseringsprosess i nær sanntid som inkluderer telemetri for sky- eller skrivebordsflyt, bruk av maskin- og maskingrupper og revisjonslogger. Power BI-instrumentbordet for automatiseringspakken viser denne informasjonen.

## Hva har endret seg

Som en del av løsningen [[Automatiseringssett – funksjon]: Azure Key Vault-alternativ for satellittmiljøer](https://github.com/microsoft/powercat-automation-kit/issues/84) Azure Key Vault er ikke lenger nødvendig. Dette er viktig fordi det betydelig reduserer kompleksiteten ved installasjon og hvordan sikkerhet administreres for å få løsningsartefakter ved bruk av Automation Solution Manager.

## Hva er det samme?

Når nøkkelelementene er de samme som de eldre utgivelsene før april 2023 og april 2023, er behovet for et Azure Active Directory-program.

En [applikasjon bruker](https://learn.microsoft.com/power-platform/admin/manage-application-users) er en type bruker i Power Platform som identifiseres av tilstedeværelsen av ApplicationId-attributtet i systembrukeroppføringen. Programbrukere opprettes i Azure Active Directory (Azure AD) og brukes til å godkjenne og autorisere tilgang til Power Platform. De brukes vanligvis til å representere et program eller en tjeneste som trenger tilgang til data eller utføre operasjoner i Power Platform på vegne av brukere eller andre programmer.

Programbrukeren brukes spesifikt av Automation Solution Manager slik at du kan spørre løsningskomponentene i et miljø, slik at du kan gjøre det mulig for en bruker å måle en distribuert Power Platform løsning.

## Installere

Den [Installasjon av kommandolinje](/nb/get-started/install) for satellittløsninger vil be deg om Azure Active Directory-programnavnet og Azure Active Directory-program-ID. Ved hjelp av denne informasjonen vil det:

1. Legge til Azure Active Directory-programmet som en programbruker
1. Legge til programbrukeren i Systemadministrator-rollen
1. Legg til bruker-IDen for programbrukeren i miljøvariabelen **Artefakter i løsningsbehandling leser bruker-ID**

Den nye rollen Dataverse-rollen **Bruker av automatiseringsløsningsbehandling** er lagt til som gjør det mulig for brukere å kalle den nye egendefinerte API-en for Dataverse GetDataverseSolutionArtifacts som spør etter løsningsartefakter ved hjelp av den angitte miljøvariabelen **Artefakter i løsningsbehandling leser bruker-ID**.

Hvis du ønsker å installere satellittløsningen manuelt, må følgende endringer gjøres i [Sett opp satellitter](https://learn.microsoft.com/en-us/power-automate/guidance/automation-kit/setup/satellite) instruks.

1. Hopp over trinnet "Legg til en ny klienthemmelighet" da denne ikke lenger er nødvendig for april 2023 eller nyere.
1. Hopp over trinnet for å opprette hemmeligheter i Azure Key Vault.
1. Legg til bruker-IDen til programbrukeren i **Artefakter i løsningsbehandling leser bruker-ID** Miljøvariabel.

## Post Installer

Kontroller at bruker(e) som skal kjøre Automation Solution Manager-programmet, får tillatelse til **Bruker av automatiseringsløsningsbehandling** Dataverse-sikkerhetsrolle.

## Tidligere utgivelser

Før utgivelsen i april 2023 krevde installasjoner av satellittløsning miljøvariabler av typen hemmelig. Dette krevde en [Azure Key Vault](https://learn.microsoft.com/power-apps/maker/data-platform/environmentvariables#use-azure-key-vault-secrets-preview) for å lagre verdiene for leier-ID, program-ID og programhemmelighet. For å bruke denne funksjonen kreves også [Forutsetninger](https://learn.microsoft.com/en-us/power-apps/maker/data-platform/environmentvariables#prerequisites) av Azure Key Vault som er den samme leieren, oppsett av Microsoft.PowerPlatform som en ressursleverandør.

I mars 2023-utgivelsene eller eldre ble Azure Key Vault brukt til å lagre en leier-ID, APplication Id og programhemmelighet. Ved hjelp av disse verdiene ble det bedt om et tilgangstoken for å spørre Dataverse slik at den kunne returnere listen over løsningskomponenter.

## Anbefalinger

For eksisterende brukere anbefales det å forenkle pågående administrasjon og fjerne behovet for en avhengighet av Azure Key Vault som du oppgraderer den eksisterende satellittinstallasjonen til april 2023 eller senere for å dra nytte av de nye funksjonene.
