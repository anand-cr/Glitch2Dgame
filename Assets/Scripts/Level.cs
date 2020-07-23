using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    int currentSceneIndex = 0; 


    private void Start()
    {   
        StartCoroutine(LoadStartScene());
    }


    IEnumerator LoadStartScene()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
