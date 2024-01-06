import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';

import Game from './game.js';
import Tower from './tower.js';
import Shop from './shop.js';
import Minion from './minion.js';
import Upgrade from './upgrade.js';

import './styles.css';

ReactDOM.render(
  <React.StrictMode>
    <Router>
      <Switch>
        <Route path="/" exact component={Game} />
        <Route path="/tower" component={Tower} />
        <Route path="/shop" component={Shop} />
        <Route path="/minion" component={Minion} />
        <Route path="/upgrade" component={Upgrade} />
      </Switch>
    </Router>
  </React.StrictMode>,
  document.getElementById('root')
);