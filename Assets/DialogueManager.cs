using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// the script is following this tutorial following some twitches https://youtu.be/_nRzoTzeyxU
/// </summary>
public class DialogueManager : MonoBehaviour
{


	public Text dialogueText;
	public Dialogue dialogue;


	private Queue<string> sentences;

	// Use this for initialization

	// ive combined the dialogue trigger script with this one we probably dont need a trigger just need it to start working as soon as we entered the scene
	void Start()
	{
		sentences = new Queue<string>();
		StartDialogue(dialogue);
	}

	public void StartDialogue(Dialogue dialogue)
	{
		Debug.Log("Started");
		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		
	}



	public void Update()
	{
		

		if (sentences.Count == 0)
		{
			Debug.Log("Restarted");
			foreach (string sentence in dialogue.sentences)
			{
				sentences.Enqueue(sentence);
			}
		}

		//ok I'm making this up, need to say if mouse up anywhere or sth to trigger!!
		if (Input.GetMouseButtonUp(0))
		{
			Debug.Log(sentences);
			string sentence = sentences.Dequeue();
			dialogueText.text = sentence;
		}
	}
}

