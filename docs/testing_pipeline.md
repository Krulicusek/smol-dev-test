# Testing Pipeline

Our game uses an automated testing pipeline to ensure the stability and correctness of the game. The pipeline includes unit tests, integration tests, and end-to-end tests.

## Running the Tests

To run the tests, use the `run_tests()` function in the `main.py` file. This function will execute all the tests in the `tests` directory.

```python
# main.py
run_tests()
```

## Unit Tests

Unit tests are located in the `tests/unit_tests.py` file. These tests focus on individual components of the game, such as the map layout, base building, unit waves, resource management, tower placement, champion control, fog of war, augment system, and web scraping.

```python
# tests/unit_tests.py
def test_map_layout():
    # Test code here

def test_base_building():
    # Test code here

# More tests...
```

## Integration Tests

Integration tests are located in the `tests/integration_tests.py` file. These tests focus on the interaction between multiple components of the game.

```python
# tests/integration_tests.py
def test_map_and_base_interaction():
    # Test code here

def test_tower_and_unit_interaction():
    # Test code here

# More tests...
```

## End-to-End Tests

End-to-end tests are located in the `tests/end_to_end_tests.py` file. These tests focus on the game as a whole, ensuring that all components work together correctly.

```python
# tests/end_to_end_tests.py
def test_game_start_to_finish():
    # Test code here

# More tests...
```

## Test Results

After running the tests, the results will be displayed in the console. If a test fails, the console will display which test failed and why. This information can be used to locate and fix any issues in the game.