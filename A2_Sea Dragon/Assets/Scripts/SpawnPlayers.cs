using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    // Start is called before the first frame update
    private void Start()
    {
        Vector2 randomPosition = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        GameObject player=PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
        GameManager.Instance.player = player;
    }

}
