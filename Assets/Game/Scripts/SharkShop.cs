using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkShop : MonoBehaviour
{
    [SerializeField]
    private AudioClip _winAudio;

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            Player player = other.GetComponent<Player>();
            
            if (player.haveCoin == true)
            {
                player.haveCoin = false;
                player.EnableWeapon();

                AudioSource.PlayClipAtPoint(_winAudio, Camera.main.transform.position);

                UIManager _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
                _uiManager.SpentCoin();
            }
            else
            {
                Debug.Log("you have no money!");
            }
        }
    }

}
