using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBuilding : MonoBehaviour
{
    [SerializeField] float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.back * speed * Time.deltaTime;
        if(transform.position.z < -30)
        {
            Destroy(this.gameObject);
        }
    }
}
