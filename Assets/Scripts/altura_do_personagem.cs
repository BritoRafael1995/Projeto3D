using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class altura_do_personagem : MonoBehaviour
{
    public Transform personagem;
    Text texto_da_interface;
    void Start()
    {
        texto_da_interface = GetComponent<Text>();
    }

    void Update()
    {
        texto_da_interface.text = Mathf.RoundToInt(personagem.position.y).ToString();
    }
}
