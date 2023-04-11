---
title: "Power CAT Application Lifecycle Management (ALM)"
description: "Kit de automatización - ALM Power CAT"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['ALM', 'Guidance', 'PowerCAT']
generated: 9EBA5424FE312098C68ECEF453107114F7F5EB5C
---

{{<slideStyles>}}

<div class="optional">

El kit de automatización aprovecha el [Acelerador ALM](https://aka.ms/aa4pp) para proporcionar funcionalidad de ALM para soluciones que incluyen Power Automate Desktop

</div>

{{<presentation slides="1,2">}}


<div class="optional">

{{<presentationStyles>}}

## Proceso de implementación de GitHub

Similar al proceso de lanzamiento utilizado para otros kits administrados por Power CAT, el {{<product-name>}} usa el acelerador de ALM para implementar versiones en nuestras versiones públicas de GitHub.

Nuestro proceso interno tiene un entorno Power Platform para Desarrollo, Prueba y Producción. Una vez que estamos listos para un lanzamiento, nuestras Acciones de GitHub integradas empaquetan las soluciones de implementación administradas y no administradas junto con las notas de la versión automáticamente para una versión de GitHub Draft.

Una vez que el borrador de la versión esté listo, podemos publicar nuevas versiones o revisiones según sea necesario.

### Lo que esto significa para usted

Ahora que tenemos esta automatización en su lugar, la versión automatizada de ALM tiene los siguientes beneficios para usted:

- Visibilidad de todo el código fuente de código bajo que compone el kit de automatización para que pueda investigar cómo hemos construido el kit.

- Proceso de automatización optimizado que puede responder a errores o problemas rápidamente y proporcionar revisiones si es necesario.

- Compilación automatizada de todos los errores y características que se incluyen en una versión.

- Incluimos Power Apps, Power Automate, Dataverse y Power Automate Desktop como parte de nuestro proceso ALM para nuestra integración continua / implementación continua.

## Hoja de ruta

Puede investigar nuestros elementos de trabajo pendiente relacionados con ALM abiertos en nuestro [Registro de problemas de GitHub](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm)

En general, nos basamos en las características existentes de Power Platform y del producto Microsoft DevOps junto con ALM Accelerator. Esta combinación nos permite centrarnos en extensiones específicas que ayudan con la hiperautomción.

## Retroalimentación

{{<questions name="/content/es/features/alm/powercat.json" completed="Gracias por proporcionar comentarios" showNavigationButtons="false" locale="es">}}

</div>

{{<slide  id="slide1" audio="features/alm/powercat/overview.mp3" description="Power CAT ALM Overview" localImage="/images/illustrations/alm-roadmap-2022-11.svg" >}}

El equipo de Power CAT utiliza el acelerador ALM para crear e implementar cada uno de nuestros [Libera](https://github.com/microsoft/powercat-automation-kit/releases).

Cada versión promueve cambios de nuestro desarrollo en entornos de prueba y producción. Las Power Platform soluciones dentro del kit usan un proceso automatizado para empaquetar activos para su implementación en versiones públicas de GitHub.

En futuros hitos ampliaremos la plataforma existente [Características de ALM](/es/features/alm) para proporcionar ejemplos de cómo incluir reglas de validación y comparación visual de muestras de RPA como parte del proceso de DevOps.  

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/powercat/release-process.mp3" description="Power CAT Automation Kit Release Checker" localImage="/images/illustrations/alm-powercat-process.svg" >}}

A continuación se describen los pasos clave en el proceso de lanzamiento del Kit de automatización:

1. Los cambios realizados en nuestro entorno de desarrollo Power Platform se guardan en una rama del repositorio público de GitHub.

2. Cuando los cambios están listos para su inclusión en una versión de prueba, se combinan en la rama principal mediante una solicitud de extracción. Antes de que se pueda completar la solicitud de extracción, la canalización de validación de Azure DevOps debe completarse correctamente y revisar la solicitud de extracción.

3. Una vez que la solicitud de extracción ha pasado las comprobaciones automatizadas y ha recibido la aprobación de revisión, se puede fusionar en la rama principal. Esta combinación desencadena la canalización de compilación de Azure DevOps de prueba, que publica la compilación administrada en el entorno de Power Platform de prueba.

4. Después de las pruebas internas, la canalización de producción de Azure DevOps se desencadena manualmente para generar una implementación de Power Platform de producción.

5. Una vez que está lista una versión, la canalización de Azure DevOps crea un borrador de la versión que incluye notas de la versión y activos de compilación. La compilación final de la versión cerrará todos los problemas abiertos y cerrará el hito. Etiqueta de compilación publicada del repositorio de GitHub con una etiqueta de mes y año aplicada.

{{</slide>}}
