using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace HUD
{
    public class LoadOtherScene : MonoBehaviour
    {
        public void LoadScene(string SceneToLoad)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneToLoad);
        }
    }
}