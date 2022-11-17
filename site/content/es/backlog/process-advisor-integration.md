---
title: "Process Advisor Integración"
description: "Kit de automatización - Integración Process Advisor"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 4B988356292B6E69CAEB1E5D4AFB4A272A7131BE
---
--------------|---------------|-------------|
Duration Total (Total Processing Time in minutes)|Duration Total Per activity|Top-level metrics currently only median and average duration which can be transformed with some customization
Case frequency| (volume per process frequency)|Case count||
Resource count (Number of FTEs needed, Number of FTEs needed for Review/Rework)|Resource count
Rework percentage (AVG Error Rate %)|Rework percentage||
Currency||In Process Advisor data model

## Semi Automated Automation Project

Using the data collected in the Process Advisor in your Power BI custom workspace you can integrate the results using Power Automate or Power Apps.

![Automation Kit Process Advisor Integration](/images/illustrations/process-advisor-integration.svg)

Using the Process Advisor Import process simplifies the amount of information that needs to be entered and offers you a choice of options to integrate with you Automation Project.

Reviewers of the Automation Project and take into account the Process Advisor results when considering if they should Approve or Deny the Automation Project request.

NOTE:

1. We currently have items on the Automation Kit backlog to add additional templates and applications in upcoming milestones that enable you quickly get started with integrating your Processed Advisor data with the Automation Kit.

2. More information on configuring your Process Advisor analysis with a custom workspace can be found in [Load your process analytics in power bi](https://learn.microsoft.com/en-us/power-automate/process-mining-pbi-workspace#load-your-process-analytics-in-power-bi)

### Power Automate Templates

You could use out of the box Power BI connector actions and Power Automate cloud flows to create or update you Automation Kit projects.

## Questions

{{<questions name="/content/en-us/backlog/process-advisor-integration.json" completed="Thank you for completing Process Advisor questions" showNavigationButtons=false >}}

El {{<product-name>}} se integra con [Process Advisor](https://learn.microsoft.com/en-us/power-automate/process-advisor-overview) para admitir los siguientes escenarios:

- **Procesamiento de Minería** Análisis de Procesos de Negocio para identificar y apoyar el caso de negocio para crear Proyectos de Automatización soportados por análisis de datos.

- **Solicitudes de proyectos de automatización basada en datos** Utilice los resultados de su análisis de procesos para crear un proyecto de automatización a partir de Process Advisor resultados.

- **Creación de proyectos de automatización semiautomatizados** Integre datos de Dataverse entre Process Advisor y Automation Kit para reducir la cantidad de trabajo para crear Automation Project.

- **Análisis de Power Automate Desktop** Analice los datos de proceso de RPA para identificar mejoras para modernizar, mejorar la resiliencia y la confiabilidad mediante la minería de tareas.

## Procesamiento de Minería

El uso de Process mining with Process Advisor le permite descubrir ineficiencias en los procesos de toda la organización. Esta información le permite obtener una comprensión profunda de sus procesos utilizando archivos de registro de eventos que puede obtener de su sistema de grabación (aplicaciones que usa en sus procesos). La minería de procesos muestra mapas de sus procesos con datos y métricas para reconocer problemas de rendimiento. Ejemplos de procesos adecuados para la minería de procesos incluyen cuentas por cobrar y pedidos a efectivo.

Estos datos le permiten crear solicitudes de proyectos de automatización basadas en datos.

## Creación de Proyectos de Automatización

Con los resultados de Process Advisor minería de procesos e informes, puede utilizar la siguiente información Process Advisor para respaldar su proyecto de automatización utilizando Process Advisor resultados de análisis calculados:

Kit de automatización|Process Advisor|Notas        |
