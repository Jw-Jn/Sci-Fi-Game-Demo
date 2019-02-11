using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField]
    private AudioClip _pickupAudio;

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            Player player = other.GetComponent<Player>();
            player.haveCoin = true;

            AudioSource.PlayClipAtPoint(_pickupAudio, Camera.main.transform.position);

            UIManager _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
            _uiManager.CollectedCoin();

            Destroy(this.gameObject);                
        }
    }

}
