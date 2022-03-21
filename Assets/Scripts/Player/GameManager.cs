using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public static Dictionary<int, PlayerManager> players = new Dictionary<int, PlayerManager>();

    //public Canvas mainCanvas;

    public GameObject localPlayerPrefab;
    public GameObject playerPrefab;

    public GameObject mainCanvas;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        else if (instance != this)
        {
            Debug.Log("Instance already exists, destroying object");
            Destroy(this);
        }
    }

    public void SpawnPlayer(int _id, string _userName)
    {
        GameObject _player;
        //_player.transform.SetParent(mainCanvas.transform, true);
        
        if(_id == Client.instance.myId)
        {
            _player = localPlayerPrefab;
            GameObject _newPlayer = Instantiate(_player, transform.position, transform.rotation) as GameObject;
            _newPlayer.transform.SetParent(mainCanvas.transform, false);
           // _newPlayer.transform.SetParent(GameObject.FindGameObjectWithTag("underCanvas").transform, false);
        }

        else
        {
            _player = playerPrefab;
            GameObject _newPlayer1 = Instantiate(_player, transform.position, transform.rotation) as GameObject;
            _newPlayer1.transform.SetParent(mainCanvas.transform, false);
           // _newPlayer1.transform.SetParent(GameObject.FindGameObjectWithTag("underCanvas").transform, false);
        }

        _player.GetComponent<PlayerManager>().id = _id;
        _player.GetComponent<PlayerManager>().userName = _userName;
        players.Add(_id, _player.GetComponent<PlayerManager>());
    }
}
