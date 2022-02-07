/*
 * Created By: Camp Steiner 
 * Date Created: Jan 31, 2022
 * 
 * Last Edited By: Camp Steiner
 * Last Edited: Feb 7, 2022
 * 
 * Description: Basket that floats back and forth and grabs apples
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos);
        this.transform.position = new Vector3(mousePos3D.x, this.transform.position.y, this.transform.position.z);
    }

    //Called on collision 
    void OnCollisionEnter( Collision c ){
        if(c.gameObject.tag == "Apple"){
            Destroy(c.gameObject);
        }
    }
}
