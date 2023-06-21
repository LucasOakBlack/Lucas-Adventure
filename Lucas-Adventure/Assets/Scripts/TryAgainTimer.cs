using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainTimer : MonoBehaviour
{
    public float time;
    private float currentTime;
    public int menuScene;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = time;
    }

    // Update is called once per frame
    void Update()
    {
       currentTime -= Time.deltaTime;
       if (currentTime <= 0){
        SceneManager.LoadScene(menuScene);
       }
    }
}
