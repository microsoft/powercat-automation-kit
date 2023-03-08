---
title: "Programador"
description: "Kit de automatización - Programador"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: CB8CDD66959E9D2E4AE7FD54BE0C6D04AA2A02E3
---

{{<toc>}}

## Introducción

El Programador del kit de automatización permite ver la programación de flujos recurrentes de Power Automate Cloud dentro de Soluciones que incluyen llamadas a flujos de Power Automate Desktop.

Esta característica se actualizó como parte de la [Marzo 2023](/es/releases/march-2023), las versiones posteriores continuarán mejorando y aumentando la funcionalidad del programador.

{{<border>}}
![Programador](/images/schedule.png)
{{</border>}}

Las características clave del programador son:

- La capacidad de ver la programación de flujos de nube recurrentes
- Programación de filtros por máquina y grupos de máquinas
- Ejecutar un flujo de Power Automate Desktop
- Ver programación por día, semana, mes y vista de programación
- Ver el estado de los flujos programados (correctos, fallidos o programados)
- Ver la duración de una ejecución de Cloud Flow
- Ver los detalles de cualquier error.

## Flujos de nube

Como se señaló anteriormente, solo los flujos de nube que se incluyen como parte de una solución. El reciente [https://powerautomate.microsoft.com/blog/more-manageable-cloud-flows-with-dataverse-solutions-by-default/](https://powerautomate.microsoft.com/vi-vn/blog/more-manageable-cloud-flows-with-dataverse-solutions-by-default/) incluye información sobre cómo usar la nueva versión preliminar de "Soluciones de Dataverse de forma predeterminada" para ayudar a garantizar que los flujos de nube se incluyan en las soluciones. El uso de esta función puede ayudar a los usuarios a garantizar que los flujos de nube programados que se crean sean visibles en el programador.

## Vistas de calendario

## Vistas de día, semana, mes

Las vistas de día, semana y mes muestran información sobre las ejecuciones de flujo de Desktop Cloud que se han ejecutado o están programadas para ejecutarse.

Los elementos están codificados por colores de la siguiente manera:

- El verde indica que la ejecución se ha ejecutado correctamente

- El rojo indica que se ha producido un error de ejecución

- El azul indica una ejecución futura programada.

La información de estado y ejecución está disponible con un toque prolongado o pasar el mouse sobre el evento.

### Horario

{{<border>}}
![Programador - Ejecutar ahora](/images/scheduler-schedule-view.png)
{{</border>}}

La vista de programación incluye un conjunto de flujos de nube basados en el tiempo de la hora actual y los flujos programados futuros en los próximos días.

## Ejecutar ahora

{{<border>}}
![Programador - Ejecutar ahora](/images/scheduler-run-now.png)
{{</border>}}

La versión actual de Ejecutar ahora ejecutará el escritorio de Power Automate. Se supone que no hay parámetros necesarios para ejecutar el flujo de escritorio. La información adicional de ejecución está disponible en la información de última ejecución del escritorio.

### Cambios planificados

En futuras versiones, se considerarán nuevas características las siguientes:

1. Ejecute el flujo de nube en lugar del flujo de escritorio. Esto incluirá el historial de ejecución del flujo de nube y la ejecución de cualquier acción y parámetros adicionales de flujo de nube que se pasen al flujo de escritorio.

2. Ejecute Power Automate Desktop con un estado diferente.

3. Abra las páginas de ejecución de flujo de escritorio y nube.

### Comportamiento de solo lectura de flujos programados

De forma predeterminada, cuando un flujo se programa para su ejecución futura, se establece en modo de solo lectura y se deshabilita para su ejecución inmediata. Esto significa que los usuarios no pueden modificar o ejecutar el flujo hasta que haya pasado la fecha y hora programadas. Este comportamiento está diseñado para proporcionar una mejor experiencia de usuario y evitar la ejecución accidental de flujos antes de que se pretenda ejecutar.
Hay varios beneficios para este enfoque, incluyendo:

- Prevención de la ejecución accidental: al deshabilitar la ejecución inmediata de flujos programados para ejecución futura, es menos probable que los usuarios ejecuten accidentalmente un flujo antes de que se pretenda que se ejecute.

- Previsibilidad mejorada: Al establecer los flujos en modo de solo lectura cuando están programados para su ejecución futura, los usuarios pueden predecir más fácilmente cuándo se ejecutarán los flujos y asegurarse de que tienen listas las entradas y los recursos necesarios.

- Experiencia de usuario coherente: al estandarizar el comportamiento de los flujos programados, puede proporcionar una experiencia de usuario coherente y predecible en todas las instancias de Flow.

- Para modificar o ejecutar un flujo programado, los usuarios pueden editar el flujo y actualizar la fecha y hora programadas. Una vez que se haya establecido la nueva programación, el flujo se deshabilitará una vez más para su ejecución inmediata y se establecerá en modo de solo lectura hasta que la nueva programación haya pasado.

## Mensajes de error

Posibles mensajes de error que podrían producirse al ejecutar el flujo de ejecución.

### Mensaje de error: "InvalidArgument - No se puede encontrar una conexión válida asociada con la referencia de conexión proporcionada".

#### Descripción

Este mensaje de error normalmente indica que hay un problema con la referencia de conexión proporcionada en el código o la configuración. El sistema no puede localizar una conexión válida asociada a la referencia, lo que le impide ejecutar la acción solicitada.

#### Causas

Hay varias causas potenciales para este mensaje de error, incluyendo:

- Referencia de conexión incorrecta o no válida: la referencia de conexión proporcionada puede ser inválida o incorrecta, lo que puede provocar que el sistema no encuentre una conexión válida asociada a ella.

- Conexión eliminada o cambiada: Si la conexión utilizada en el código o la configuración se ha eliminado o modificado, puede provocar que el sistema no pueda localizar una conexión válida asociada con la referencia.

- Problema de permisos: es posible que la cuenta de usuario que ejecuta el código o la configuración no tenga los permisos necesarios para acceder a la conexión o a los recursos asociados a ella.

#### Resolución

Para resolver este problema, puede realizar los pasos siguientes:

- Verifique la referencia de conexión: compruebe la referencia de conexión proporcionada en el código o la configuración y asegúrese de que es válida y correcta.

- Eliminar conexiones existentes y volver a crear: Si el Comprobador de flujo advierte que no se ha utilizado una referencia de conexión, puede utilizar el Comprobador de flujo para eliminar las conexiones existentes. Una vez eliminadas las conexiones, puede volver a crear referencias de conexión al equipo o grupo de máquinas para permitir que se ejecute el flujo.

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
