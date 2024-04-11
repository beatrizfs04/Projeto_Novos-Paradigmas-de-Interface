using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class ButtonSelect : MonoBehaviour
{
    [Tooltip("The button to be selected when the object is enabled")]
    [SerializeField] GameObject selectButton;
    // Start is called before the first frame update
    void OnEnable()
    {
        if (selectButton == null)
        {
            Debug.LogError("Select Button not Atributted to Script");
            return;
        }

        EventSystem.current.SetSelectedGameObject(selectButton, new BaseEventData(EventSystem.current));
    }


}
