using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    [SerializeField] Player player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            player.ItemPickUp(this.gameObject.GetComponent<Item>().ItemType, this.gameObject.GetComponent<Item>().Value);
            Destroy(this.gameObject);
        }
    }
}
