using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScreenOrientationHandler : MonoBehaviour
{

    public TextMeshProUGUI orientationText;
    private ScreenOrientation currentOrientation;
    // Start is called before the first frame update
    void Start()
    {
        currentOrientation = Screen.orientation;
        UpdateOrientationText();
    }

    // Update is called once per frame
    void Update()
    {
        // Verifica se a orientação mudou
        if (Screen.orientation != currentOrientation)
        {
            currentOrientation = Screen.orientation;
            UpdateOrientationText();
        }
    }

    void UpdateOrientationText()
    {
        if (currentOrientation == ScreenOrientation.LandscapeLeft)
        {
            orientationText.text = "Bom dia!";
        }
        else if (currentOrientation == ScreenOrientation.LandscapeRight)
        {
            orientationText.text = "Boa Noite!";
        }
        else
        {
            //orientationText.text = "Other Orientation";
        }
    }
}
