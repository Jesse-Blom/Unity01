using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class ActivateLeft : MonoBehaviour
{
    public PlayableDirector leftoption;

    bool downornah = false;

    bool time = false;

    private void OnMouseDown()
    {

        if (downornah == false)
        {
            leftoption.Play();
            downornah = true;

            Invoke("yayscene", 140f);


        }
    }
    void yayscene()
    {
        if (downornah == true)
        {
            SceneManager.LoadScene("YayScene");
        }

    }
}



