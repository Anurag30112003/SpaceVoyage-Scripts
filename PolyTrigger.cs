using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolyTrigger : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}