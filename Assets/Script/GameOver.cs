using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject canvasGameOver;

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            ShowGameOverPanel();
        }
    }

    void ShowGameOverPanel()
    {
        if (canvasGameOver != null)
        {
            canvasGameOver.SetActive(true);
        }
    }
}
