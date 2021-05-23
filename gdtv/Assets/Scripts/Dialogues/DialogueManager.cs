using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance { get; private set; }
    public GameObject ScreenDialogueOverlay;
    private Queue<string> sentences;
    void Awake()
    {
        if (Instance == null) { Instance = this; } else { Debug.Log("Warning: multiple " + this + " in scene!"); }
        sentences = new Queue<string>();
    }
    public void StartDialogue(Dialogue dialogue, string name)
    {
        sentences.Clear();
        ScreenDialogueOverlay.SetActive(true);

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        string sentence = sentences.Dequeue();
        Debug.Log(sentence);

        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
    }

    public void EndDialogue()
    {
        ScreenDialogueOverlay.SetActive(false);
    }

}
