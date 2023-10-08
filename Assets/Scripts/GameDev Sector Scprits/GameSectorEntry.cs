using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSectorEntry : MonoBehaviour
{

    private GameObject _player;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter(Collider _coll)
    {
        if(_coll.tag == _player.tag)
        {
            Debug.LogError("Entry GameDev Sector");
        }
    }
}
