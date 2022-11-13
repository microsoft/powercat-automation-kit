---
title: "Paquetes de datos"
description: "Kit de automatización - Paquetes de datos"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 59DCC2AA961720CBEBCC57AD3C8C2B774F7B3FD1
---

{{<toc>}}

## Introducción

Los paquetes de datos son un conjunto preempaquetado de datos que se pueden instalar opcionalmente en el kit de automatización instalado para acelerar su uso.

{{<border>}}
![Información general sobre los paquetes de datos](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks.svg)
{{</border>}}

<br/>

Introducido como parte de la [Noviembre 2022](/es/releases/november-2022), los paquetes de datos le permiten importar opcionalmente datos de ejemplo.

El paquete de datos de retorno de la inversión (ROI) le permite demostrar rápidamente la planificación, medición y supervisión del retorno de la inversión a través del panel de Power BI de Automation Kit. Puede cargar su primer paquete de datos utilizando el botón [Empezar](/es#getting-started) a continuación.

Con el tiempo, agregaremos otros paquetes de datos al backlog para priorizar y documentaremos cómo puede colaborar en la publicación de paquetes de datos para la comunidad.

## Hoja de ruta

{{<border>}}
![Hoja de ruta de paquetes de datos](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks-WhatsNext.svg?v=1)
{{</border>}}

<br/>

En futuros hitos, buscaremos mejorar los paquetes de datos incluyéndolos como parte opcional del proceso de instalación automatizada del Kit de automatización.

La capacidad de incluir paquetes de datos como parte de la instalación permitirá una instalación basada en web, en lugar del proceso de instalación de línea de comandos para esta versión.

## Solución principal de retorno de la inversión

El paquete de datos de la solución principal de retorno de la inversión (ROI) incluye proyectos de automatización, máquinas y telemetría de escritorio de Power Automate de muestra para que pueda ponerse manos a la obra con el proceso de extremo a extremo.

### Empezar

Para empezar a utilizar este paquete de datos

- Instalar Creator Kit desde [Origen de la aplicación](https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1) o vía [Aprenda la guía de configuración](https://learn.microsoft.com/power-platform/guidance/creator-kit/setup)

- Instale la versión más reciente del Automation Kit Main desde [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases) Usando [Aprenda la guía de configuración](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/main)

- Instalar Power Platform Command Line Interface mediante [Aprenda la guía de configuración](https://learn.microsoft.com/power-platform/developer/cli/introduction)

- Crear autenticación en su entorno

```pwsh
pac auth create --url https://contoso.crm.dynamics.com/
```

- Descargue el **AutomationKit.zip** De [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases)

- Extraiga el archivo **AutomationKit-SampleData.zip** De **AutomationKit.zip**

- Importar los datos en su entorno

```pwsh
pac data import -d AutomationKit-SampleData.zip --environment https://contoso.crm.dynamics.com/ 
```

- Conecte el panel de Power BI descargado desde con su entorno para explorar los datos importados. Uso [Instalar el panel de Power BI](/es/get-started/install-powerbi-dashboard) Para más información

## Retroalimentación

{{<questions name="/content/es/features/datapacks.json" completed="Gracias por proporcionar comentarios" showNavigationButtons="false" locale="es">}}
