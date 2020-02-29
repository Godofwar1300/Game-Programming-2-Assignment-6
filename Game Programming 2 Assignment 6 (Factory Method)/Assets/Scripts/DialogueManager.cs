/*
* (Christopher Green)
* (DialogueManager.cs)
* (Assignment 6)
* (This is the script that handles the dialogue manager when the player interacts with the NPCs)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    //private GameObject myDialogueBox;
    public GameObject dialogueCanvasPrefab;
    public GameObject dialogueCanvas;
    private Text dialogueText;
    private string dialogueString;

    public string[] sentences;
    public int currentSentence;
    public int sentenceLength;

    public float textSpeed;

    public bool canNextLine;


    // Start is called before the first frame update
    void Start()
    {
        dialogueCanvasPrefab = Resources.Load("Prefabs/DialogueCanvas", typeof(GameObject)) as GameObject;
        //dialogueCanvas.SetActive(false);
        dialogueCanvas = Instantiate(dialogueCanvasPrefab);
        dialogueCanvas.SetActive(false);

        dialogueText = dialogueCanvas.GetComponentInChildren<Text>();
        dialogueString = "";

        currentSentence = -1;
        //textSpeed = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            textSpeed = .005f;
        }

        if (currentSentence != -1)
        {

            dialogueText.text = dialogueString;

            if (Input.GetKeyDown(KeyCode.E) && canNextLine)
            {
                NextLine();
            }

        }

    }

    public void NextLine()
    {
        if (currentSentence + 1 == sentences.Length)
        {
            currentSentence = -1;
            dialogueCanvas.SetActive(false);
        }
        else
        {
            textSpeed = .1f;
            dialogueString = "";
            currentSentence++;
            sentenceLength = sentences[currentSentence].Length;
            StartCoroutine(Type());
        }
    }

    IEnumerator Type()
    {

        foreach (char letters in sentences[currentSentence].ToCharArray())
        {

            yield return new WaitForSeconds(textSpeed);

            if(currentSentence != -1)
            {
                if(dialogueString.Length != sentenceLength)
                {
                    dialogueString += letters;
                    canNextLine = false;

                    if(dialogueString.Length == sentenceLength)
                    {
                        canNextLine = true;
                    }
                }
                
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            dialogueCanvas.SetActive(true);
            currentSentence = -1;

            NextLine();

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            dialogueCanvas.SetActive(false);
            dialogueString = "";
            dialogueText.text = dialogueString;
            currentSentence = -1;
        }
    }

}
