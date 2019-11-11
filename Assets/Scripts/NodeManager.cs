﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Assertions;

public class NodeManager : MonoBehaviour
{
    // ポインターノードを表すオブジェクト
    public GameObject nodePrefab;
    public List<Node> nodeList;
    public int nodeSize = 80;

    // ポインターノードを表示するパネル
    public GameObject nodePanel;

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
        // @todo
    }

    /// <summary>
    /// "." に相当する
    /// 現在のメモリーに格納されてる値を出力する
    /// </summary>
    public void Output()
    {
        // @todo
    }
}
