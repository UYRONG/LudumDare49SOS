using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient grad;
    public Image fill;

    public void setHealth(float health)
    {
        slider.value = health;
        fill.color = grad.Evaluate(health / 9);
    }
}
