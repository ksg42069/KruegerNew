using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandPresence : MonoBehaviour
{
    public InputDeviceCharacteristics controllerCharacteristics;
    public List<GameObject> controllerprefabs;
    InputDevice targetdevice;
    GameObject spawnerController;

    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();

        //InputDeviceCharacteristics rightCharacteristics = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
        //InputDevices.GetDevicesWithCharacteristics(rightCharacteristics, devices);

        //InputDeviceCharacteristics leftCharacteristics = InputDeviceCharacteristics.Left | InputDeviceCharacteristics.Controller;
        //InputDevices.GetDevicesWithCharacteristics(leftCharacteristics, devices);

        InputDevices.GetDevicesWithCharacteristics(controllerCharacteristics, devices);

        foreach(var item in devices)
        {
            Debug.Log(item.name + item.characteristics);
        }
        
        if (devices.Count > 0)
        {
            targetdevice = devices[0];
            GameObject prefab = controllerprefabs.Find(controller => controller.name == targetdevice.name);
            if (prefab)
                spawnerController = Instantiate(prefab, transform);
            else
                spawnerController = Instantiate(controllerprefabs[0], transform);
        }

    }

    // Update is called once per frame
    void Update()
    {
        targetdevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primarybuttonValue);
        if (primarybuttonValue)
            Debug.Log("Pressing primary button");

        targetdevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue);
        if (triggerValue > 0.01f)
            Debug.Log("Button Value" + triggerValue);

        targetdevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 AxisValue);
        if (AxisValue != Vector2.zero)
            Debug.Log("TouchPad" + AxisValue);
    }
}
