using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(WaitForIt(3.0F));
    }

    
       //SceneManager.LoadScene(nextLevel);
        IEnumerator WaitForIt(float waitTime)
         {
             yield return new WaitForSeconds(waitTime);
             UnityEngine.SceneManagement.SceneManager.LoadScene("main_map");
         }


}

