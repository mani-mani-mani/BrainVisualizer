using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node : MonoBehaviour
{
    char value;
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
        this.text.text = value.ToString();
    }

    public void Increment()
    {
        value++;
    }

    public void Decrement()
    {
        value--;
    }
}
