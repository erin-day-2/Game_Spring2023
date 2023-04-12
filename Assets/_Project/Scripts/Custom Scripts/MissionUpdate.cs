using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MissionUpdate : MonoBehaviour
{
    private Label missionLabel;

    private void Update()       //OnEnable()?
    {
        var rootVisualElement = GetComponent<UIDocument>().rootVisualElement;

        missionLabel = rootVisualElement.Q<Label>("MissionLabel");

        
        missionLabel.text = "";
    }
}
