using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
   public List<Pistas> pistasDiurnas;
    public List<Pistas> pistasNoturnas;
    public bool isDia = true;

    public void AdicionarPista(Pistas pista)
    {
        if (isDia) 
            pistasDiurnas.Add(pista);
        else
            pistasNoturnas.Add(pista);  
    }

    public List<Pistas> ObterPistasAtuais()
    {
        return isDia ? pistasDiurnas : pistasNoturnas;
    }
}
