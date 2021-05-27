using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Static : MonoBehaviour
{
    public static bool [] AMOGS = new bool[] { true, false, true, true, false, false, false, false, false, false, true, false, false, true, false };

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Player2"))
        {
            int temp = SceneManager.GetActiveScene().buildIndex;
            temp -= 3;
            AMOGS[temp] = true;
            Destroy(gameObject);
        }
    }
}
