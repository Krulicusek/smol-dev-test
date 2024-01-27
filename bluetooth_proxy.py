import socket
from bluetooth import *

class BluetoothProxy:
    def __init__(self, master_address, slave_address):
        self.master_address = master_address
        self.slave_address = slave_address
        self.master_socket = None
        self.slave_socket = None

    def create_socket(self):
        self.master_socket = BluetoothSocket(RFCOMM)
        self.slave_socket = BluetoothSocket(RFCOMM)

    def connect_device(self, device_socket, device_address):
        try:
            device_socket.connect((device_address, 1))
            print('CONNECTION_SUCCESS')
            return True
        except Exception as e:
            print('CONNECTION_FAILURE')
            return False

    def disconnect_device(self, device_socket):
        try:
            device_socket.close()
            print('DISCONNECTION_SUCCESS')
            return True
        except Exception as e:
            print('DISCONNECTION_FAILURE')
            return False

    def send_data(self, device_socket, data):
        try:
            device_socket.send(data)
            print('DATA_SENT')
            return True
        except Exception as e:
            print('DATA_FAILURE')
            return False

    def receive_data(self, device_socket):
        try:
            data = device_socket.recv(1024)
            print('DATA_RECEIVED')
            return data
        except Exception as e:
            print('DATA_FAILURE')
            return None

    def start_proxy(self):
        self.create_socket()
        if self.connect_device(self.master_socket, self.master_address) and self.connect_device(self.slave_socket, self.slave_address):
            print('PROXY_STARTED')
            while True:
                data = self.receive_data(self.master_socket)
                if data:
                    self.send_data(self.slave_socket, data)
        else:
            print('PROXY_FAILURE')

    def stop_proxy(self):
        if self.disconnect_device(self.master_socket) and self.disconnect_device(self.slave_socket):
            print('PROXY_STOPPED')
        else:
            print('PROXY_FAILURE')