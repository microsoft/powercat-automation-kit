---
title: "Authoring guidelines"
description: "Automation Kit - Documentation Authoring Guidelines"
sidebar: false
sidebarlogo: fresh-white
include_footer: true

generated: E4B23EEC2B540A4AF01501764C42DFF50F0CBC8C
---

The following sections outline guidelines and notes for authoring starter documentation.

{{<toc>}}

## Guidelines

The following sections outline technical, design and outcome based guidelines for authoring contributions

## Goals

As we build our documentation is it important to consider how we enable our readers to **Fall into the pit of success**.

Brad Abrams defined [The Pit of Success in 2003](https://web.archive.org/web/20160705182659/https://blogs.msdn.microsoft.com/brada/2003/10/02/the-pit-of-success/) as

> The Pit of Success: in stark contrast to a summit, a peak, or a journey across a desert to find victory through many trials
> and surprises, we want our customers to simply fall into winning practices
> by using our platform and frameworks. To the extent that we make it easy to get into trouble we fail.

Given this goal consider the following:

- Provide a "no cliffs experience"

  - Help Administrators and Central governance teams create a self-service model of using {{<product-name>}}

  - Allow users to make use of Development environments to get hands on if a central environment is not available and they want to features before a test or production deployment of the {{<product-name>}}

  - Discuss usage of Trial environments with easy setup to get hands on with the  {{<product-name>}}

- Provide a channel for feedback. Give options for customers to provide input on what we can improve

### Source Control

- You have completed [Documentation](/en-gb/contribution/documentation) steps to download and push changes to the GitHub repository
- New changes are pushed to a new branch and have a Pull Request to review changes
- All documentation should be either markdown, JSon or static assets that can be version controls and reviewed using standard pull request process

## Design Guidelines

### Home Page

- Have clear title and subtitle that outlines the objective of the starter experience
- Provide a call to action to include other related events. For example register for Office hours.
- Link to Getting Started action as the primary action to help new users onboard
- Secondary action to join office hours to help build community of users
- Include tiles of common actions
- Summary list of features that assist the users manage hyperautomation projects
- Footer navigation for common links.

Read the [Site Configuration](/en-gb/contribution/site-configuration) for more information on configuring the home page.

### Reuse

- Use hugo layouts to be able to specify new theme or override the current theme by placing content in site\layouts folder
- Changing layouts should allow static HTML to be included in many hosting locations. For example

  - GitHub Pages
  - Power Pages
  - Share Point
  - Azure Static Websites

- The the approach can be used as a templates by Partners or Customers to build "Documentation Packs" to accelerate nuture phase of {{<product-name>}} documentation
- Provide the ability for multiple users of the documentation (e.g. Customer and Partner Center of Excellence teams)
- Allow user provided content to be included
- Allow upgrade process that allows new changes to be pulled from {{<product-name>}} starter documentation

## Markdown Pages

- You can use [Visual Studio Code](https://code.visualstudio.com/) to edit the markdown files

- Markdown files should be located in the /site/content folder

- Each markdown file should include common header on each page

```toml
title: Sample page
description: Automation Kit sample page
sidebar: false
sidebarlogo: fresh-white
include_footer: true
```

- Markdown files should use shortcodes to embed any JavaScript

## shortcodes

Short codes provide the ability to include dynamic content in a markdown page. You can read more about shortcodes from the [Hugo shortcode documentation](https://gohugo.io/content-management/shortcodes/)

This project also includes additional shortcodes

### Table of Contents

Add the **toc** following shortcode to your markdown to include a table of content of markdown headers in the page surrounded by \{\{ and \}\}

```html
<toc/>
```

### Question

Include a set of questions in your page surrounded by \{\{ and \}\}

```html
<questions name="/content/en-us/foo.json" completed="Thank you for completing foo" showNavigationButtons=false />
```

Parameters:

- **name** The name of the JSon file that includes questions to import. Read [Questions](/en-gb/contribution/questions) for more information on question file format
- **completed** The text to display when the questions are completed
- **showNavigationButtons** true/false value to shoe Next/Back/Completed navigation buttons

### External Image

Include a size image from an external source in your page surrounded by \{\{ and \}\}

```html
<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon"/>
```

Parameters:

- **src** The source path to the image to import
- **size** The size in pixels to resize the source image to
- **text** The alternate text to include with the image

## Notes

### GitHub Pages Setup

The following steps where used to setup the GitHub pages for the site

1. Created new orphaned branch in git

    ```bash
    git checkout --orphan gh-pages
    ```

1. Clear the existing content (files and folders)

    ```bash
    git clean -d -f
    ```

1. Hugo is installed

    - You can also install with chocolatey on windows
 
    ```bash
    choco install hugo-extended -confirm
    ```

1. Hugo output configured to output to /docs folder

1. Test your changes

    ```bash
    hugo serve
    ```

1. To build thee static html site inside the site folder run the following command

    ```bash  
    hugo
    ```
 
1. Push your gh-pages branch to GitHub

1. Setup GitHub project to enable Pages

    - See Configuring a publishing source for your GitHub Pages site - GitHub Docs
    - Selected gh-pages branch and /docs folder

### Update Home Page Image Badge

To customize the home page image to a Status: Public preview badge I do the following:

1. Clone the svg-badges repo

    ```bash
    git clone https://github.com/anouarhassine/svg-badges.git
    cd svg-badges   
    ```

1. Install modules

    ```bash
    npm install
    ```

1. Start the web server to generate badges

    ```bash
    npm run start
    ```

1. Generate badge

    ```link
    http://localhost:9000/static/Status-Public%20Preview-Green
    ```

1. Download the svg badge

1. Use inkscape to edit existing svg and save results

1. Upload new image to static\images\illustrations folder

1. Change the config.yaml hero image

    ```yml
    params:
        hero:
            image: illustrations/worker-public-preview.svg 
    ```

## Question and Answer

### **Question** Why was Hugo selected?

[Hugo](https://gohugo.io/) is a popular static site generator that allows content of the {{<product-name>}} starter documentation to be transformed to static HTML that can be hosted in GitHub Pages

### **Question** Why did you not select some other static site generator?

The core Power CAT team had previous experience using Hugo

### **Question** Why was Microsoft Forms not used for questions?

One design aim was to integrate the question process directly into the content.

### **Question** Why GitHub pages to host content?

The source code for the {{<product-name>}} already exists on GitHub and the native GitHub pages support was one choice of where to host the content.

### **Question** Why is this content not on [http://learn.microsoft.com]()?

- As content matures to commonly reusable guidance it may migrate to [https://learn.microsoft.com]()

- A key design goal are enabled by GitHub hosting

   - Allow active community contribution
   
   - Foster Nuture process of Center of Excellence so that documentation can be reused by Customers and Partner community

### **Question** Why is approach not applied to other Power CAT projects?

The {{<product-name>}} is experimenting with this channel of documentation to compliment and link to our existing [Learning content](https://aka.ms/automation-kit-learn). Based on the feedback and outcome of this experiment we will evaluate if other Power CAT managed projects will adopt a similar approach.

### **Question** How do I see open documentation issues?

You can visit our [Open Documentation Issues](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Adocumentation) page

### **Question** How do I raise a new documentation feature request?

Create an new [Feature Request](https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement,automation-kit%2Cdocumentation&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE)
