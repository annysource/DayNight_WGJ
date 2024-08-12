using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewItem : MonoBehaviour
{
    public GameObject pochete, boneca, celular, disket, olimpiadas, real;

    private void Start()
    {
        pochete.SetActive(false);
        boneca.SetActive(false);    
        celular.SetActive(false);
        disket.SetActive(false);
        olimpiadas.SetActive(false);
        real.SetActive(false);
    }
      public void ShowPochete()
    {
        pochete.SetActive(true);
    }
    public void ShowBoneca()
    {
        boneca.SetActive(true);
    }
    public void ShowCelular()
    {
        celular.SetActive(true);
    }
    public void ShowDisket()
    {
        disket.SetActive(true);
    }
    public void ShowOlimpiadas()
    {
        olimpiadas.SetActive(true);
    }
    public void ShowReal()
    {
        real.SetActive(true);
    }

}
