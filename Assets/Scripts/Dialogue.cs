using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public Text dialogueTextBox;
    public Text npcNameText;
    public string[] lines;
    public bool interacted;
    public float textSpeed;
    private int index;

    void Start()
    {
        interacted = false;
        gameObject.SetActive(false);
        dialogueTextBox.text = string.Empty;   
    }
    public void NextText()
    {
        if (dialogueTextBox.text == lines[index])
        {
            NextLine();
        }
        else
        {
            
            StopAllCoroutines();
            dialogueTextBox.text = lines[index];
        }

    }
    public void StartDialogue()
    {
        index = 0;
        //interacted=true;
        dialogueTextBox.text = string.Empty;
        gameObject.SetActive(true);
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            dialogueTextBox.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    void NextLine()
    {
        if(index < lines.Length -1)
        {
            index++;
            dialogueTextBox.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            interacted = false;
            gameObject.SetActive(false);
        }
    }
}
