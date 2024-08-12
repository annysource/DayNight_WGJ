using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewInventario : MonoBehaviour
{
    public GameObject inventario;
    public void ShowInventario()
    {
        inventario.SetActive(true);
    }

    // beleza :)

    public void QuitInventario()
    {
        inventario.SetActive(false);
    }
}
