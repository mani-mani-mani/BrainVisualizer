using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node : MonoBehaviour
{
    char value;
    public string s_value
    {
        get { return value.ToString(); }
    }

    Text text;

    // Start is called before the first frame update
    void Start()
    {
        // 初期値は 0 にする
        this.value = (char)0;

        this.text = this.GetComponent<Text>();
        this.Display();
    }
    public void Display()
    {
        this.text.text = s_value;
    }

    public void Increment()
    {
        value++;
        Display();
    }

    public void Decrement()
    {
        value--;
        Display();
    }

    public void Input(char inputValue)
    {
        this.value = inputValue;
        Display();
    }
}
