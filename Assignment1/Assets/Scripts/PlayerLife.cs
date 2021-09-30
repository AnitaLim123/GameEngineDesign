using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public Vector3 respawn;

    private void Start()
    {
        respawn = transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            transform.position = respawn;
        }

        if (collision.gameObject.CompareTag("End"))
        {
            Application.Quit();
        }
        
    }
}
