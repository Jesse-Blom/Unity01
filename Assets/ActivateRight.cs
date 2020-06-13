using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class ActivateRight : MonoBehaviour
{
    public PlayableDirector rightoption;

    bool downornah = false;

    bool time = false;

    private void OnMouseDown()
    {
        Debug.Log("muisklik");

        if(downornah == false)
        {
            rightoption.Play();
            downornah = true;

            Invoke("deathscene", 18.5f);
            

        }
    }

    void deathscene ()
    {
        if(downornah == true)
        {
            SceneManager.LoadScene("DeathScene");
        }
        
    }
}
