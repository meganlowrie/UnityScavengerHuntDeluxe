using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonePrefab : MonoBehaviour
{
    private MeshRenderer rend;
    public Texture[] textures;
    public int collect;
    
    void Awake()
    {
        rend = GetComponent<MeshRenderer>();
        rend.GetComponent<MeshRenderer>().material.mainTexture = textures[collect];
    }

}
