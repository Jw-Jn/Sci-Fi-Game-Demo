using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructable : MonoBehaviour
{
    [SerializeField]
    private GameObject _createDestroy;

    public void DestroyCrate()
    {
        Instantiate(_createDestroy, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
	
}
