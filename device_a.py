```python
import bluetooth
from bluetooth_extender import establish_connection, manage_connection

class DeviceA:
    def __init__(self, device_id, proxy_id):
        self.device_id = device_id
        self.proxy_id = proxy_id
        self.sock = None

    def connect_to_proxy(self):
        self.sock = establish_connection(self.proxy_id)

    def send_data(self, data):
        manage_connection(self.sock, data)

    def receive_data(self):
        return self.sock.recv(1024)

if __name__ == "__main__":
    device_a = DeviceA('device_a_id', 'proxy_id')
    device_a.connect_to_proxy()
```