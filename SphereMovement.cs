/*
Add a sphere in the scene and create a script that will move it at a constant speed to a target.  After reaching the target coordinates, wait for 2 seconds and hide the sphere.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public GameObject sphere;
    
    public GameObject target;
    
    public int speed;
    
    public void Update()
    {
    
        //dTime * speed 
        
        //distance between two transforms 
        Vector3 distVector = sphere.transform.position - target.transform.position;
        float dist = distVector.magnitude;
        
        //if near the target
        if(dist > 0.1f)
            //Normalize vector
            Vector3 unit = Vector3.Normalize(distVector)

            Vector3 newPos = unit*speed*Time.deltaTime + sphere.transform.position;

            sphere.transform.Translate(newPos);
            
        else
        {
            new WaitForSeconds(2);
            sphere.SetActive(False);
        }
        
         
        
        
    }
    
    //collision detection 
    
   

}