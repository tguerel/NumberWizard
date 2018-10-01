 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardScript : MonoBehaviour {

	int min = 1;
	int max = 1000;
	int guess = 500;

	// Use this for initialization
	void Start () 
	{
		Debug.Log ("I am the great Number Wizard! Think of a number between 1 and 1000 and i will guess it!");
		Debug.Log ("Press Up if it's higher, Down if it's lower and Space if i guessed it!");
		Debug.Log ("My first guess is " + guess + ". Is it higher or lower?"); 
	}
	
	// Update is called once per frame
	void Update ()
	{
		guessNumber ();



		
	}
	void guessNumber () 
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) 
		{

			min = guess;
			getGuess ();
			Debug.Log ("It's higher? Is it maybe " + guess + "?");


		} else if (Input.GetKeyDown (KeyCode.DownArrow))
		{

			max = guess;
			getGuess ();
			Debug.Log ("It's lower? Is it maybe " + guess + "?");
		} 
		else if(Input.GetKeyDown (KeyCode.Space))
		{

			Debug.Log("i guessed it!");
		}
	}

	void getGuess(){

		guess = (min + max) / 2;
		
	}
}




