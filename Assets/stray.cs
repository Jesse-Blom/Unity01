
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class stray : MonoBehaviour
{
    //public AudioClip warning;

    public Transform Player;

    public AudioSource warning;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Player")
        {
            Debug.Log("You little shit");
            //AudioSource.PlayClipAtPoint(warning, Player.position, 2+1);

            warning.Play(); 
        }
    }
}