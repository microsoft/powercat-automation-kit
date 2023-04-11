---
title: "Administración del ciclo de vida de las aplicaciones (ALM)"
description: "Kit de automatización - ALM"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['ALM', 'Guidance']
generated: CFA547EC584269A54557898046D235E91F77E46A
---

{{<slideStyles>}}

<div class="optional">

Esta página proporciona información general sobre los componentes que pueden ayudarle a usar ALM con el Kit de automatización para flujos de trabajo de Power Automate Desktop incluidos en [Soluciones Power Platform](https://learn.microsoft.com/power-platform/alm/solution-concepts-alm).

</div>

{{<presentation slides="1,2,3,4,5,6,7">}}

<div class="optional">

{{<presentationStyles>}}

## Resumen

Al buscar ALM soluciones Power Platform que incluyan componentes de escritorio de Power Automate

1. Revise las características de Managed Environment Power Platform Pipelines para aprovechar las características integradas en el producto a escala empresarial para administrar y gobernar soluciones dentro de entornos.

<br/>

2. Si es necesario, investigue el [Microsoft Power Platform Build Tools para Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools), [Acciones de GitHub para Microsoft Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions) o [Power Platform CLI](https://learn.microsoft.com/power-platform/developer/cli/introduction) para integrar y automatizar sus procesos de DevOps de ALM.

<br/>

3. Considere la posibilidad de utilizar el [Acelerador ALM para Power Platform](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-components). El acelerador de ALM proporciona un conjunto precompilado de plantillas de Azure DevOps que automatiza muchas de las tareas de ALM Power Platform mediante el gobierno de control de código fuente integrado.

## Aprendiendo de Power CAT

También puede leer más sobre cómo nosotros, como equipo de Power CAT, usamos ALM Accelerator para enviar el [Kit de automatización Power CAT ALM](/es/features/alm/powercat).

## Recursos

[Acelerador de ALM para Power Platform catálogo de aprendizaje](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog)

## Hoja de ruta

El equipo del kit de automatización está trabajando con el equipo de ALM Accelerator para agregar tareas específicas de Power Automate Desktop a las plantillas existentes que cubren:

- Comparación en paralelo de las definiciones de Power Automate Desktop.

- Comprobaciones de reglas de validación para Power Automate Desktop.

- Ejecución de pruebas unitarias, de integración y de sistemas como parte del pipeline de CI/CD.

Revisa nuestro [Backlog relacionado con Automation Kit ALM](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm).

## Retroalimentación

{{<questions name="/content/es/features/alm.json" completed="Gracias por proporcionar comentarios" showNavigationButtons="false" locale="es">}}

</div>

{{<slide  id="slide1" audio="features/alm/managed-environments-overview.mp3" description="Managed Environments Overview" image="features/alm/managed-environments-overview.svg" >}}

Los entornos administrados le proporcionan la capacidad de optimizar y simplificar el gobierno a escala. Los administradores pueden activar entornos administrados con solo unos pocos clics e iluminar inmediatamente las funciones que proporcionan más visibilidad, más control con menos esfuerzo para administrar todos sus activos de código bajo.

Los entornos administrados son una parte clave de la familia Power Platform, de la misma manera que AI Builder infundió inteligencia en nuestros productos y Dataverse proporciona la columna vertebral de datos. Los entornos administrados optimizan el gobierno de la plataforma a escala.

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/managed-environments-features.mp3" description="Managed Environments Features" image="features/alm/managed-environments-features.svg" >}}

Los entornos administrados le proporcionan:

- Más visibilidad con información de uso en la página de inicio, correos electrónicos de resumen de administrador, informes de licencias y vistas de políticas de datos
- Más control con límites de uso compartido, lo que le permite controlar con qué amplitud y con cuántas personas se pueden compartir los flujos de aplicaciones y soluciones de lienzo.
- También puede restringir el uso compartido a grupos de seguridad limitados.
- Configurar el comprobador de soluciones para que las comprobaciones de seguridad o confiabilidad ejecuten reglas automáticamente cada vez que se importe una solución a un entorno administrado
- Personaliza la experiencia de bienvenida y uso compartido del creador para guiar a los usuarios por el camino correcto.
- Menos esfuerzo Optimice, simplifique y automatice los pasos listos para usar con solo unos pocos clics. 
- Las canalizaciones de Power Platform proporcionan la capacidad de simplificar el proceso de administración del ciclo de vida de las aplicaciones (ALM).

{{</slide>}}

{{<slide  id="slide3" cdnVideo="features/alm/managed-environments-power-platform-pipelines-demo.mp4" description="Power Platform Pipelines Demo" >}}

Esta es una solución con la que estoy trabajando en el Portal del creador.

He seguido adelante para seleccionar esta canalización que ya se ha configurado. Las canalizaciones son básicamente una serie de pasos automatizados que mueven su trabajo de un entorno a otro. Esta canalización llevará mi solución del entorno de desarrollo de la izquierda al entorno de prueba. Luego hay otra etapa para llevarlo de la prueba a la producción.

Vamos a implementar para probar, seleccione siguiente y aquí, confirmaré mis conexiones para probar el entorno para asegurarme de que estoy usando las credenciales correctas. A continuación, configuraré mis variables de entorno para asegurarme, por ejemplo, de que estoy apuntando al sitio de SharePoint correcto en la prueba. Esto es importante si el sitio era diferente al que estaba usando en desarrollo. 

Una vez que lo configuré todo, puedo seleccionar "Implementar" y las validaciones previas se ejecutan automáticamente para que tenga las dependencias correctas y la solución no viole las políticas de DLP en ese entorno de destino. La canalización también se puede configurar para que se requiera aprobación antes de que se pueda ejecutar la implementación. 

Parece que todo fue exitoso aquí.

Después de ejecutar mi canalización, obtengo visibilidad completa y un registro de auditoría de las implementaciones en toda mi organización con cada solución respaldada y versionada.

{{</slide>}}

{{<slide  id="slide4" audio="features/alm/managed-environments-feature-availability.mp3?v=1" description="Managed Environments Availability" image="features/alm/managed-environments-feature-availability.svg?v=1" >}}

Las características se implementarán en fases. Algunos de ellos, como los resúmenes de administración y los límites de uso compartido, están disponibles hoy. El resto se implementará a finales de año.

En las próximas semanas y meses, verá información sobre el uso en la página de inicio. Nuevas tendencias en los resúmenes de administración e informes para el uso con licencia. Los límites de uso compartido obtendrán más controles y admitirán flujos de soluciones. Podrá bloquear implementaciones no seguras con Solution Checker. Las capacidades de incorporación y canalización del fabricante de clientes también llegarán a finales de este año.

{{</slide>}}

{{<slide  id="slide5" audio="features/alm/pipeline-extensibility.mp3?v=1" description="Pipeline Extensibility" image="features/alm/pipeline-extensibility.svg?v=1" >}}

Tiene varias opciones a considerar para sus opciones de ALM en el Power Platform. El entorno administrado Power Platform canalizaciones proporcionan en la gestión del ciclo de vida de las aplicaciones del producto.

Opcionalmente, puede utilizar los puntos de extensión del entorno administrado Power Platform canalizaciones combinadas con [Power Platform Herramientas de compilación para Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools)el [Acciones de GitHub para Microsoft Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions) o [Power Platform CLI](https://learn.microsoft.com/power-platform/developer/cli/introduction) para implementar sus propios procesos personalizados de ALM DevOps.

Finalmente podrías aprovechar el [Acelerador ALM para Power Platform](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog) desde el kit de CoE para proporcionar plantillas y ejemplos precompilados para ALM de un extremo a otro mediante Azure DevOps. El acelerador de ALM proporciona muchos escenarios comunes para crear y gobernar sus soluciones en todos los entornos.

{{</slide>}}

{{<slide  id="slide6" audio="features/alm/alm-accelerator-for-power-platform-overview.mp3?v=1" description="ALM Accelerator for Power Platform Overview" image="features/alm/alm-accelerator-for-power-platform-overview.svg?v=1" >}}

¿Qué es ALM Accelerator for Power Platform?

El acelerador de ALM para Power Platform incluye Power Apps que se encuentra sobre Azure DevOps Pipelines y el control de código fuente Git. La aplicación proporciona una interfaz simplificada para que los fabricantes exporten regularmente los componentes de sus soluciones Power Platform al control de código fuente y creen solicitudes de implementación para que su trabajo se revise antes de implementarlo en los entornos de destino.

{{</slide>}}

{{<slide  id="slide7" audio="features/alm/alm-accelerator-for-power-platform-workflow.mp3?v=1" description="ALM Accelerator for Power Platform Workflow" image="features/alm/alm-accelerator-for-power-platform-workflow.svg?v=1" >}}

En cuanto al flujo de trabajo de ALM Accelerator, comienza con los entornos de desarrollo. Su interacción con el proceso de ALM se realiza a través de la aplicación ALM Accelerator Canvas o Managed Environment Pipelines

Los creadores usan la aplicación ALM Accelerator Canvas para sus tareas de ALM, como importar la solución desde el control de código fuente, exportar cambios al control de código fuente y crear solicitudes de extracción para combinar cambios

Las plantillas de ALM Accelerator para canalizaciones de Azure DevOps facilitan la automatización de tareas de ALM basadas en la interacción de Makers con la aplicación ALM Accelerator Canvas

ALM Accelerator incluye plantillas de canalización para admitir una implementación de 3 etapas en producción.
Las plantillas se pueden personalizar para adaptarse a necesidades y escenarios específicos

ALM Accelerator for Power Platform es una aplicación de lienzo que se encuentra sobre Azure DevOps Pipelines para proporcionar una interfaz simplificada para que los creadores se confirmen y creen solicitudes de incorporación de cambios periódicas para su trabajo de desarrollo en el Power Platform. 

La combinación de Azure DevOps Pipelines y la aplicación Canvas son las que conforman la solución completa de ALM Accelerator for Power Platform. 
Las canalizaciones y la aplicación son implementaciones de referencia. Fueron desarrollados para su uso por el equipo de desarrollo para el CoE Starter Kit internamente, pero han sido de código abierto y lanzados para demostrar cómo se puede lograr ALM saludable en el Power Platform. Se pueden usar tal cual o personalizar para escenarios empresariales específicos.

{{</slide>}}
