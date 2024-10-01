using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
   public enum ItemType
   {
    ExtraBomb,
    BlastRadius,
    SpeedIncrease,
    SideSwap,
    ExtraHeart,
   }

   public ItemType type;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void OnItemPickup(GameObject player)
   {
        audioManager.playSFX(audioManager.powerup);

        switch (type)
        {
        case ItemType.ExtraBomb:
        player.GetComponent<BombController>().AddBomb();
        break;

        case ItemType.BlastRadius:
        player.GetComponent<BombController>().explosionRadius++;
        break;

        case ItemType.SpeedIncrease:
        player.GetComponent<MovementController>().speed++;
        break;

        case ItemType.SideSwap:
        var playerteleport = player.GetComponent<Teleport_Mechanic>();
        playerteleport.StartCoroutine("Teleport");
        break;

        case ItemType.ExtraHeart:
        player.GetComponent<HealthSystem>().health+=1;
        break;
        }

        Destroy(gameObject);
   }

   private void OnTriggerEnter2D(Collider2D Other)
   {
    if (Other.CompareTag("Player")) {
        OnItemPickup(Other.gameObject);

    }
   }
}
