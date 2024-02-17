1. Shared Variables:
   - "baseHP" (Base's health points, equal to its width)
   - "basePosition" (Position of the base in the grid)
   - "projectileSpeed" (Speed of the projectiles)
   - "wallFormula" (Mathematical formula defined by the player to create a wall)
   - "gridSize" (Size of the grid)
   - "axisX" and "axisY" (X and Y axes)

2. Data Schemas:
   - "BaseSchema" (Schema for the base, including its position and HP)
   - "ProjectileSchema" (Schema for the projectiles, including their speed and direction)
   - "WallSchema" (Schema for the walls, including the mathematical formula used to create them)

3. ID Names of DOM Elements:
   - "baseElement" (DOM element for the base)
   - "projectileElement" (DOM element for the projectiles)
   - "wallElement" (DOM element for the walls)
   - "gridElement" (DOM element for the grid)
   - "axisElement" (DOM element for the axes)

4. Message Names:
   - "BaseHit" (Message sent when a projectile hits the base)
   - "WallCreated" (Message sent when a wall is created)
   - "GameOver" (Message sent when the game is over)
   - "GameStart" (Message sent when the game starts)

5. Function Names:
   - "CreateWall" (Function to create a wall using a mathematical formula)
   - "LaunchProjectile" (Function to launch a projectile)
   - "CalculateDamage" (Function to calculate the damage to the base when hit by a projectile)
   - "ParseFormula" (Function to parse the mathematical formula entered by the player)
   - "UpdateGrid" (Function to update the grid and axes)