---
title: "Instalować"
description: "Automation Kit - Zainstaluj"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Install']
generated: 2251306D3FA73DEF67131846C92EDEB6BECC84B8
---

Aby zainstalować najnowszą wersję pakietu Automation Kit, wykonaj następujące czynności opisane poniżej. Jeśli nie możesz użyć narzędzi wiersza polecenia, możesz wykonać ręczne kroki opisane w sekcji [Wskazówki dotyczące konfiguracji](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/prerequisites).

1. Otwórz najnowszą wersję z <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">Wydania zestawu Automation Kit GitHub</a>

1. Pobierz **AutomationKitInstall.zip**

1. W Eksploratorze Windows wybierz pobrane **AutomationKitInstall.zip** i otwórz okno dialogowe Właściwości

1. Wybierz ikonę **Odblokować** guzik

1. Wybrać **AutomationKitInstall.zip** i użyj menu kontekstowego, aby **Wyodrębnij wszystko**

1. Upewnij się, że masz <a href="https://learn.microsoft.com/en-us/power-platform/developer/cli/introduction" target="_blank">Power Platform CLI</a> Zainstalowana

1. Wykonaj skrypt programu PowerShell przy użyciu następującego wiersza poleceniaExecute the PowerShell script using the following command line

```cmd
cd AutomationKitInstall
powershell Install_AutomationKit.ps1
```

UWAGA: W zależności od zasad wykonywania programu PowerShell może być konieczne uruchomienie następującego polecenia

```cmd
powershell.exe -ExecutionPolicy Bypass -File Install_AutomationKit.ps1
```

1. Skrypt programu PowerShell wyświetli monit o utworzenie pliku konfiguracji instalacji przy użyciu [Instalowanie Instalatora](/pl/get-started/setup). Na stronach konfiguracji konfiguracji zostaną wyświetlone następujące informacje

    - Wybierz konfigurację dla rozwiązań głównych lub satelitarnych
   
    - Wybierz użytkowników, którzy mają zostać przypisani do grup zabezpieczeńSelect users to assign to security groups
   
    - Tworzenie połączeń wymaganych do zainstalowania rozwiązania
    
    - Definiowanie zmiennych środowiskowych
    
    - Opcjonalnie określ, czy przykładowe dane mają być importowane
    
    - Opcjonalnie Włącz Power Automate Przepływy zawarte w rozwiązaniach powinny być włączone

1. Po zakończeniu konfiguracji skopiuj **automation-kit-main-install.json** lub **automation-kit-satellite-install.json** do pliku **AutomationKitZainstaluj** folder powyżej

1. Po pobraniu pliku skrypt wyświetli monit o **y** zainstalować główne rozwiązanie, **n** Aby zainstalować rozwiązanie satelitarne

1. Następnie instalacja rozpocznie instalację ze zdefiniowanymi ustawieniami

## Sprzężenie zwrotne

Chcesz przekazać opinię na temat [Proces konfiguracji](/pl/get-started/setup)? Poniższe pytania pomagają nam ulepszyć ten proces.

{{<questions name="/content/pl/get-started/setup-feedback.json" completed="Dziękujemy za przekazanie opinii" showNavigationButtons=true locale="pl">}}
