import React from 'react';

class Upgrade extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      upgrades: [
        { id: 1, type: 'Attack speed', value: 50 },
        { id: 2, type: 'Armor & Magic resist', value: 35 },
      ],
    };
  }

  handleUpgradeClick = (upgradeId) => {
    this.props.onUpgradeClick(upgradeId);
  }

  render() {
    return (
      <div id="upgrade-container">
        {this.state.upgrades.map((upgrade) => (
          <div key={upgrade.id} onClick={() => this.handleUpgradeClick(upgrade.id)}>
            <p>{upgrade.type}: {upgrade.value}%</p>
          </div>
        ))}
      </div>
    );
  }
}

export default Upgrade;