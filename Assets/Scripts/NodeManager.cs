﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class NodeManager : MonoBehaviour
{
    // ポインターノードを表すオブジェクト
    public GameObject nodePrefab;
    public List<Node> nodeList;
    public int nodeSize = 80;

    // ポインターノードを表示するパネル
    public GameObject nodePanel;

    // 入出力用のテキストコンポーネント
    public InputField inputField;
    public InputField outputField;

    // 現在のポインタの位置
    public int index;

    // ポインタの index の上限
    private const int maxIndex = 100;

    void Start()
    {
        // 最初のポインターの位置
        index = 0;

        // 全てのメモリーを初期化する
        for (int i = 0; i < maxIndex; i++)
        {
            // node を生成して、表示する
            GameObject node = Instantiate(nodePrefab, nodePanel.transform) as GameObject;

            node.transform.localPosition = new Vector3(i * nodeSize, 0.0f, 0.0f);

            nodeList.Add(node.GetComponentInChildren<Node>());
        }
    }

    /// <summary>
    /// "+" に相当する
    /// </summary>
    public void Increment()
    {
        Assert.IsTrue(0 <= index && index < maxIndex);
        nodeList[index].Increment();
    }

    /// <summary>
    /// "-" に相当する
    /// </summary>
    public void Decrement()
    {
        Assert.IsTrue(0 <= index && index < maxIndex);
        nodeList[index].Decrement();
    }

    /// <summary>
    /// ">" に相当する
    /// ポインターを一つ進める
    /// </summary>
    public void Next()
    {
        Assert.IsTrue(0 <= index && index < maxIndex);
        index++;
    }

    /// <summary>
    /// "<" に相当する
    /// ポインターを一つ戻す
    /// </summary>
    public void Prev()
    {
        Assert.IsTrue(0 <= index && index < maxIndex);
        index--;
    }

    /// <summary>
    /// "," に相当する
    /// 現在のメモリーに 1 バイト読み込む
    /// </summary>
    public void Input()
    {
        // 入力を受け取る
        char inputValue = inputField.text.First();
        nodeList[index].Input(inputValue);

        // 読み込んだ文字を削除する
        inputField.text = inputField.text.Remove(0, 1);
    }

    /// <summary>
    /// "." に相当する
    /// 現在のメモリーに格納されてる値を出力する
    /// </summary>
    public void Output()
    {
        // 出力を受け取る
        string outputValue = nodeList[index].s_value;

        // 結果を出力に追記していく
        outputField.text += outputValue;
    }
}
