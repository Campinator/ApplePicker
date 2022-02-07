/*
 * Created By: Camp Steiner 
 * Date Created: Jan 31, 2022
 * 
 * Last Edited By: Camp Steiner
 * Last Edited: Feb 7, 2022
 * 
 * Description: Controls the movement of the Apple Tree
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in inspector")]
    public float speed = 0.1f;
    public float leftAndRightEdge = 10f;
    public GameObject applePrefab;
    public float secondsBetweenAppleDrops = 1f;
    private long appleDelta = 0;
    public float chanceToChangeDirections = 0.02f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DropApple", 2f, secondsBetweenAppleDrops);
    }

    void DropApple(){
        GameObject apple = Instantiate(applePrefab) as GameObject;
        apple.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        if(Mathf.Abs(transform.position.x) > leftAndRightEdge)
        {
            speed *= -1; //change position
        }
    }

    // Called on fixed intervals (50 times per second)

    private void FixedUpdate()
    {
        if(Random.value < chanceToChangeDirections)
        {
            speed *= -1; // random chance to change directions unprompted
        }
        if(appleDelta > secondsBetweenAppleDrops)
        {

        }
    }
}
