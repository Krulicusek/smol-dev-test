// site.js

document.addEventListener('DOMContentLoaded', (event) => {
    window.Blazor.start().then(() => {
        window.GameService = {
            startGame: () => DotNet.invokeMethodAsync('SnakeGame', 'StartGame'),
            pauseGame: () => DotNet.invokeMethodAsync('SnakeGame', 'PauseGame'),
            endGame: () => DotNet.invokeMethodAsync('SnakeGame', 'EndGame'),
            move: (direction) => DotNet.invokeMethodAsync('SnakeGame', 'Move', direction),
            eat: () => DotNet.invokeMethodAsync('SnakeGame', 'Eat'),
            die: () => DotNet.invokeMethodAsync('SnakeGame', 'Die')
        };
    });
});