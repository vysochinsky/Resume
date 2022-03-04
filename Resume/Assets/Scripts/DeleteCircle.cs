using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteCircle : MonoBehaviour
{
    public GameObject button;
    bool flag = false;
    public int count = 0;

    private void FixedUpdate()
    {
        Restart();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Circle")
        {
            collision.gameObject.SetActive(false);
            count++;
        }

    }
    void Restart()
    {
        if (count == 5)
        {
            Image res = button.GetComponent<Image>();
            res.enabled = true;
        }
    }
}
