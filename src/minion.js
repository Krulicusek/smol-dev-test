import React from 'react';

class Minion extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      id: props.id,
      strength: props.strength,
      speed: props.speed,
      health: props.health,
    };
  }

  render() {
    return (
      <div id={`minion-${this.state.id}`} className="minion-container">
        <img src="../public/assets/images/minion.png" alt="Minion" />
        <div className="minion-stats">
          <p>Strength: {this.state.strength}</p>
          <p>Speed: {this.state.speed}</p>
          <p>Health: {this.state.health}</p>
        </div>
      </div>
    );
  }
}

export default Minion;