using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScreenOrientationHandler : MonoBehaviour
{
    public SpriteRenderer background;
    public TextMeshProUGUI orientationText;
    public Inventario inventario;
    public UIInventario uiInventario;
    private ScreenOrientation currentOrientation;

    public GameObject day, night;
    

    void Start()
    {
        currentOrientation = Screen.orientation;
        UpdateOrientarionAndInventory();
    }

    void Update()
    {
        // Verifica se a orientação mudou
        if (Screen.orientation != currentOrientation)
        {
            currentOrientation = Screen.orientation;
            UpdateOrientarionAndInventory();
        }
    }

    void UpdateOrientarionAndInventory()
    {
        if (currentOrientation == ScreenOrientation.LandscapeLeft)
        {
            day.SetActive(true);
            night.SetActive(false);
            orientationText.text = "Bom dia!";
            inventario.isDia = true;
        }
        else if (currentOrientation == ScreenOrientation.LandscapeRight)
        {
            night.SetActive(true);
            day.SetActive(false);
            orientationText.text = "Boa Noite!";
            inventario.isDia = false;
        }

        // Atualiza o inventário com base na orientação
        uiInventario.AtualizarInventario();
    }
}
