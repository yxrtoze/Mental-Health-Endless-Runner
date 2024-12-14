using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PositivityMeterManager : MonoBehaviour
{
    public Slider positivitySlider; // Attach the progress bar here
    public float positivityChangeAmount = 0.1f; // Fixed amount to change positivity
    public float changeSpeed = 0.5f; // Smoothness of the bar update

    private float targetValue; // The target slider value to move toward
    private bool isChanging; // Flag to track if the slider is actively changing

    void Start()
    {
        targetValue = positivitySlider.value; // Initialize target value to the current slider value
    }

    void Update()
    {
        if (isChanging)
        {
            // Move the slider toward the target value
            positivitySlider.value = Mathf.MoveTowards(positivitySlider.value, targetValue, changeSpeed * Time.deltaTime);

            // Stop changing when the slider reaches the target
            if (Mathf.Approximately(positivitySlider.value, targetValue))
            {
                isChanging = false;
            }
        }

        // Check if the positivity meter is full
        if (positivitySlider.value >= positivitySlider.maxValue)
        {
            positivitySlider.value = positivitySlider.maxValue;
            Debug.Log("Positivity Meter Full! Switching to PositiveScene...");
            SceneManager.LoadScene("PositiveScene");
        }

        // Check if the positivity meter is empty
        if (positivitySlider.value <= positivitySlider.minValue)
        {
            positivitySlider.value = positivitySlider.minValue;
            Debug.Log("Positivity Meter Empty! Switching to NegativeScene...");
            SceneManager.LoadScene("NegativeScene");
        }
    }

    // Increase positivity once per collision
    public void IncreasePositivity()
    {
        if (!isChanging && targetValue < positivitySlider.maxValue)
        {
            targetValue += positivityChangeAmount;
            targetValue = Mathf.Clamp(targetValue, positivitySlider.minValue, positivitySlider.maxValue);
            isChanging = true; // Start updating the slider
        }
    }

    // Decrease positivity once per collision
    public void DecreasePositivity()
    {
        if (!isChanging && targetValue > positivitySlider.minValue)
        {
            targetValue -= positivityChangeAmount;
            targetValue = Mathf.Clamp(targetValue, positivitySlider.minValue, positivitySlider.maxValue);
            isChanging = true; // Start updating the slider
        }
    }
}
