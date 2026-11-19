using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderValueProva : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TMP_Text label;
    [SerializeField] private float hideDelay = 0.2f;

    private Coroutine hideRoutine;

    private void Awake()
    {
        label.gameObject.SetActive(false);
        slider.onValueChanged.AddListener(OnSliderChanged);
    }

    private void OnDestroy()
    {
        if (slider != null)
            slider.onValueChanged.RemoveListener(OnSliderChanged);
    }

    public void OnSliderChanged(float value)
    {
        label.text = $"{Mathf.RoundToInt(value * 100f)}%";
        label.gameObject.SetActive(true);

        if (hideRoutine != null)
            StopCoroutine(hideRoutine);

        hideRoutine = StartCoroutine(HideAfterDelay());
    }

    private IEnumerator HideAfterDelay()
    {
        yield return new WaitForSecondsRealtime(hideDelay);
        label.gameObject.SetActive(false);
        hideRoutine = null;
    }
}
