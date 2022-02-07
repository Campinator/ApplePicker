/*
 * Created By: Camp Steiner 
 * Date Created: Jan 31, 2022
 * 
 * Last Edited By: Camp Steiner
 * Last Edited: Feb 7, 2022
 * 
 * Description: Main script, attached to main camera
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicker : MonoBehaviour
{
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numBaskets; i++) {
            GameObject tBasketG0 = Instantiate(basketPrefab) as GameObject;
            tBasketG0.transform.position = new Vector3(0, basketBottomY + (basketSpacingY * i), 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
