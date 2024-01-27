```python
import socket
from bluetooth_device import BluetoothDevice

class BluetoothProxy:
    def __init__(self, master_address, slave_address):
        self.master_device = BluetoothDevice(master_address)
        self.slave_device = BluetoothDevice(slave_address)
        self.proxy_socket = None

    def start_proxy(self):
        self.proxy_socket = self.create_socket()
        self.connect_device(self.master_device)
        self.connect_device(self.slave_device)
        print("PROXY_STARTED")

    def stop_proxy(self):
        self.disconnect_device(self.master_device)
        self.disconnect_device(self.slave_device)
        self.proxy_socket.close()
        print("PROXY_STOPPED")

    def create_socket(self):
        s = socket.socket(socket.AF_BLUETOOTH, socket.SOCK_STREAM, socket.BTPROTO_RFCOMM)
        return s

    def connect_device(self, device):
        try:
            self.proxy_socket.connect((device.address, 1))
            device.is_connected = True
            print("CONNECTION_SUCCESS")
        except Exception as e:
            print("CONNECTION_FAILURE", str(e))

    def disconnect_device(self, device):
        try:
            self.proxy_socket.close()
            device.is_connected = False
            print("DISCONNECTION_SUCCESS")
        except Exception as e:
            print("DISCONNECTION_FAILURE", str(e))

    def send_data(self, data):
        try:
            self.proxy_socket.send(data)
            print("DATA_SENT")
        except Exception as e:
            print("DATA_SENT_FAILURE", str(e))

    def receive_data(self):
        try:
            data = self.proxy_socket.recv(1024)
            print("DATA_RECEIVED")
            return data
        except Exception as e:
            print("DATA_RECEIVED_FAILURE", str(e))
```