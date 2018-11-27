using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typewriter02 : MonoBehaviour
{
	public Text displayedText;
	public Text inputText;
	public Text italicText;

	private string outputString = null;
	private int i = -1;
	private bool done;
	private bool changed;

	public float charsPerSec = 10;

	private void Awake ()
	{
		BeginTypewrite (inputText.text);
	}

	private void Update ()
	{
		if (done)
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
		if (i == (characters.Length - 1)) {
			done = true;
		}
		return outputString;
	}

	private void BeginTypewrite (string text)
	{
		char[] characters = text.ToCharArray ();
		StartCoroutine (Type (characters, charsPerSec));

	}

	private IEnumerator Type (char [] chars, float charsPerSec)
	{
		i++;
		outputString = outputString + chars [i].ToString ();
		displayedText.text = outputString;
		yield return new WaitForSeconds (1 / charsPerSec);
		if (i == (chars.Length - 1)) {
			done = true;
		} else {
			StartCoroutine (Type (chars, charsPerSec));
		}
	}

	}

	