using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ChargingPowerCell : MonoBehaviour
{
    [SerializeField] private GameObject PowerCell;
    [SerializeField] private GameObject BatterySlotVisual;
    [SerializeField] private Material chargeColor;
    [SerializeField] private Material unchargeColor;


    public void ChargeColor()
    {
        ChangeColor(chargeColor);
    }

    public void UnchargeColor()
    {
        ChangeColor(unchargeColor);
    }

    private void ChangeColor(Material newMaterial)
    {
        MeshRenderer powercellRend = PowerCell.GetComponent<MeshRenderer>();
        MeshRenderer batterySlotRend = BatterySlotVisual.GetComponent<MeshRenderer>();

        if (powercellRend != null && batterySlotRend != null)
        {
            powercellRend.material = newMaterial;
            batterySlotRend.material = newMaterial;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
