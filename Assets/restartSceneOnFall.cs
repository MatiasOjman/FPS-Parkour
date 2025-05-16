using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartSceneOnFall : MonoBehaviour
{
    public float deathFallHeight = -15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < deathFallHeight) 
        {
            Debug.Log("respawn");
            SceneManager.LoadScene("FPS Parkour");
        }
    }
}
