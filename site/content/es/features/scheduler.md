---
title: "Programador"
description: "Kit de automatización - Programador"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: B8DC4418FD2312850E01B5DB52344E2BB9B93C2F
---

{{<toc>}}

## Introducción

El Programador del kit de automatización permite ver la programación de flujos recurrentes de Power Automate Cloud dentro de Soluciones que incluyen llamadas a flujos de Power Automate Desktop.

Esta característica se introdujo como parte de la [Febrero 2023](/es/releases/february-2023), las versiones posteriores continuarán mejorando y aumentando la funcionalidad del programador.

{{<border>}}
![Programador](/images/schedule.png)
{{</border>}}

Las características clave del programador son:

- La capacidad de ver la programación de flujos de nube recurrentes
- Ver programación por día, semana, mes y vista de programación
- Ver el estado de los flujos programados (correctos, fallidos o programados)
- Ver la duración de una ejecución de Cloud Flow
- Ver los detalles de cualquier error.

## Notas

Para la versión actual, se aplican las siguientes notas

1. Solo se muestran las soluciones Power Automate Desktop y Power Automate incluidas en una solución
1. Se ha registrado y ejecutado al menos un Power Automate Desktop

## Instalar

Para instalar la solución del programador, puede hacer lo siguiente:

1. Garantizar el marco de componentes de Power Apps <a href="https://learn.microsoft.com/en-us/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">Leer más</a>
1. Has instalado Creator Kit en el entorno de destino. <a href="https://appsource.microsoft.com/en-us/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">Instalar desde el origen de la aplicación</a>
1. Ha descargado el archivo AutomationKit.zip desde la sección Activos de la última versión <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">Versión de GitHub</a>
1. Ha importado el último AutomationKitScheduler_*_administrado.zip archivo usando. <a href='https://learn.microsoft.com/en-us/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">Leer más</a>

## Hoja de ruta

Puedes visitar nuestro <a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">Problemas de GitHub</a> para ver las nuevas características propuestas.

Puede agregar un nuevo <a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">Solicitud de característica del programador</a>

## Retroalimentación

{{<questions name="/content/es/features/scheduler.json" completed="Gracias por proporcionar comentarios" showNavigationButtons="false" locale="es">}}
