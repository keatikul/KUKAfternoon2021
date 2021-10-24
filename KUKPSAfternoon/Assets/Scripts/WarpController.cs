using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WarpController : MonoBehaviour
{
    public string sceneName;
    public AudioSource warpSound;
    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Player")
       {
           Invoke("LoadNextScene",0.6f);
           PlayerPrefs.SetString("PrevScene",sceneName);
           var player = other.gameObject.GetComponent<PlayerControllerRigidBody>();
           PlayerPrefs.SetInt("CoinCount",player.coinCount);
           warpSound?.Play();
       }
    }
    void LoadNextScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
