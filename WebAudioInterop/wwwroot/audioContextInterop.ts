export function createAudioContext(): AudioContext {
    return new (window.AudioContext || (window as any).webkitAudioContext)();
}

export function getBaseLatency(audioContext: AudioContext): number {
    return audioContext.baseLatency;
}

export function getOutputLatency(audioContext: AudioContext): number {
    return audioContext.outputLatency;
}

export function closeAudioContext(audioContext: AudioContext): Promise<void> {
    return audioContext.close();
}

export function createOscillator(audioContext: AudioContext): OscillatorNode {
    return audioContext.createOscillator();
}

export function createMediaElementSource(audioContext: AudioContext, mediaElement: HTMLMediaElement): MediaElementAudioSourceNode {
    return audioContext.createMediaElementSource(mediaElement);
}


// namespace WebAudioInterop {
//
//     class AudioContextFunctions {
//         public createAudioContext(): AudioContext {
//             return new (window.AudioContext || (window as any).webkitAudioContext)();
//         }
//
//         public getBaseLatency(audioContext: AudioContext): number {
//             return audioContext.baseLatency;
//         }
//
//         public closeAudioContext(audioContext: AudioContext): Promise<void> {
//             return audioContext.close();
//         }
//
//         public createOscillator(audioContext: AudioContext): OscillatorNode {
//             return audioContext.createOscillator();
//         }
//
//         public createMediaElementSource(audioContext: AudioContext, mediaElement: HTMLMediaElement): MediaElementAudioSourceNode {
//             return audioContext.createMediaElementSource(mediaElement);
//         }
//     }
//
//     export function Load(): void {
//         (window as any)['audioContextFunctions'] = new AudioContextFunctions();
//     }
// }
//
// WebAudioInterop.Load();
