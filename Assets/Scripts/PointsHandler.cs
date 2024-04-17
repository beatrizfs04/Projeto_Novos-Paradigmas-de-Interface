using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsHandler : MonoBehaviour
{
    void Update()
    {
        gameObject.GetComponent<TextMeshProUGUI>().SetText("Pontos: " + GameObject.Find("Main Camera").GetComponent<PauseManager>().GetScore());
    }
}
