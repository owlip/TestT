using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
    public void Menu(int i){
        if((i >= 0) && (i <= SceneManager.sceneCountInBuildSettings)){
            SceneManager.LoadScene(i);
        }
        else{
            Debug.LogError("Scene not found");
        }
    }
}
