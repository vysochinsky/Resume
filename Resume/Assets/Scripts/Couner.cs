using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Couner : MonoBehaviour
{
    public GameObject player;

    void FixedUpdate()
    {
        Text text = gameObject.GetComponent<Text>();
        DeleteCircle count = player.gameObject.GetComponent<DeleteCircle>();
        text.text = count.count.ToString();
    }
}
