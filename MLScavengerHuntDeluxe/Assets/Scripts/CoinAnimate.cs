using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAnimate : MonoBehaviour
{
    [Header("Animator Clip")]
    [Tooltip("Link to animator for game object")]
    public Animator animatorClip;

    [Header("Animation Parameters")]
    //[Tooltip("Link to animator for game object")]
    public string flipParameter = "Flip";

    [Header("Value of Object")]
    public int pointsWorth = 1;

    [Header("Particle effect (if any)")]
    public GameObject pickupEffect;

    [Header("Offscreen Location")]
    public GameObject startLocation;

    [Header("User Interface Manager")]
    public GameObject iManager;

    public Texture[] texture;

    /*
    [Header("Object Index")]
    public int objectIndex;
    */

    public float timeToAct = 0.35f;

    public PlayerHolding pHolding;

    public int collectNumber;

    private int swapNumber;

    private bool flip;

    private AudioSource coinAudio;

    // Start is called before the first frame update
    void Start()
    {
        flip = false;
        animatorClip = GetComponent<Animator>();
        coinAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (pickupEffect)
        {
            Instantiate(pickupEffect, transform.position, transform.rotation);
        }

        flip = true;

        animatorClip.SetBool(flipParameter, flip);

        Invoke("moveOff", timeToAct);

        coinAudio.Play(0);
    }

    private void moveOff()
    {

        if (pHolding.isHolding)
        {
            swapNumber = pHolding.holdValue;

            reSkin(swapNumber);

            flip = false;
            Invoke("swap", timeToAct);
        }
        else
        {
            transform.position = startLocation.transform.position;
        }

        pHolding.CheckPickUp(collectNumber);

        iManager.GetComponent<InterfaceManager>().CollectibleUpdate(collectNumber);

        collectNumber = swapNumber;

    }

    private void swap()
    {
        animatorClip.SetBool(flipParameter, flip);
    }

    public void reSkin(int index)
    {
        gameObject.transform.Find("CoinBack").GetComponent<MeshRenderer>().material.mainTexture = texture[index];
    }


}
