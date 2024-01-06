let snake = {
    body: [],
    direction: 'right',
    color: 'green',
    gradient: 'linear-gradient(green, darkgreen)'
};

function moveSnake() {
    let head = Object.assign({}, this.body[0]); // copy head

    switch(this.direction) {
        case 'right':
            head.x += 1;
            break;
        case 'down':
            head.y += 1;
            break;
        case 'left':
            head.x -= 1;
            break;
        case 'up':
            head.y -= 1;
            break;
    }

    this.body.unshift(head); // add new head to snake
}

function addSegment() {
    let tail = Object.assign({}, this.body[this.body.length - 1]); // copy tail
    this.body.push(tail); // add new tail to snake
}

snake.move = moveSnake;
snake.addSegment = addSegment;

export default snake;