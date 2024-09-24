using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_Mechanic : MonoBehaviour
{
    MovementController playerController;
    MovementController playerController2;
    [SerializeField] GameObject player;
    [SerializeField] GameObject player2;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        playerController = player.GetComponent<MovementController>();
        playerController2 = player2.GetComponent<MovementController>();
    }
    public IEnumerator Teleport()
    {
        audioManager.playSFX(audioManager.teleportSFX);
        playerController.enabled = false;
        playerController2.enabled = false;
        yield return new WaitForSeconds(0.01f);
        Vector2 playerPos = player.transform.position;
        player.transform.position = player2.transform.position;
        player2.transform.position = playerPos;
        yield return new WaitForSeconds(0.01f);
        playerController.enabled = true;
        playerController2.enabled = true;
    }
}
