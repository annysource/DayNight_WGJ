using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScreenOrientationHandler : MonoBehaviour
{

    public SpriteRenderer background;
    public TextMeshProUGUI orientationText, desorientationText;
    private ScreenOrientation currentOrientation;

    public Color dayColor = Color.yellow;
    public Color nightColor = Color.blue;
    void Start()
    {
        currentOrientation = Screen.orientation;
        UpdateOrientationText();
    }

    // Update is called once per frame
    void Update()
    {
        int currentHour = System.DateTime.Now.Hour;
        // Verifica se a orientação mudou
        if (Screen.orientation != currentOrientation)
        {
            currentOrientation = Screen.orientation;
            UpdateOrientationText();
        }

        if (currentHour >= 6 && currentHour < 18)
        {
            orientationText.text = "Bom dia!";
        }
        else
        {
            orientationText.text = "Boa Noite!";
        }
    }

    void UpdateOrientationText()
    {
        if (currentOrientation == ScreenOrientation.LandscapeLeft)
        {
            //orientationText.text = "Bom dia!";
            background.color = dayColor;
            desorientationText.text = "Eita, está claro!";
        }
        else if (currentOrientation == ScreenOrientation.LandscapeRight)
        {
            //  orientationText.text = "Boa Noite!";
            desorientationText.text = "Eita, escureceu!";
            background.color = nightColor;
        }
        else
        {
            //orientationText.text = "Other Orientation";
        }
    }
}
