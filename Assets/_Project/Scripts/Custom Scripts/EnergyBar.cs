using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnergyBar : MonoBehaviour
{
    private VisualElement energyBar;

    private int width;
    private int height;

    private void Update()
    {
        var rootVisualElement = GetComponent<UIDocument>().rootVisualElement;

        energyBar = rootVisualElement.Q<VisualElement>("HealthBar");

       
    }
}
