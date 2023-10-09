using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class healthbar : MonoBehaviour
{
    public Health playerhealth;
    public Image fillImage;
    private Slider slider;

    void Awake()
    {
        slider = GetComponent<Slider>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(slider.value <=slider.minValue)
        {
            fillImage.enabled = false;

        }
        if(slider.value > slider.minValue && !fillImage.enabled)
        {
            fillImage.enabled=true;
        }


        float fillvalue = playerhealth.currentHealth / playerhealth.maxHealth;
        if(fillvalue <= slider.maxValue / 3)
        {
            fillImage.color = Color.white;    //critical
        }
        else if(fillvalue > slider.maxValue / 3)
        {
            fillImage.color = Color.red;
        }
        slider.value = fillvalue;

    }
}
