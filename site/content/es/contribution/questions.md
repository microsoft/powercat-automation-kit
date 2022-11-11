---
title: "Preguntas de creación"
description: "Kit de automatización: preguntas sobre la creación"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 37D5A5E89FA4987CACF047AC5907F94874C4EA89
---

Esta página contiene información sobre el formato utilizado para crear preguntas interactivas que se incluyen como parte del {{<product-name>}} iniciador.

{{<toc>}}

## Empezar

Las preguntas utilizadas en las páginas de inicio del kit se basan en: [Biblioteca JS de encuestas de código abierto](https://github.com/surveyjs/survey-library). El uso de esta biblioteca permite utilizar todos los controles listos para usar admitidos.

Para entender el marco se puede mirar

- El [Documentos de JS de la encuesta](https://surveyjs.io/form-library/documentation/overview)

- Tipos de preguntas simples como [Mensaje de texto](https://surveyjs.io/form-library/examples/questiontype-text/reactjs), [Grupos de radio](https://surveyjs.io/form-library/examples/questiontype-radiogroup/reactjs), [Casilla de verificación](https://surveyjs.io/form-library/examples/questiontype-checkbox/reactjs) o [Clasificación](https://surveyjs.io/form-library/examples/questiontype-ranking/reactjs)

- Uso de la visibilidad condicional [visibleSi](https://surveyjs.io/form-library/examples/condition-kids/reactjs)

- Revise algunas de las preguntas existentes que se utilizan en el sitio. Por ejemplo, el [Preguntas de monitoreo](https://github.com/microsoft/powercat-automation-kit/blob/gh-pages/site/content/monitoring.json)

- Revisa cómo incluir el código corto en tu markdown de contenido. Por ejemplo [Monitoreo de rebajas](https://raw.githubusercontent.com/microsoft/powercat-automation-kit/gh-pages/site/content/monitoring-compare.md)

## Incrustar preguntas en su contenido

Para incrustar un conjunto de preguntas en su página, puede agregar lo siguiente a su markdown y cambiar el nombre del archivo de pregunta que desea leer

{{\<questions name="foo.json" completed="Thank you for completing foo" showNavigationButtons=false \>}}

## Custom Functions

El {{<product-name>}} también incluye algunas funciones adicionales que puede utilizar dentro de expresiones.

### Len

La función len devuelve la longitud de una cadena o matriz

#### Ejemplo de LEN

```json
{
    "type": "html",
    "html": "Thanks for selecting a role",
    "visibleIf": "len({roles}) > 0"
}
```

### Contiene

La función contains devuelve true o false si la cadena o matriz de cadenas coincide con el valor proporcionado

#### contiene ejemplo

Hará visible el elemento si uno de los roles seleccionados es maker

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},'maker')"
}
```

Hará visible el elemento si uno de los roles seleccionados es creador o arquitecto

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},['maker', 'architect'])"
}
```

## Widgets personalizados

### Tarea de imagen

El {{<product-name>}} también incluye el **image-task** widget personalizado. Este widget se puede incluir en los elementos de la pregunta utilizando el siguiente fragmento de código json.

```json
{
    "title": "Please select the components of interest",
    "type": "image-task",
    "src": "/powercat-automation-kit/images/illustrations/sample.svg"
}
```

#### Propiedades

- **título** - El texto que se mostrará al usuario
- **tipo** - Debe ser image-task
- **Fuente** - La url del archivo SVG que se va a renderizar

#### Cómo funciona

El archivo svg de origen admite los siguientes vínculos de hipervínculo personalizados para los elementos del archivo svg

- **template://item/selected** - Definirá el formato del objeto para establecer el formato seleccionado en la imagen
- **template://item/unselected** - Definirá el formato del objeto para establecer el formato no seleccionado de los elementos en la imagen
- **question://question-name/value** - Definirá el formato del objeto para establecer el formato no seleccionado de los elementos en la imagen

Los elementos visuales con un hipervínculo de question:// se utilizarán para establecer o desestablecer la matriz de valores dentro del conjunto de preguntas. Esta capacidad proporciona la capacidad de cambiar interactivamente la forma en que se muestran otras preguntas al usuario. Por ejemplo, si el archivo svg tenía dos objetos con los siguientes hipervínculos:

- **question://roles/maker**
- **question://roles/architect**

Si el usuario selecciona estos objetos, se podrían mostrar otros elementos de la página, por ejemplo.

```json
{
    "type": "html",
    "html": "Makers build Automation Projects to solve business problems",
    "visibleIf": "contains({roles}, 'maker')"
}
```

## Preguntas y respuestas

### **Pregunta** ¿Por qué se ha utilizado este enfoque en lugar de Microsoft Forms?

El uso del shortcode de preguntas permite que las preguntas formen parte de cada página de contenido en lugar de un enlace separado.

### **Pregunta** ¿Qué ventajas tiene este enfoque?

Las siguientes ventajas de este enfoque incluyen:

- La capacidad de usar tipos de preguntas listas para usar

- La creación de preguntas se basa en la configuración y solo requiere conocimiento de JSon para crear preguntas

- El marco de preguntas es extensible, lo que permite agregar nuevas funciones o widgets.

- El uso de JSon para las definiciones de preguntas permite que las preguntas se almacenen en el control de código fuente y se revisen y versionen con el tiempo

### **Pregunta** ¿Se podría usar este enfoque dentro de Power App o Power Page?

Absolutamente, se podrían usar las mismas definiciones de JavaScript y preguntas creando un [Componente de código](https://learn.microsoft.com/power-apps/developer/component-framework/custom-controls-overview)

### **Pregunta** ¿Cómo puedo crear las preguntas de tarea de imagen SVG?

Una opción para crear los archivos svg es [Microsoft Visio](https://www.microsoft.com/microsoft-365/visio/) que exportará diagramas a un archivo SVG con los hipervínculos necesarios que sea compatible con **image-task** Preguntas.

### **Pregunta** ¿Puedo usar Microsoft PowerPoint para exportar archivos SVG de preguntas de tareas de imagen?

Aunque Microsoft Power Point puede exportar una diapositiva a una zapata de prueba inicial de archivo SVG, no exporta los hipervínculos necesarios para crear una **image-task** Funciona correctamente.

### **Pregunta** Mis archivos SVG exportados son grandes, ¿puedo hacerlos más pequeños?

Una opción para que los archivos SVG los hagan más pequeños antes de confirmarlos en el control de código fuente. Existen múltiples herramientas que se pueden usar para reducir el tamaño de un SVG, una opción a considerar es [SVGO](https://github.com/svg/svgo) un optimizador SVG basado en NodeJs.
