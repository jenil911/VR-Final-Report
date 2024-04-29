using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ProgressBar : MonoBehaviour
{
    public Slider slider;
    public int maxProgress = 10;
    private int currentProgress = 0;

    private void Start()
    {
        // Initialize the slider
        slider.maxValue = maxProgress;
        slider.value = 0;
    }

    public void IncrementProgress()
    {
        if (currentProgress < maxProgress)
        {
            currentProgress++;
            slider.value = currentProgress;
        }
    }
}
