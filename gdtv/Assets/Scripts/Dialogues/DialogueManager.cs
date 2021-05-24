using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance { get; private set; }
    public GameObject screenDialogueOverlay;
    public GameObject dialogueBox;
    public TextMeshProUGUI dialogueText;
    private Queue<string> sentences;
    private bool addingLetters = false;
    private string currentSentence;
    private const float DELAY_BETWEEN_LETTERS = 0.04f;
    void Awake()
    {
        if (Instance == null) { Instance = this; } else { Debug.Log("Warning: multiple " + this + " in scene!"); }
        sentences = new Queue<string>();
    }
    public void StartDialogue(Dialogue dialogue, string name)
    {
        sentences.Clear();
        screenDialogueOverlay.SetActive(true);
        dialogueBox.SetActive(true);
        currentSentence = dialogue.sentences[0];

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0 && !addingLetters)
        {
            EndDialogue();
            return;
        }

        if (addingLetters)
        {
            dialogueText.SetText(currentSentence);
            StopAddingLetters();
        }
        else
        {
            string sentence = sentences.Dequeue();
            currentSentence = sentence;
            dialogueText.SetText("");
            StartCoroutine(nameof(AddLetterToText), sentence);
        }

    }

    IEnumerator AddLetterToText(string sentence)
    {
        addingLetters = true;
        for (int i = 0; i < sentence.Length; i++)
        {
            dialogueText.SetText(dialogueText.text + sentence[i]);
            // TODO: Play letter audio
            yield return new WaitForSeconds(DELAY_BETWEEN_LETTERS);
        }
        addingLetters = false;
    }

    private void StopAddingLetters()
    {
        StopCoroutine(nameof(AddLetterToText));
        addingLetters = false;
    }

    public void EndDialogue()
    {
        screenDialogueOverlay.SetActive(false);
        dialogueBox.SetActive(false);
    }

}
