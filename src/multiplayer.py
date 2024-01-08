```python
import socket
import threading
from game import update_game_state

class Multiplayer:
    def __init__(self, host='localhost', port=55555):
        self.server = (host, port)
        self.socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        self.socket.connect(self.server)

    def send_data(self, data):
        self.socket.sendall(data)

    def receive_data(self):
        return self.socket.recv(4096)

    def start_listening(self):
        threading.Thread(target=self.listen_for_updates, daemon=True).start()

    def listen_for_updates(self):
        while True:
            data = self.receive_data()
            update_game_state(data)

    def close_connection(self):
        self.socket.close()
```
