using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject pickUps;
    private GameObject NewItem;
    public GameObject npc;

    public List<Transform> possibleSpawns = new List<Transform>();
    
    
    // Start is called before the first frame update
    void Start()
    {
        for(int spawnList = 0; spawnList < spawnPoints.Length; spawnList++)
        {
            possibleSpawns.Add(spawnPoints[spawnList]);
        }
    }

    public void DistributeCollectibles()
    {
        for (int collect = 0; collect < 10; collect++)
        {

            int spawnIndex = Random.Range(0, possibleSpawns.Count - 1);
            NewItem = Instantiate(pickUps, possibleSpawns[spawnIndex].position, possibleSpawns[spawnIndex].rotation);
            NewItem.name = "collect" + collect.ToString();
            NewItem.GetComponent<CoinAnimate>().collectNumber = collect;
            NewItem.GetComponent<CoinAnimate>().reSkin(collect);

            possibleSpawns.RemoveAt(spawnIndex);
        }

    }

}
