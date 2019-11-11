using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interpreter : MonoBehaviour
{
    public NodeManager nodeManager;

    public void Execute(string str)
    {
        foreach (char s in str)
        {
            Command(s);
        }
    }

    public void Command(char s)
    {
        switch (s)
        {
            case '>':
                nodeManager.Next();
                break;
            case '<':
                nodeManager.Prev();
                break;
            case '+':
                nodeManager.Increment();
                break;
            case '-':
                nodeManager.Decrement();
                break;
            case '[':
                // @todo
                break;
            case ']':
                // @todo
                break;
            case '.':
                nodeManager.Output();
                break;
            case ',':
                nodeManager.Input();
                break;
                
            default:
                break;
        }
    }
}
