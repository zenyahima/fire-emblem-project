using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInfoSuppyCode : MonoBehaviour
{
    public Interaction interaction;

    public enum Interaction
    {
        Building,
        Terrain,
        Player,
        Enemy
    }
    
    public void Blink()
    {
        //turns cursor on and off
        gameObject.GetComponent<SpriteRenderer>().enabled = !gameObject.GetComponent<SpriteRenderer>().enabled;
    }
    public void start_b()
    {
        //runs function Blink at the start and reruns it every 0.4 seconds by default
        InvokeRepeating("Blink", 0, 0.4f);
    }

    public void stop_b()
    {
        CancelInvoke("Blink");
    }

    public void FillMenu()
    {
        //print(transform.name);
        //if(interaction == Interaction.Player)
        //{
        //    if(gameObject.GetComponent<StatsScript>())
        //    {
        //        print(gameObject.GetComponent<StatsScript>().name + " is currently at " + gameObject.GetComponent<StatsScript>().Lvl);
        //    }
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}