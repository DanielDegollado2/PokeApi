using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class pokemonList
{
    public int count;
    public string next;
    public string previous;
    public List<pokeObj> results = new List<pokeObj>();
}

[Serializable]
public class pokeObj
{
    public string name;
    public string url;
}

