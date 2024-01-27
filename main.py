```python
from bluetooth_extender import BluetoothExtender
from bluetooth_proxy import BluetoothProxy
from bluetooth_device import BluetoothDevice

def main():
    master_address = input("Enter the master device's Bluetooth address: ")
    slave_address = input("Enter the slave device's Bluetooth address: ")

    master_device = BluetoothDevice(master_address)
    slave_device = BluetoothDevice(slave_address)

    proxy = BluetoothProxy(master_device, slave_device)
    extender = BluetoothExtender(proxy)

    try:
        extender.start()
        print("Bluetooth extender started successfully.")
    except Exception as e:
        print(f"Failed to start Bluetooth extender: {e}")
        return

    input("Press any key to stop the Bluetooth extender...")

    try:
        extender.stop()
        print("Bluetooth extender stopped successfully.")
    except Exception as e:
        print(f"Failed to stop Bluetooth extender: {e}")

if __name__ == "__main__":
    main()
```