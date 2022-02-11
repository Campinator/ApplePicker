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
    public List<GameObject> basketList;

    // Start is called before the first frame update
    void Start()
    {
        basketList = new List<GameObject>();
        for(int i = 0; i < numBaskets; i++) {
            //instantiate baskets 
            GameObject tBasketG0 = Instantiate(basketPrefab) as GameObject;
            tBasketG0.transform.position = new Vector3(0, basketBottomY + (basketSpacingY * i), 0);
            basketList.Add(tBasketG0);
        }
    }

    public void AppleDestroyed()
    {
        GameObject[] appleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach(GameObject apple in appleArray)
        {
            Destroy(apple);
        }
        //Destroy last basket when an apple is missed
        int basketIndex = basketList.Count-1;
        GameObject lastBasket = basketList[basketIndex];
        // Remove the Basket from the List and destroy the GameObject
        basketList.RemoveAt( basketIndex );
        Destroy( lastBasket );

        if(basketList.Count == 0){
            Application.LoadLevel("_Scene-00");
        }
    }
}
