---
title: "Instalar"
description: "Kit de automatización - Instalar"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Install']
generated: 2251306D3FA73DEF67131846C92EDEB6BECC84B8
---

Para instalar la versión más reciente del Kit de automatización, siga estos pasos. Si no puede utilizar las herramientas de línea de comandos, puede utilizar los pasos manuales documentados en [Guía de configuración](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/prerequisites).

1. Abra la versión más reciente desde el <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">Lanzamiento de GitHub de Automation Kit</a>

1. Descargue el **AutomationKitInstall.zip**

1. En el Explorador de Windows, seleccione el descargado **AutomationKitInstall.zip** y abra el cuadro de diálogo Propiedades

1. Seleccione la opción **Desbloquear** botón

1. Escoger **AutomationKitInstall.zip** y use el menú contextual para **Extraer todo**

1. Asegúrese de que tiene el <a href="https://learn.microsoft.com/en-us/power-platform/developer/cli/introduction" target="_blank">Power Platform CLI</a> Instalado

1. Ejecutar el script de PowerShell mediante la siguiente línea de comandos

```cmd
cd AutomationKitInstall
powershell Install_AutomationKit.ps1
```

NOTA: En función de la directiva de ejecución de PowerShell, es posible que deba ejecutar el siguiente comando

```cmd
powershell.exe -ExecutionPolicy Bypass -File Install_AutomationKit.ps1
```

1. El script de PowerShell le pedirá que cree un archivo de configuración de instalación mediante [Instalar el programa de instalación](/es/get-started/setup). Las páginas de configuración del programa de instalación le proporcionarán lo siguiente

    - Seleccione la configuración para soluciones principales o satelitales
   
    - Seleccionar usuarios para asignar a grupos de seguridad
   
    - Crear las conexiones necesarias para instalar la solución
    
    - Definir variables de entorno
    
    - Opcionalmente, defina si se deben importar datos de muestra
    
    - Opcionalmente, se debe habilitar Habilitar Power Automate Los flujos contenidos en las soluciones deben estar habilitados

1. Después de completar la instalación, copie el **automation-kit-main-install.json** o **automation-kit-satellite-install.json** a la carpeta **AutomationKitInstall** carpeta anterior

1. Una vez descargado el archivo, el script solicitará **y** para instalar la solución principal, **n** Para instalar la solución satelital

1. La instalación se cargará y comenzará la instalación con la configuración definida

## Retroalimentación

Desea proporcionar comentarios sobre el [Proceso de instalación](/es/get-started/setup)? Las siguientes preguntas nos ayudan a mejorar el proceso.

{{<questions name="/content/es/get-started/setup-feedback.json" completed="Gracias por proporcionar comentarios" showNavigationButtons=true locale="es">}}
