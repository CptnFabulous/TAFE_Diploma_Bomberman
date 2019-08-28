using System.Collections;
using System.Collections.Generic;
using UnityEngine;





using UnityEngine.TestTools;
using NUnit.Framework;

public class BombermanTests
{
    private GameObject game;
    private Player[] players;
    
    Player GetPlayer(int index)
    {
        foreach (var player in players)
        {
            if(player.playerNumber == index)
            {
                return player;
            }
        }
        return null;
    }
    
    [SetUp]
    void SetUp()
    {
        GameObject gamePrefab = Resources.Load<GameObject>("Prefabs/Game");
        game = Object.Instantiate(gamePrefab);
        players = Object.FindObjectsOfType<Player>();
    }

    [UnityTest]
    IEnumerator PlayerDropsBomb()
    {
               yield return new WaitForEndOfFrame();
        Bomb bomb = Object.FindObjectOfType<Bomb>();
        Assert.IsTrue(bomb != null, "The Bomb didn't spawn");
        Debug.Break();
    }

    [TearDown]
    void TearDown()
    {
        Object.Destroy(game);
    }
}
