using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class LookSomewhereElse : MonoBehaviour
{

    public Transform Player;

    public AudioSource suggestion;

    bool beentheredonethat = false;

    private void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "Player") && (beentheredonethat == false))
        {
            suggestion.Play();

            beentheredonethat = true;
        }
    }
}
