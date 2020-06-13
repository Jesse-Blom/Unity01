using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class RightTank : MonoBehaviour
{

    public Transform Player;

    public AudioSource righttank;

    bool beentheredonethat = false;

    private void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "Player") && (beentheredonethat == false))
        {
            righttank.Play();

            beentheredonethat = true;
        }
    }
}
