using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ItemInventario : MonoBehaviour
{
    public Image imagemPista;
    public TextMeshProUGUI nomePista;

    public void ConfigurarItem(Pistas pista)
    {
        imagemPista.sprite = pista.imagem;
        nomePista.text = pista.nome;
    }
}
