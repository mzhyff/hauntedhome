using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// the script is following this tutorial following some twitches https://youtu.be/_nRzoTzeyxU
/// </summary>
public class DialogueManager : MonoBehaviour {


	public Text dialogueText;
	public Dialogue dialogue;


	private Queue<string> sentences;

	// Use this for initialization

	// ive combined the dialogue trigger script with this one we probably dont need a trigger just need it to start working as soon as we entered the scene
	void Start () {
		sentences = new Queue<string>();
	}

	public void TriggerDialogue()
	{
		FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
	}

	public void StartDialogue (Dialogue dialogue)
	{

	
		sentences.Clear();

		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		DisplayNextSentence();
	}

	public void DisplayNextSentence ()
	{
		if (sentences.Count == 0)
		{
			EndDialogue();
			return;

			//for this one probably needs to put dialogues in a loop
		}

		//ok I'm making this up, need to say if mouse up anywhere or sth to trigger!!
		if (Input.GetMouseButtonDown(0)) { 
			string sentence = sentences.Dequeue();
			dialogueText.text = sentence;
		}
	}



	void EndDialogue()
	{
		
	}

}
