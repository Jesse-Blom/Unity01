using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class SeeingTanks : MonoBehaviour
{

    public Transform Player;

    public AudioSource seeingtanks;

    bool beentheredonethat = false;

    private void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "Player") && (beentheredonethat == false))
        {
            seeingtanks.Play();

            beentheredonethat = true;
        }
    }
}