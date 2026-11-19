using UnityEngine;
using TMPro;

public class SliderToText : MonoBehaviour
{
    private TextMeshProUGUI textComponent;

    private void Awake()
    {
        textComponent = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateSliderText(float value)
    {
        if (textComponent != null)
        {   
            textComponent.enabled = true;
            textComponent.text = Mathf.RoundToInt(value/4*100).ToString()+"%";
        }
    }
}

