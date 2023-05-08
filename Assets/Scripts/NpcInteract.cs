using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcInteract : MonoBehaviour
{
    private Transform player;
    public GameObject interackIcon;
    public Dialogue dialogueBoxManager;
    public string npcName;
    public float distance;
    public float distanceBetween;

    public string[] npcLines;


    private void Start()
    {
        interackIcon.SetActive(false);
        
        player = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
    }
    private void Update()
    {
        distance = Vector2.Distance(transform.position, player.position);
        Vector2 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;

        if (distance < distanceBetween)
        {
            interackIcon.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E))
            {
                if(dialogueBoxManager.interacted)
                {
                    dialogueBoxManager.NextText();
                    Debug.Log("kolejna linia");
                }
                else
                {
                    Interact();
                }                
            }
            
        }
        else
        {
            interackIcon.SetActive(false);
        }
    }

    private void Interact()
    {
        dialogueBoxManager.lines[0] = npcLines[0];
        dialogueBoxManager.lines[1] = npcLines[1];
        dialogueBoxManager.lines[2] = npcLines[2];
        dialogueBoxManager.interacted = true;
        dialogueBoxManager.StartDialogue();
        dialogueBoxManager.npcNameText.text = npcName;
    }

}
