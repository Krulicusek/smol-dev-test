```python
import bluetooth
from bluetooth_extender import establish_connection, manage_connection

class Proxy:
    def __init__(self, device_a_id, device_b_id):
        self.device_a_id = device_a_id
        self.device_b_id = device_b_id
        self.device_a_socket = None
        self.device_b_socket = None

    def start_proxy(self):
        self.device_a_socket = establish_connection(self.device_a_id)
        self.device_b_socket = establish_connection(self.device_b_id)

        while True:
            data_from_a = manage_connection(self.device_a_socket)
            data_from_b = manage_connection(self.device_b_socket)

            if data_from_a:
                self.device_b_socket.send(data_from_a)
            if data_from_b:
                self.device_a_socket.send(data_from_b)

    def stop_proxy(self):
        self.device_a_socket.close()
        self.device_b_socket.close()
        self.device_a_socket = None
        self.device_b_socket = None
```