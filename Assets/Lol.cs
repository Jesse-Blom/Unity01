using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Lol : MonoBehaviour
{

    public Transform Player;

    public AudioSource lol;

    bool beentheredonethat = false;

    private void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "Player") && (beentheredonethat == false))
        {
            lol.Play();

            beentheredonethat = true;
        }
    }
}
