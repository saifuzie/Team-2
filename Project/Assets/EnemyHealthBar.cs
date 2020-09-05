﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    public Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();
    }

    public void UpdateSlider(float value)
    {
        if (value <= 0)
        {
            slider.value = 0;
        }
        else if (value >= 1)
        {
            slider.value = 1;
        }
        else
        {
            slider.value = value;
        }
    }
}
