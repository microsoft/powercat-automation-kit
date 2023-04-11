---
title: "Instalación de línea de comandos"
description: "Kit de automatización - Instalar"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Install']
generated: 41BD476CCC700CAAAD43657E9716A73ABDD00A15
---

<div class="optional">

Para instalar la versión más reciente del Kit de automatización mediante la línea de comandos, puede seguir estos pasos. Si no puede utilizar las herramientas de línea de comandos, puede utilizar los pasos manuales documentados en [Guía de configuración](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/prerequisites).

1. Asegúrese de que tiene <a ref='https://learn.microsoft.com/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature' target="_blank">Habilitar la característica del marco de componentes de Power Apps</a> en los entornos en los que desea instalar el Kit de automatización para entornos principal y satélite.

1. Asegúrese de que el <a href="https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1?tab=Reviews" target="_blank">Creator Kit instalado</a> en los entornos en los que desea instalar

1. Abra la versión más reciente desde el <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">Lanzamiento de GitHub de Automation Kit</a>

1. Descargue el **AutomationKitInstall.zip** de la sección Activos

1. En el Explorador de Windows, seleccione el descargado **AutomationKitInstall.zip** y abra el cuadro de diálogo Propiedades

1. Seleccione la opción **Desbloquear** botón

1. Escoger **AutomationKitInstall.zip** y use el menú contextual para **Extraer todo**

1. Asegúrese de que tiene el <a href="https://learn.microsoft.com/power-platform/developer/cli/introduction" target="_blank">Power Platform CLI</a> Instalado

1. Ejecutar el script de PowerShell mediante la siguiente línea de comandos

```cmd
cd AutomationKitInstall
powershell Install_AutomationKit.ps1
```

NOTA:
1. En función de la directiva de ejecución de PowerShell, es posible que deba ejecutar el siguiente comando

```cmd
Unblock-File Install_AutomationKit.ps1
```

1. El script de PowerShell le pedirá que cree un archivo de configuración de instalación mediante [Instalar el programa de instalación](/es/get-started/setup). Las páginas de configuración del programa de instalación le proporcionarán lo siguiente

    - Seleccione la configuración para soluciones principales o satelitales
   
    - Seleccionar usuarios para asignar a grupos de seguridad
   
    - Crear las conexiones necesarias para instalar la solución
    
    - Definir variables de entorno
    
    - Opcionalmente, defina si se deben importar datos de muestra
    
    - Opcionalmente, se debe habilitar Habilitar Power Automate Los flujos contenidos en las soluciones deben estar habilitados

1. Después de completar los pasos de configuración del sitio web, puede copiar descargado **automation-kit-main-install.json** o **automation-kit-satellite-install.json** a la carpeta **AutomationKitInstall** carpeta anterior

1. Una vez descargado el archivo, el script solicitará **y** para instalar la solución principal, **n** Para instalar la solución satelital

1. La instalación se cargará y comenzará la instalación con la configuración definida

## Retroalimentación

Desea proporcionar comentarios sobre el [Proceso de instalación](/es/get-started/setup)? Las siguientes preguntas nos ayudan a mejorar el proceso.

{{<questions name="/content/es/get-started/setup-feedback.json" completed="Gracias por proporcionar comentarios" showNavigationButtons="false" locale="es">}}

</div>

