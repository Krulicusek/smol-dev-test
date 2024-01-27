import bluetooth
from bluetooth_extender import establish_connection, manage_connection

class Controller:
    def __init__(self, device_id):
        self.device_id = device_id
        self.sock = None

    def connect_to_proxy(self, proxy_id):
        self.sock = establish_connection(proxy_id)
        if self.sock is not None:
            print(f"Controller {self.device_id} connected to proxy {proxy_id}")
        else:
            print(f"Controller {self.device_id} failed to connect to proxy {proxy_id}")

    def send_data(self, data):
        if self.sock is not None:
            manage_connection(self.sock, data)
        else:
            print("No connection established. Cannot send data.")

    def disconnect(self):
        if self.sock is not None:
            self.sock.close()
            print(f"Controller {self.device_id} disconnected from proxy")
        else:
            print("No connection established. Cannot disconnect.")

if __name__ == "__main__":
    controller = Controller("Controller_1")
    controller.connect_to_proxy("Proxy_1")
    controller.send_data("Hello, World!")
    controller.disconnect()