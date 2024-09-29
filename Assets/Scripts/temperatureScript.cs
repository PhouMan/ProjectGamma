using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class temperatureScript : MonoBehaviour
{

    public Slider progressBar;
    public float fillSpeed = 0.5f;
    private float targetProgress = 100f;

    // Start is called before the first frame update
    void Start()
    {
        progressBar.value = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (progressBar.value < targetProgress)
        {
            progressBar.value += fillSpeed * Time.deltaTime;
        }
    }

    public void DecreaseProgress(float amount)
    {
        progressBar.value = Mathf.Clamp(progressBar.value - amount, 0f, 1f);
    }
}
