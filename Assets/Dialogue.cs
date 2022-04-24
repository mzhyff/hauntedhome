using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class Dialogue
{
	public GameObject Canvas;
	public GameObject textbox;



	[TextArea(3, 10)] 
    public string[] sentences;
}
//private static string[] scriptArray = {"Sage: Instruction on killing a ghost", " ", "The ghost is the one who plays with the wires in our head", " tweaking the feedback loops of dopamine", "self regulated reward and punishment, to remain comfortable",
//							"consumable, compliant and complicit", " a citizen and subject of carceral logics", " It haunts our reflexes and reactions", " and governs our relationships through commodifiable exchanges of productivity and profitability",
//							"or as Césaire put it", " complete and utter “thingification”.", " ", "Haunted home:", " ", "a life of contentment and normality", "The need for a conceptual, solid, home to be fulfilled", "or the hollow inside is haunted husks of impressions",
//							"In the fear of dark water I sit in a warm pool of small size in the dim light ", "It is soothing to sit here", "I am uncertain of my surroundings I am less worried than before I suppose", "but from time to time the drains on the side of the walls grabs my arms with such a sudden pull ",
//							" of suction into the density of a circular darkness in the narrow space of floaty things", " shattered memories fell-off hair and unlimited tuby void ", "The spook of shames", " ", " Sage: Instruction on killing a ghost", " ", "This ghost is a tricky one, a slippery spectre that spills out into everything",
//							"Check the shadows", "see if he still lurks there", "Not one speck can remain", "Haunted home", " ", "anxiousness plays the background tune", "everything great becomes temporary stretched thin", "slowly but certainly exhausted body",
//							"there is nowhere to return to or hide from", "the drain comes within this body that feels cold and", "recalls the night mom and I got lost finding the bus home", "on a strange street of neon light restaurants she asked me to remember",
//						 "this feeling of never arriving home", " ", "lol more yum words needed here ", " Sage: Instruction on killing a ghost", " ", "So even when things seemed to get a little better", " it was actually getting more efficient", "we need to kill the capitalist in our heads",
//						" the ghost that haunts us", "Fill yourself with an unending optimism", "Equal parts love and rage", "And Endless hope in the face of the impossible", "Throw a brick through a window, use the debris to unbuild the walls that imprison", "Hijack and hack into an old satellite falling out of orbit", " "};
//private int arrayPos = 0;



// void OnMouseDown()
// {



//	Debug.Log("clicked");
//	textbox.GetComponent<Text>().text = "please";
//scriptArray[arrayPos];
//			if (arrayPos == (scriptArray.Length - 1))
//			{
//	arrayPos = 0;
//}
//		else
//			{
//	arrayPos++;
//}


//}

//}
