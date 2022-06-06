using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesScript : MonoBehaviour
{
   public void ChangeScenes(int numberScenes)
   {
      SceneManager.LoadScene(numberScenes);
   }

   public void Exit()   
   {
      Application.Quit();
   }

   public void Restart()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
   }
}
