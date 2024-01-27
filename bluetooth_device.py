```python
import bluetooth
from socket import socket, AF_BLUETOOTH, SOCK_STREAM, BTPROTO_RFCOMM

class BluetoothDevice:
    def __init__(self, address, name):
        self.address = address
        self.name = name
        self.is_connected = False
        self.socket = None

    def create_socket(self):
        self.socket = socket(AF_BLUETOOTH, SOCK_STREAM, BTPROTO_RFCOMM)

    def connect_device(self):
        if not self.socket:
            self.create_socket()
        try:
            self.socket.connect((self.address, 1))
            self.is_connected = True
            print("CONNECTION_SUCCESS")
        except Exception as e:
            print("CONNECTION_FAILURE: ", str(e))

    def disconnect_device(self):
        if self.socket:
            try:
                self.socket.close()
                self.is_connected = False
                print("DISCONNECTION_SUCCESS")
            except Exception as e:
                print("DISCONNECTION_FAILURE: ", str(e))

    def send_data(self, data):
        if self.is_connected:
            try:
                self.socket.send(data)
                print("DATA_SENT")
            except Exception as e:
                print("Failed to send data: ", str(e))

    def receive_data(self):
        if self.is_connected:
            try:
                data = self.socket.recv(1024)
                print("DATA_RECEIVED")
                return data
            except Exception as e:
                print("Failed to receive data: ", str(e))
```