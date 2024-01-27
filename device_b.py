```python
import bluetooth
from bluetooth_extender import establish_connection, manage_connection

DEVICE_A_ADDRESS = "00:00:00:00:00:00"  # Replace with actual address
PROXY_ADDRESS = "00:00:00:00:00:00"  # Replace with actual address

def device_b_main():
    # Establish connection with Device A and Proxy
    sock_device_a = establish_connection(DEVICE_A_ADDRESS)
    sock_proxy = establish_connection(PROXY_ADDRESS)

    try:
        while True:
            # Receive data from Device A
            data_from_device_a = sock_device_a.recv(1024)
            # Send data to Proxy
            sock_proxy.send(data_from_device_a)

            # Receive data from Proxy
            data_from_proxy = sock_proxy.recv(1024)
            # Send data to Device A
            sock_device_a.send(data_from_proxy)
    except bluetooth.btcommon.BluetoothError as error:
        print(f"An error occurred: {error}")
    finally:
        manage_connection(sock_device_a, close=True)
        manage_connection(sock_proxy, close=True)

if __name__ == "__main__":
    device_b_main()
```