import bluetooth_extender
import proxy
import device_a
import device_b
import controller

def main():
    # Initialize devices
    device_a_obj = device_a.DeviceA()
    device_b_obj = device_b.DeviceB()
    controller_obj = controller.Controller()

    # Initialize proxy
    proxy_obj = proxy.Proxy(device_a_obj, device_b_obj, controller_obj)

    # Initialize Bluetooth extender
    bluetooth_extender_obj = bluetooth_extender.BluetoothExtender(proxy_obj)

    # Start the Bluetooth extender
    bluetooth_extender_obj.start()

if __name__ == "__main__":
    main()