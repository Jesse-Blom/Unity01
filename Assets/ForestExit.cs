using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ForestExit : MonoBehaviour
{
    //public AudioClip warning;

    public Transform Player;

    public AudioSource forestexit;

    bool beentheredonethat = false;

    private void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "Player") && (beentheredonethat == false)) 
        {
            forestexit.Play();

            beentheredonethat = true;

            Debug.Log(beentheredonethat);
        }
    }
}