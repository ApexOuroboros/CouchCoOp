using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnPlayers : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1"))
        {
            other.SendMessageUpwards("resetPlayerP1");
        }

        if (other.CompareTag("Player2"))
        {
            other.SendMessageUpwards("resetPlayerP2");
        }

    }

}
