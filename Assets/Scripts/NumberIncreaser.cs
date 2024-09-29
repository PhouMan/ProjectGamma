using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberIncreaser : MonoBehaviour
{

    public TextMeshProUGUI numberText;
    int counter = 0;

    public void buttonPressed()
    {
        counter++;
        numberText.text = counter.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
