using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class EndPlatform : MonoBehaviour
{
    public Transform player;
    public Transform goal;
    

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("You touched the goal");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    void Update()
    {
        
    }
}
