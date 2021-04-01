using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHolding : MonoBehaviour
{
    public bool isHolding = false;
    public int holdValue;
    
    // Start is called before the first frame update
    void Start()
    {
        isHolding = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool Verify() => isHolding;

    public void CheckPickUp(int index)
    {
        isHolding = true;
        holdValue = index;
    }
}
