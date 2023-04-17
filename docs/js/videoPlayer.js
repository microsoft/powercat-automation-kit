function setupPlayer(id) {
    let divElement = document.getElementById(id);
    let subtitles = divElement.querySelector('#subtitles');
    let videoContainer = divElement.querySelector('#videoContainer');
    let video = divElement.querySelector('video');
    let subtitlesMenu
    for (let i = 0; i < video.textTracks.length; i++) {
        video.textTracks[i].mode = "hidden";
    }
    let subtitleMenuButtons = [];
    createMenuItem = (id, lang, label) => {
        const listItem = document.createElement("li");
        const button = listItem.appendChild(document.createElement("button"));
        button.setAttribute("id", id);
        button.className = "subtitles-button";
        if (lang.length > 0) button.setAttribute("lang", lang);
        button.value = label;
        button.setAttribute("data-state", "inactive");
        button.appendChild(document.createTextNode(label));
        button.addEventListener("click", (e) => {
            // Set all buttons to inactive
            subtitleMenuButtons.forEach((button) => {
            button.setAttribute("data-state", "inactive");
            });

            // Find the language to activate
            const lang = button.getAttribute("lang");
            for (let i = 0; i < video.textTracks.length; i++) {
            // For the 'subtitles-off' button, the first condition will never match so all will subtitles be turned off
            if (video.textTracks[i].language === lang) {
                video.textTracks[i].mode = "showing";
                button.setAttribute("data-state", "active");
            } else {
                video.textTracks[i].mode = "hidden";
            }
            }
            subtitlesMenu.style.display = "none";
        });
        subtitleMenuButtons.push(button);
        return listItem;
    }

    if (video.textTracks) {
        let df = document.createDocumentFragment();
        subtitlesMenu = df.appendChild(document.createElement("ul"));
        subtitlesMenu.className = "subtitles-menu";
        subtitlesMenu.appendChild(createMenuItem("subtitles-off", "", "Off"));
        for (let i = 0; i < video.textTracks.length; i++) {
            subtitlesMenu.appendChild(
            createMenuItem(
                `subtitles-${video.textTracks[i].language}`,
                video.textTracks[i].language,
                video.textTracks[i].label
            )
            );
        }
        videoContainer.appendChild(subtitlesMenu);
    }
    subtitleMenuButtons = [];
    
    subtitles.addEventListener("click", (e) => {
    if (subtitlesMenu) {
        subtitlesMenu.style.display = subtitlesMenu.style.display === "block" ? "none" : "block";
    }
    });
}