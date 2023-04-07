---
title: "Satélite - Primeros pasos"
description: "Kit de automatización - Satélite - Primeros pasos"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Satellite']
generated: 425608BE149AA6D640338A5F34EB704ADDAAAEF5
---

# Visión general

Bienvenido a la página de inicio de la solución Satellite. Esta sección cubre los cambios importantes realizados en abril de 2023 y versiones posteriores. Después de abril de 2023, hemos eliminado la necesidad de Azure Key Vault para almacenar el inquilino de la aplicación de Azure, el identificador de la aplicación y la información secreta de la aplicación de Azure.

## Diseño conceptual

Nuestra página de aprendizaje describe el [Diseño conceptual](https://learn.microsoft.com/power-automate/guidance/automation-kit/overview/introduction#conceptual-design) del {{<product-name>}}. El elemento clave de la solución es el entorno Power Platform principal.

Por lo general, hay varios entornos de producción satelital que ejecutan sus proyectos de automatización. Dependiendo de su estrategia de entorno, estos también podrían ser entornos de desarrollo o prueba.

Entre estos entornos hay un proceso de sincronización casi en tiempo real que incluye telemetría de flujo de nube o escritorio, uso de máquinas y grupos de máquinas y registros de auditoría. El panel de Power BI para el Kit de automatización muestra esta información.

## Lo que ha cambiado

Como parte de la resolución [[Automation Kit - Feature]: alternativa de Azure Key Vault para entornos satélite](https://github.com/microsoft/powercat-automation-kit/issues/84) Azure Key Vault ya no es necesario. Esto es importante, ya que reduce significativamente la complejidad de la instalación y la forma en que se administra la seguridad para obtener artefactos de solución cuando se usa Automation Solution Manager.

## ¿Qué es lo mismo?

Una vez que los elementos clave son los mismos que las versiones anteriores a abril de 2023 y abril de 2023, es la necesidad de una aplicación de Azure Active Directory.

Un [Usuario de la aplicación](https://learn.microsoft.com/power-platform/admin/manage-application-users) es un tipo de usuario del Power Platform que se identifica por la presencia del atributo ApplicationId en el registro de usuario del sistema. Los usuarios de la aplicación se crean en Azure Active Directory (Azure AD) y se usan para autenticar y autorizar el acceso a la Power Platform. Normalmente se utilizan para representar una aplicación o servicio que necesita acceder a datos o realizar operaciones en el Power Platform en nombre de usuarios u otras aplicaciones.

Específicamente, el Administrador de soluciones de automatización usa el usuario de la aplicación para permitirle consultar los componentes de la solución en un entorno para que pueda permitir que un usuario mida una solución Power Platform implementada.

## Instalar

El [Instalación de línea de comandos](/es/get-started/install) para soluciones satélite le pedirá el nombre de la aplicación de Azure Active Directory y el identificador de aplicación de Azure Active Directory. Con esta información:

1. Agregar la aplicación de Azure Active Directory como usuario de la aplicación
1. Agregar el usuario de la aplicación a la función Administrador del sistema
1. Agregar el ID de usuario del usuario de la aplicación a la variable de entorno **Artefactos de Solution Manager Leer ID de usuario**

El nuevo rol dataverse rol **Usuario de Automation Solution Manager** se ha agregado que permite a los usuarios llamar a la nueva API personalizada Dataverse GetDataverseSolutionArtifacts de Dataverse que consultará los artefactos de la solución mediante la variable de entorno proporcionada **Artefactos de Solution Manager Leer ID de usuario**.

Si desea instalar la solución satelitte manualmente, se deben realizar los siguientes cambios en el [Configurar satélites](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/satellite) instrucciones.

1. Omita el paso "Agregar un nuevo secreto de cliente", ya que ya no es necesario para abril de 2023 o posterior.
1. Omita el paso para crear secretos en el Almacén de claves de Azure.
1. Agregue el ID de usuario del usuario de la aplicación a la carpeta **Artefactos de Solution Manager Leer ID de usuario** Variable de entorno.

## Después de la instalación

Asegúrese de que los usuarios que ejecutarán la aplicación Automation Solution Manager reciban la **Usuario de Automation Solution Manager** Rol de seguridad de Dataverse.

## Versiones anteriores

Antes de la versión de abril de 2023, las instalaciones de la solución satelital requerían variables de entorno de tipo secreto. Esto requirió un [Azure Key Vault](https://learn.microsoft.com/power-apps/maker/data-platform/environmentvariables#use-azure-key-vault-secrets-preview) para almacenar los valores de Id. de inquilino, Id. de aplicación y Secreto de aplicación. Para utilizar esta función también se requiere el [Prerrequisitos](https://learn.microsoft.com/power-apps/maker/data-platform/environmentvariables#prerequisites) de que Azure Key Vault es el mismo inquilino, configuración de Microsoft.PowerPlatform como proveedor de recursos.

En las versiones de marzo de 2023 o anteriores, Azure Key Vault se usaba para almacenar un identificador de inquilino, un identificador de aplicación y un secreto de aplicación. Con estos valores, se solicitó un token de acceso para consultar dataverse para que pudiera devolver la lista de componentes de la solución.

## Recomendaciones

Para los usuarios existentes, se recomienda simplificar la administración continua y eliminar la necesidad de una dependencia del Almacén de claves de Azure de actualizar la instalación satélite existente a abril de 2023 o posterior para aprovechar las nuevas características.
