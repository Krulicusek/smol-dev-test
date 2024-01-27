```python
import socket
from bluetooth import *
from bluetooth_device import BluetoothDevice

master_address = None
slave_address = None

def create_socket():
    sock = BluetoothSocket(RFCOMM)
    return sock

def connect_device(device_address):
    sock = create_socket()
    try:
        sock.connect((device_address, 1))
        print("CONNECTION_SUCCESS")
        return sock
    except:
        print("CONNECTION_FAILURE")
        return None

def disconnect_device(sock):
    try:
        sock.close()
        print("DISCONNECTION_SUCCESS")
    except:
        print("DISCONNECTION_FAILURE")

def send_data(sock, data):
    try:
        sock.send(data)
        print("DATA_SENT")
    except:
        print("DATA_NOT_SENT")

def receive_data(sock):
    try:
        data = sock.recv(1024)
        print("DATA_RECEIVED")
        return data
    except:
        print("DATA_NOT_RECEIVED")
        return None

def start_proxy(master_address, slave_address):
    master_sock = connect_device(master_address)
    slave_sock = connect_device(slave_address)
    if master_sock and slave_sock:
        print("PROXY_STARTED")
        while True:
            data = receive_data(master_sock)
            if data:
                send_data(slave_sock, data)
    else:
        print("PROXY_NOT_STARTED")

def stop_proxy(master_sock, slave_sock):
    disconnect_device(master_sock)
    disconnect_device(slave_sock)
    print("PROXY_STOPPED")
```