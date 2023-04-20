export function createAudioContext() {
    return new (window.AudioContext || window.webkitAudioContext)();
}

export function closeAudioContext(audioContext) {
    return audioContext.close();
}

export function getProperty(obj, propName) {
    return obj[propName];
}

export function createMediaElementSource(audioContext, mediaElement) {
    return audioContext.createMediaElementSource(mediaElement);
}