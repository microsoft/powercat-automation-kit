---
title: Riktlinjer för redigering
description: Riktlinjer för redigering av dokumentation för Automation Kit
sidebar: false
sidebarlogo: fresh-white
include_footer: true

---
I följande avsnitt beskrivs riktlinjer och anteckningar för redigering av startdokumentation.

{{<toc>}}

## Riktlinjer

I följande avsnitt beskrivs tekniska, design- och resultatbaserade riktlinjer för att skapa bidrag

## Mål

När vi bygger vår dokumentation är det viktigt att överväga hur vi gör det möjligt för våra läsare att **Fall i framgångsgropen**.

Brad Abrams definierade [Framgångsgropen 2003](https://web.archive.org/web/20160705182659/https://blogs.msdn.microsoft.com/brada/2003/10/02/the-pit-of-success/) som

> The Pit of Success: i skarp kontrast till ett toppmöte, en topp eller en resa över en öken för att hitta seger genom många prövningar
> och överraskningar, vi vill att våra kunder helt enkelt ska falla i vinnande metoder
> genom att använda vår plattform och våra ramverk. I den mån vi gör det lätt att hamna i trubbel misslyckas vi.

Med tanke på detta mål överväga följande:

- Ge en "no cliffs-upplevelse"

  - Hjälp administratörer och centrala styrningsteam att skapa en självbetjäningsmodell för att använda {{<product-name>}}

  - Tillåt användare att använda utvecklingsmiljöer för att få tag på om en central miljö inte är tillgänglig och de vill ha funktioner före en test- eller produktionsdistribution av {{<product-name>}}

  - Diskutera användningen av utvärderingsmiljöer med enkel installation för att komma igång med {{<product-name>}}

- Ge en kanal för feedback. Ge kunderna möjlighet att ge input på vad vi kan förbättra

### Källkontroll

- Du har slutfört [Dokumentation](/sv/contribution/documentation) steg för att ladda ned och skicka ändringar till GitHub-lagringsplatsen
- Nya ändringar skickas till en ny gren och har en pull-begäran för att granska ändringar
- All dokumentation ska vara antingen markdown, JSon eller statiska tillgångar som kan vara versionskontroller och granskas med hjälp av standardprocessen för pull-begäran

## Riktlinjer för design

### Hemsida

- Ha tydlig titel och undertext som beskriver målet med startupplevelsen
- Ge en uppmaning till handling för att inkludera andra relaterade händelser. Till exempel registrera dig för kontorstid.
- Åtgärden Länka till Komma igång som den primära åtgärden för att hjälpa nya användare att registrera sig
- Sekundär åtgärd för att gå med i kontorstid för att hjälpa till att bygga upp en community av användare
- Inkludera paneler med vanliga åtgärder
- Sammanfattande lista över funktioner som hjälper användarna att hantera hyperautomationsprojekt
- Sidfotsnavigering för vanliga länkar.

Läs [Konfiguration av plats](/sv/contribution/site-configuration) för mer information om hur du konfigurerar startsidan.

### Återanvända

- Använd hugolayouter för att kunna ange nytt tema eller åsidosätta det aktuella temat genom att placera innehåll i mappen site\layouts
- Om du ändrar layouter bör statisk HTML kunna inkluderas på många värdplatser. Till exempel

  - GitHub-sidor
  - Power-sidor
  - Dela punkt
  - Statiska Azure-webbplatser

- Metoden kan användas som mallar av partner eller kunder för att skapa "dokumentationspaket" för att påskynda vårdfasen av {{<product-name>}} dokumentation
- Ge möjlighet för flera användare av dokumentationen (t.ex. kund- och partnercenter för utmärkthetsteam)
- Tillåt att användarinnehåll inkluderas
- Tillåt uppgraderingsprocess som gör att nya ändringar kan hämtas från {{<product-name>}} startdokumentation

## Markdown-sidor

- Du kan använda [Visual Studio Kod](https://code.visualstudio.com/) Så här redigerar du markdown-filerna

- Markdown-filer ska finnas i mappen /site/content

- Varje markdown-fil ska innehålla en gemensam rubrik på varje sida

```toml
title: Sample page
description: Automation Kit sample page
sidebar: false
sidebarlogo: fresh-white
include_footer: true
```

- Markdown-filer bör använda kortkoder för att bädda in JavaScript

## kortkoder

Korta koder ger möjlighet att inkludera dynamiskt innehåll på en markdown-sida. Du kan läsa mer om kortkoder från [Hugo kortkod dokumentation](https://gohugo.io/content-management/shortcodes/)

Detta projekt innehåller också ytterligare kortkoder

### Innehållsförteckning

Lägg till **Innehållsförteckningen** följande kortkod till din markdown för att inkludera en innehållsförteckning med markdown-rubriker på sidan omgiven av \{\{ och \}\}

```html
<toc/>
```

### Fråga

Inkludera en uppsättning frågor på din sida omgiven av \{\{ och \}\}

```html
<questions name="foo.json" completed="Thank you for completing foo" showNavigationButtons=false />
```

Parametrar:

- **Namn** Namnet på JSon-filen som innehåller frågor som ska importeras. Läsa [Frågor](/sv/contribution/questions) för mer information om frågefilformat
- **fullbordad** Texten som ska visas när frågorna är klara
- **showNavigationButtons** sant/falskt värde för att sko Nästa/Tillbaka/Slutförda navigeringsknappar

### Extern bild

Inkludera en storleksbild från en extern källa på sidan omgiven av \{\{ och \}\}

```html
<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon"/>
```

Parametrar:

- **Src** Källsökvägen till bilden som ska importeras
- **storlek** Storleken i pixlar för att ändra storlek på källbilden till
- **SMS** Den alternativa texten som ska inkluderas i bilden

## Anteckningar

### Konfiguration av GitHub-sidor

Följande steg användes för att konfigurera GitHub-sidorna för webbplatsen

1. Skapade en ny överbliven gren i git

    ```bash
    git checkout --orphan gh-pages
    ```

1. Rensa befintligt innehåll (filer och mappar)

    ```bash
    git clean -d -f
    ```

1. Hugo installeras

    - Du kan också installera med chocolatey på Windows
 
    ```bash
    choco install hugo-extended -confirm
    ```

1. Hugo-utdata konfigurerad för att mata ut till mappen /docs

1. Testa dina ändringar

    ```bash
    hugo serve
    ```

1. Om du vill skapa den statiska html-platsen i webbplatsmappen kör du följande kommando

    ```bash  
    hugo
    ```
 
1. Skicka din gh-pages-gren till GitHub

1. Konfigurera GitHub-projekt för att aktivera sidor

    - Se Konfigurera en publiceringskälla för din GitHub Pages-webbplats - GitHub Docs
    - Vald gh-pages-gren och /docs-mapp

### Uppdatera bildmärket för startsidan

Om du vill anpassa startsidesbilden till märket Status: Offentlig förhandsversion gör jag följande:

1. Klona svg-badges repo

    ```bash
    git clone https://github.com/anouarhassine/svg-badges.git
    cd svg-badges   
    ```

1. Installera moduler

    ```bash
    npm install
    ```

1. Starta webbservern för att generera märken

    ```bash
    npm run start
    ```

1. Skapa märke

    ```link
    http://localhost:9000/static/Status-Public%20Preview-Green
    ```

1. Ladda ner svg-märket

1. Använd inkscape för att redigera befintlig svg och spara resultat

1. Ladda upp ny bild till mappen statisk\bilder\illustrationer

1. Ändra config.yaml hero-avbildningen

    ```yml
    params:
        hero:
            image: illustrations/worker-public-preview.svg 
    ```

## Fråga och svar

### **Fråga** Varför valdes Hugo?

[Hugo](https://gohugo.io/) är en populär statisk webbplatsgenerator som tillåter innehåll i {{<product-name>}} startdokumentation som ska omvandlas till statisk HTML som kan finnas på GitHub-sidor

### **Fråga** Varför valde du inte någon annan statisk webbplatsgenerator?

Power CAT-teamet hade tidigare erfarenhet av att använda Hugo

### **Fråga** Varför användes inte Microsoft Forms för frågor?

Ett designsyfte var att integrera frågeprocessen direkt i innehållet.

### **Fråga** Varför GitHub-sidor för att vara värd för innehåll?

Källkoden för {{<product-name>}} finns redan på GitHub och det inbyggda stödet för GitHub-sidor var ett val av var innehållet skulle finnas.

### **Fråga** Varför är det här innehållet inte på [http://learn.microsoft.com]()?

- När innehållet mognar till allmänt återanvändbar vägledning kan det migrera till [https://learn.microsoft.com]()

- Ett viktigt designmål aktiveras av GitHub hosting

   - Tillåt aktiva bidrag från communityn
   
   - Främja Nuture-processen med Center of Excellence så att dokumentation kan återanvändas av kunder och partnercommunity

### **Fråga** Varför tillämpas inte metoden på andra Power CAT-projekt?

Den {{<product-name>}} experimenterar med denna dokumentationskanal för att komplettera och länka till vår befintliga [Innehåll](https://aka.ms/automation-kit-learn). Baserat på feedback och resultat av detta experiment kommer vi att utvärdera om andra Power CAT-hanterade projekt kommer att anta ett liknande tillvägagångssätt.

### **Fråga** Hur ser jag problem med öppen dokumentation?

Du kan besöka vår [Öppna dokumentationsproblem](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Adocumentation) sida

### **Fråga** Hur skapar jag en ny begäran om dokumentationsfunktioner?

Skapa en ny [Begäran om funktioner](https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement,automation-kit%2Cdocumentation&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE)
