using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float gainingSpeed;
    [SerializeField] private float turnSpeed;

    private int steerValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed += gainingSpeed * Time.deltaTime;

        transform.Rotate(0f, steerValue * turnSpeed * Time.deltaTime, 0f);

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void Steer(int value)
    {
        steerValue = value;
    }

    public void ItemPickUp(ItemType itemType, float value)
    {
        switch (itemType)
        {
            case ItemType.speed:
                speed -= value;
                break;
            case ItemType.points:
                
                break;
            default:
                break;
        }

        if(speed <= 0) { speed = 0; };
    }
}
