using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Temple : MonoBehaviour
{

    public Transform Player;

    public AudioSource temple;

    bool beentheredonethat = false;

    private void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "Player") && (beentheredonethat == false))
        {
            temple.Play();

            beentheredonethat = true;
        }
    }
}
