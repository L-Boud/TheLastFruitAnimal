using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typewriter : MonoBehaviour
{
	public Text displayedText;
	public Text inputText;
	public Text italicText;

	private string outputString = null;
	private int i = 1;
	private bool done;
	private bool changed;

	void Update ()
	{
		if (!done)
		{
			displayedText.text = Typewrite (inputText.text);
		} else 
		{
			if (!changed)
			{
				displayedText.text = italicText.text;
				changed = true;
			}
		}
	}


	private string Typewrite (string text)
	{
		i++;
		char[] characters = text.ToCharArray ();
		outputString = outputString + characters [i].ToString ();
		if (i == (characters.Length - 1))
		{
			done = true;
		}
		return outputString;
	}

}
