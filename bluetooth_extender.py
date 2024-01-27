import bluetooth
from proxy import Proxy
from device_a import DeviceA
from device_b import DeviceB
from controller import Controller

class BluetoothExtender:
    def __init__(self):
        self.device_a = DeviceA()
        self.device_b = DeviceB()
        self.controller = Controller()
        self.proxy = Proxy(self.device_a, self.device_b, self.controller)

    def establish_connections(self):
        self.device_a.connect(self.proxy)
        self.device_b.connect(self.proxy)
        self.controller.connect(self.proxy)

    def manage_connections(self):
        while True:
            self.proxy.forward_messages()

if __name__ == "__main__":
    extender = BluetoothExtender()
    extender.establish_connections()
    extender.manage_connections()