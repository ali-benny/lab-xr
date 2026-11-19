using UnityEngine;
using UnityEngine.UI;

public class LightController : MonoBehaviour
{
    [SerializeField] private Light targetLight;
    [SerializeField] private Slider slider;

    [SerializeField] private Slider sliderMeta;
    [SerializeField] private Toggle switchMeta;

    private const float defaultIntensity = 1.0f;

    public void ToggleLight()
    {
        if (targetLight != null)
        {
            targetLight.enabled = !targetLight.enabled;
            if (switchMeta != null)
                switchMeta.isOn = !targetLight.enabled;
        }
    }
    public void SetLightState(bool state)
    {
        if (targetLight != null) 
            targetLight.enabled = state;
    }

    public void SetIntensity(float value)
    {
        if (targetLight != null)
            targetLight.intensity = value;
    }

    public void Reset()
    {
        if (targetLight != null)
            targetLight.enabled = true;

        if (switchMeta != null)
            switchMeta.isOn = true;

        SetIntensity(defaultIntensity);

        if (slider != null)
            slider.value = defaultIntensity;

        if (sliderMeta != null)
            sliderMeta.value = defaultIntensity;
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (slider != null)
            slider.onValueChanged.AddListener(SetIntensity);

        if (sliderMeta != null)
            sliderMeta.onValueChanged.AddListener(SetIntensity);

        if (switchMeta != null)
            switchMeta.onValueChanged.AddListener(SetLightState);

        // Imposta lo stato iniziale coerente
        Reset();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
