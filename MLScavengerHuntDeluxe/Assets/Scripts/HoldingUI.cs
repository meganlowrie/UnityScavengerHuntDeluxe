using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoldingUI : MonoBehaviour
{
    public Image collectible;
    public Sprite[] collectibleSource;

    public GameObject showSprite;

    // Start is called before the first frame update
    void Start()
    {
        showSprite.SetActive(false);
    }

    // Update is called once per frame
    public void CollectibleUpdate(int item)
    {
        showSprite.SetActive(true);
        collectible.GetComponent<Image>().sprite = collectibleSource[item];
    }
}
