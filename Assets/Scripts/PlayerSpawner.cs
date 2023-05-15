using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab; // Referencia al prefab del jugador
    private GameObject playerInstance; // Instancia actual del jugador
    public GameObject player;
    private void Start()
    {
        SpawnPlayer();
    }

    public void SpawnPlayer()
    {
        player.gameObject.SetActive(true);
        player.transform.position = playerPrefab.transform.position;
    }
}
