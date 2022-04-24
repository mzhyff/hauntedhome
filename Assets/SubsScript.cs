using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*public class SubsScript : MonoBehaviour {
	
	public GameObject textBox;
	
	
    void Start()
    {
		StartCoroutine(TheSequence());
        
    }
	IEnumerator TheSequence()
	{  while(true) 
	
	{    //yield return new WaitForSeconds(25);//
			

			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = " Sage: Instruction on killing a ghost";
			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = " ";
			yield return new WaitForSeconds(8);
		textBox.GetComponent<Text>().text = "The ghost is the one who plays with the wires in our head";
		yield return new WaitForSeconds(8);
		textBox.GetComponent<Text>().text = " tweaking the feedback loops of dopamine";
	 	yield return new WaitForSeconds(8);
		textBox.GetComponent<Text>().text = "self regulated reward and punishment, to remain comfortable";
		yield return new WaitForSeconds(8);
		textBox.GetComponent<Text>().text = "consumable, compliant and complicit";
	 	yield return new WaitForSeconds(8);
		textBox.GetComponent<Text>().text = " a citizen and subject of carceral logics";
		yield return new WaitForSeconds(8);
		textBox.GetComponent<Text>().text = " It haunts our reflexes and reactions";
		yield return new WaitForSeconds(8);
		textBox.GetComponent<Text>().text = " and governs our relationships through commodifiable exchanges of productivity and profitability";
	 
	 	yield return new WaitForSeconds(8);
		textBox.GetComponent<Text>().text = "or as Césaire put it";
		yield return new WaitForSeconds(8);
		textBox.GetComponent<Text>().text = " complete and utter “thingification”.";
		yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = " ";



			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = "Haunted home:";
			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = " ";
			yield return new WaitForSeconds(8);
		textBox.GetComponent<Text>().text = "a life of contentment and normality";
		yield return new WaitForSeconds(8);
		textBox.GetComponent<Text>().text = " The need for a conceptual, solid, home to be fulfilled";
	 	yield return new WaitForSeconds(8);
		textBox.GetComponent<Text>().text = "or the hollow inside is haunted husks of impressions";
		yield return new WaitForSeconds(8);
		textBox.GetComponent<Text>().text = "In the fear of dark water I sit in a warm pool of small size in the dim light ";
		yield return new WaitForSeconds(8);
		textBox.GetComponent<Text>().text = "It is soothing to sit here";
	 	 yield return new WaitForSeconds(8); 
		textBox.GetComponent<Text>().text = "I am uncertain of my surroundings I am less worried than before I suppose";
		yield return new WaitForSeconds(8);
		textBox.GetComponent<Text>().text = "but from time to time the drains on the side of the walls grabs my arms with such a sudden pull ";
	 	yield return new WaitForSeconds(8);
		textBox.GetComponent<Text>().text = " of suction into the density of a circular darkness in the narrow space of floaty things";
		yield return new WaitForSeconds(8);
		textBox.GetComponent<Text>().text = " shattered memories fell-off hair and unlimited tuby void ";
	 	yield return new WaitForSeconds(8);
		textBox.GetComponent<Text>().text = "The spook of shames";

			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = " ";



			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = " Sage: Instruction on killing a ghost";
			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = " ";
			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = "This ghost is a tricky one, a slippery spectre that spills out into everything";
			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = "Check the shadows";
			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = "see if he still lurks there";
			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = "Not one speck can remain";




			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = "Haunted home";
			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = " ";
			yield return new WaitForSeconds(8);
	 	textBox.GetComponent<Text>().text = "anxiousness plays the background tune";
	 
	 	 yield return new WaitForSeconds(8);
		textBox.GetComponent<Text>().text = "everything great becomes temporary stretched thin";
		yield return new WaitForSeconds(8);
		textBox.GetComponent<Text>().text = "slowly but certainly exhausted body";
		yield return new WaitForSeconds(8);
		textBox.GetComponent<Text>().text = "there is nowhere to return to or hide from";
	 
	 	yield return new WaitForSeconds(8);
		textBox.GetComponent<Text>().text = "the drain comes within this body that feels cold and";
		yield return new WaitForSeconds(8);
		textBox.GetComponent<Text>().text = "recalls the night mom and I got lost finding the bus home";
	 	yield return new WaitForSeconds(8);
		textBox.GetComponent<Text>().text = "on a strange street of neon light restaurants she asked me to remember";
		yield return new WaitForSeconds(8);
		textBox.GetComponent<Text>().text = " this feeling of never arriving home";

			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = " ";


			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = "lol more yum words needed here ";

			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = " Sage: Instruction on killing a ghost";
			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = " ";
			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = "So even when things seemed to get a little better";
			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = " it was actually getting more efficient";
			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = "we need to kill the capitalist in our heads";
			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = " the ghost that haunts us";
	yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = "Fill yourself with an unending optimism";
			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = "Equal parts love and rage";
			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = "And Endless hope in the face of the impossible";
			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = "Throw a brick through a window, use the debris to unbuild the walls that imprison";
			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = "Hijack and hack into an old satellite falling out of orbit";

			yield return new WaitForSeconds(8);
			textBox.GetComponent<Text>().text = " ";
	 
	}
		
		
	}
}
*/