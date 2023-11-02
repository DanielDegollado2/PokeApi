using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject mainView;

    [SerializeField] pokemonList pokemonList;

    private void Awake()
    {
        StartCoroutine(getPokemonList());
    }

    IEnumerator getPokemonList()
    {
        WebRequestHandler webRequest = new WebRequestHandler();
        webRequest.method = "GET";
        StartCoroutine(webRequest.ExecuteRequest(string.Empty));
        yield return new WaitForSeconds(0.5f);
        Debug.Log(webRequest.result);
        pokemonList = JsonUtility.FromJson<pokemonList>(webRequest.result);
    }
}
