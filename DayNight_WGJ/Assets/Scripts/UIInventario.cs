using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventario : MonoBehaviour
{
    public GameObject dayItemPrefab;  // Prefab para itens diurnos
    public GameObject nightItemPrefab;  // Prefab para itens noturnos
    public Transform container;    // Container onde os itens serão exibidos
    public Inventario inventario;  // Referência ao inventário

    public bool isDay;  // Define se é dia ou noite

    void Start()
    {
        AtualizarInventario();
    }

    public void AtualizarInventario()
    {
        if (inventario == null || container == null || dayItemPrefab == null || nightItemPrefab == null)
        {
            Debug.LogError("Referências necessárias não foram atribuídas.");
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
            Debug.LogWarning("Nenhuma pista disponível para exibir no inventário.");
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
                Debug.LogError("O prefab de item não contém o componente ItemInventario.");
            }
        }
    }



}
