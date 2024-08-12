using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventario : MonoBehaviour
{
    public GameObject dayItemPrefab;  // Prefab para itens diurnos
    public GameObject nightItemPrefab;  // Prefab para itens noturnos
    public Transform container;    // Container onde os itens ser�o exibidos
    public Inventario inventario;  // Refer�ncia ao invent�rio

    public bool isDay;  // Define se � dia ou noite

    void Start()
    {
        AtualizarInventario();
    }

    public void AtualizarInventario()
    {
        if (inventario == null || container == null || dayItemPrefab == null || nightItemPrefab == null)
        {
            Debug.LogError("Refer�ncias necess�rias n�o foram atribu�das.");
            return;
        }

        // Limpar o container antes de atualizar
        foreach (Transform child in container)
        {
            Destroy(child.gameObject);
        }

        // Obter a lista de pistas atuais (diurnas ou noturnas)
        List<Pistas> pistasAtuais = inventario.ObterPistasAtuais();

        if (pistasAtuais == null || pistasAtuais.Count == 0)
        {
            Debug.LogWarning("Nenhuma pista dispon�vel para exibir no invent�rio.");
            return;
        }

        // Seleciona o prefab com base em isDay
        GameObject itemPrefab = isDay ? dayItemPrefab : nightItemPrefab;

        // Criar os itens na UI
        foreach (Pistas pista in pistasAtuais)
        {
            GameObject item = Instantiate(itemPrefab, container);
            ItemInventario itemInventario = item.GetComponent<ItemInventario>();
            if (itemInventario != null)
            {
                itemInventario.ConfigurarItem(pista);
            }
            else
            {
                Debug.LogError("O prefab de item n�o cont�m o componente ItemInventario.");
            }
        }
    }



}
