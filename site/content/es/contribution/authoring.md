---
title: "Directrices de creación"
description: "Kit de automatización: directrices para la creación de documentación"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Documentation', 'Guidelines']
generated: 14D75C24ABEB1ED3FEA30F2368EA2AB7E9CCEB2C
---

En las secciones siguientes se describen las directrices y notas para crear documentación inicial.

{{<toc>}}

## Directrices

En las secciones siguientes se describen las directrices técnicas, de diseño y basadas en resultados para la creación de contribuciones.

## Metas

A medida que construimos nuestra documentación, es importante considerar cómo permitimos a nuestros lectores **Caer en el pozo del éxito**.

Brad Abrams definido [El pozo del éxito en 2003](https://web.archive.org/web/20160705182659/https://blogs.msdn.microsoft.com/brada/2003/10/02/the-pit-of-success/) como

> El pozo del éxito: en marcado contraste con una cumbre, un pico o un viaje a través de un desierto para encontrar la victoria a través de muchas pruebas
> y sorpresas, queremos que nuestros clientes simplemente caigan en prácticas ganadoras
> mediante el uso de nuestra plataforma y marcos. En la medida en que hacemos que sea fácil meterse en problemas, fracasamos.

Dado este objetivo, considere lo siguiente:

- Proporcionar una "experiencia sin acantilados"

  - Ayudar a los administradores y a los equipos de gobierno central a crear un modelo de autoservicio de uso de {{<product-name>}}

  - Permitir a los usuarios hacer uso de entornos de desarrollo para ponerse manos a la obra si un entorno central no está disponible y desean características antes de una implementación de prueba o producción de {{<product-name>}}

  - Discuta el uso de entornos de prueba con una configuración fácil para ponerse manos a la obra con {{<product-name>}}

- Proporcione un canal para la retroalimentación. Dar opciones para que los clientes proporcionen información sobre lo que podemos mejorar

### Control de código fuente

- Has completado [Documentación](/es/contribution/documentation) pasos para descargar y enviar cambios al repositorio de GitHub
- Los nuevos cambios se envían a una nueva rama y tienen una solicitud de extracción para revisar los cambios
- Toda la documentación debe ser markdown, JSon o activos estáticos que puedan ser controles de versión y revisarse mediante el proceso estándar de solicitud de extracción.

## Directrices de diseño

### Página principal

- Tener un título y subtítulo claros que describan el objetivo de la experiencia inicial
- Proporcione un llamado a la acción para incluir otros eventos relacionados. Por ejemplo, regístrese para el horario de oficina.
- Enlace a la acción de introducción como acción principal para ayudar a los nuevos usuarios a incorporarse
- Acción secundaria para unirse al horario de oficina para ayudar a construir una comunidad de usuarios
- Incluir mosaicos de acciones comunes
- Lista resumida de características que ayudan a los usuarios a administrar proyectos de hiperautomatización
- Navegación de pie de página para vínculos comunes.

Lea el [Configuración del sitio](/es/contribution/site-configuration) para obtener más información sobre la configuración de la página principal.

### Reutilización

- Utilice diseños de hugo para poder especificar un nuevo tema o anular el tema actual colocando contenido en la carpeta site\layouts
- Cambiar los diseños debería permitir que se incluya HTML estático en muchas ubicaciones de alojamiento. Por ejemplo

  - Páginas de GitHub
  - Páginas de energía
  - Compartir punto
  - Sitios web estáticos de Azure

- El enfoque puede ser utilizado como plantillas por los socios o clientes para crear "paquetes de documentación" para acelerar la fase de nutrición de {{<product-name>}} documentación
- Proporcionar la capacidad para múltiples usuarios de la documentación (por ejemplo, equipos del Centro de excelencia de clientes y socios)
- Permitir que se incluya contenido proporcionado por el usuario
- Permitir el proceso de actualización que permite extraer nuevos cambios de {{<product-name>}} Documentación inicial

## Páginas de Markdown

- Puedes usar [Código de Visual Studio](https://code.visualstudio.com/) Para editar los archivos de Markdown

- Los archivos Markdown deben estar ubicados en la carpeta /site/content

- Cada archivo de markdown debe incluir un encabezado común en cada página

```toml
title: Sample page
description: Automation Kit sample page
sidebar: false
sidebarlogo: fresh-white
include_footer: true
```

- Los archivos Markdown deben usar códigos cortos para incrustar cualquier JavaScript

## códigos cortos

Los códigos cortos proporcionan la capacidad de incluir contenido dinámico en una página de rebajas. Puede leer más sobre los códigos cortos en el [Documentación de código abreviado de Hugo](https://gohugo.io/content-management/shortcodes/)

Este proyecto también incluye shortcodes adicionales

### Tabla de contenidos

Agregue el **Toc** Siguiendo el shortcode a su Markdown para incluir una tabla de contenido de encabezados Markdown en la página rodeada de \{\{ y \}\}

```html
<toc/>
```

### Pregunta

Incluye un conjunto de preguntas en tu página rodeado de \{\{ y \}\}

```html
<questions name="/content/en-us/foo.json" completed="Thank you for completing foo" showNavigationButtons=false />
```

Parámetros:

- **nombre** Nombre del archivo JSon que incluye las preguntas que se van a importar. Leer [Preguntas](/es/contribution/questions) Para obtener más información sobre el formato de archivo de pregunta
- **completado** El texto que se mostrará cuando se completen las preguntas
- **showNavigationButtons** valor verdadero/falso para zapatar Botones de navegación Siguiente/Atrás/Completado

### Imagen externa

Incluye una imagen de tamaño de una fuente externa en tu página rodeada de \{\{ y \}\}

```html
<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon"/>
```

Parámetros:

- **Fuente** La ruta de origen a la imagen que se va a importar
- **tamaño** El tamaño en píxeles para cambiar el tamaño de la imagen de origen a
- **Mensaje de texto** El texto alternativo que se va a incluir con la imagen

## Notas

### Configuración de páginas de GitHub

Los siguientes pasos se usaron para configurar las páginas de GitHub para el sitio

1. Rama Comprobar documentación

    ```bash
    git checkout gh-pages
    ```

1. Hugo extended está instalado

    - También puede instalar con chocolatey en Windows
 
    ```bash
    choco install hugo-extended -confirm
    ```

1. Cambiar a la carpeta del sitio

    ```bash
    cd site
    ```

1. Probar los cambios

    ```bash
    hugo serve
    ```

1. Para crear el sitio html estático dentro de la carpeta del sitio, ejecute el siguiente comando

    ```bash  
    hugo
    ```
 
1. Empuja tu rama gh-pages a GitHub

1. Configurar el proyecto de GitHub para habilitar Pages

    - Consulta Configurar un origen de publicación para tu sitio de Páginas de GitHub - Documentos de GitHub
    - Rama gh-pages seleccionada y carpeta /docs

### Actualizar la insignia de imagen de la página de inicio

Para personalizar la imagen de la página de inicio a una insignia de vista previa de Estado: Público, hago lo siguiente:

1. Clonar el repositorio svg-badges

    ```bash
    git clone https://github.com/anouarhassine/svg-badges.git
    cd svg-badges   
    ```

1. Instalar módulos

    ```bash
    npm install
    ```

1. Inicie el servidor web para generar insignias

    ```bash
    npm run start
    ```

1. Generar insignia

    ```link
    http://localhost:9000/static/Status-Public%20Preview-Green
    ```

1. Descargar la insignia svg

1. Usar inkscape para editar svg existente y guardar resultados

1. Cargar nueva imagen en la carpeta static\images\illustrations

1. Cambiar la imagen de config.yaml hero

    ```yml
    params:
        hero:
            image: illustrations/worker-public-preview.svg 
    ```

## Preguntas y respuestas

### **Pregunta** ¿Por qué fue seleccionado Hugo?

[Hugo](https://gohugo.io/) es un popular generador de sitios estáticos que permite el contenido de {{<product-name>}} documentación de inicio para ser transformada a HTML estático que se puede alojar en Páginas de GitHub

### **Pregunta** ¿Por qué no seleccionó algún otro generador de sitios estáticos?

El equipo central de Power CAT tenía experiencia previa usando Hugo

### **Pregunta** ¿Por qué no se usó Microsoft Forms para preguntas?

Uno de los objetivos del diseño fue integrar el proceso de preguntas directamente en el contenido.

### **Pregunta** ¿Por qué las páginas de GitHub para alojar contenido?

El código fuente del {{<product-name>}} ya existe en GitHub y el soporte nativo de páginas de GitHub fue una opción de dónde alojar el contenido.

### **Pregunta** ¿Por qué este contenido no está activado? [http://learn.microsoft.com]()?

- A medida que el contenido madura a una guía comúnmente reutilizable, puede migrar a [https://learn.microsoft.com]()

- Un objetivo de diseño clave está habilitado por el alojamiento de GitHub

   - Permitir la contribución activa de la comunidad
   
   - Fomentar el proceso de Nutrición del Centro de Excelencia para que la documentación pueda ser reutilizada por la comunidad de clientes y socios

### **Pregunta** ¿Por qué no se aplica el enfoque a otros proyectos de Power CAT?

El {{<product-name>}} está experimentando con este canal de documentación para complementar y vincular a nuestro [Contenido de aprendizaje](https://aka.ms/automation-kit-learn). Basándonos en los comentarios y el resultado de este experimento, evaluaremos si otros proyectos administrados por Power CAT adoptarán un enfoque similar.

### **Pregunta** ¿Cómo puedo ver los problemas de documentación abierta?

Puedes visitar nuestro [Problemas de documentación abierta](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Adocumentation) página

### **Pregunta** ¿Cómo genero una nueva solicitud de característica de documentación?

Crear un nuevo [Solicitud de características](https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement,automation-kit%2Cdocumentation&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE)
