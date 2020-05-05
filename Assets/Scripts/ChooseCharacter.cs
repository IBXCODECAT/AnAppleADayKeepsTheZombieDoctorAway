using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCharacter : MonoBehaviour
{
    public GameObject[] characterOptions;

    private void Start()
    {
        foreach (GameObject go in characterOptions)
            go.SetActive(false);

        characterOptions[Random.Range(0, characterOptions.Length)].SetActive(true);
    }
}
