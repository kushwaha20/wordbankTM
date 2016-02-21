using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System;

public class WordBank 
{
	List<string> allWordsOfDictionary;
	
	private static readonly WordBank instance = new WordBank ();
	
	public static WordBank Instance 
	{
		get 
		{
			return instance;
		}
	}
	
	private WordBank ()
	{
		allWordsOfDictionary = new List<string>();
		ReadAllWordsFromDictionary();
	}
	
	
	/// <summary>
	/// Reads all words from dictionary.
	/// </summary>
	private void ReadAllWordsFromDictionary()
	{
		try
		{
			TextAsset allWordCSV = Resources.Load("words.txt") as TextAsset;
			string[] linesInFile = allWordCSV.text.Split('\n');
			
			//Read all words from dictionary and add to list
			for(int i=0; i<linesInFile.Length; i++ )
			{
				if(linesInFile[i].Length > 0)
				{
					allWordsOfDictionary.Add(linesInFile[i]);
				}
				
			}
			
		}
		catch (Exception e)
		{
			Console.WriteLine("{Dictionary could not be read due to ----> }\n", e.Message);
		}
		
	}
	
	#region Dictionary Utility Methods
	
	/// <summary>
	/// Determines whether this Dictionary is containing the specified wordToBeChecked.
	/// </summary>
	/// <returns><c>true</c> if this Dictionary is containing the specified wordToBeChecked; otherwise, <c>false</c>.</returns>
	/// <param name="wordToBeChecked">Word to be checked.</param>
	public bool IsContaining (string wordToBeChecked)
	{
		wordToBeChecked = wordToBeChecked.ToUpper();
		return allWordsOfDictionary.Contains(wordToBeChecked);
	}
	
	/// <summary>
	/// Determines whether current game grid is valid.
	/// </summary>
	/// <returns><c>true</c> if current game grid is valid; otherwise, <c>false</c>.</returns>
	public bool IsGridIsValid (char [] gridLetters)
	{
		List<char> gridCharList = new List<char>(gridLetters);
		return false;
	}
	#endregion
}

