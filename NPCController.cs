using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//public GameObject npcDialogueBox;

public class OnTriggerEnter2D : MonoBehaviour
{
    private void TriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            Debug.Log("NPC와 대화에 진입하겠습니까?");
            //npcDialogueBox.SetActive(true);
        }
    }

    private void TriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("NPC와 대화에서 나가겠습니까?");
            //npcDialogueBox.SetActive(false);
            
        }
    }
}