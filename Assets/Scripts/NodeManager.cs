using System.Collections;
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

            nodeList.Add(node.GetComponent<Node>());
        }
    }

    /// <summary>
    /// "+" に相当する
    /// </summary>
    void Increment()
    {
        nodeList[index].Decrement();
    }

    /// <summary>
    /// "-" に相当する
    /// </summary>
    void Decrement()
    {
        nodeList[index].Decrement();
    }

    /// <summary>
    /// ">" に相当する
    /// ポインターを一つ進める
    /// </summary>
    void Next()
    {
        Assert.IsTrue(index < maxIndex);
        index++;
    }

    /// <summary>
    /// "<" に相当する
    /// ポインターを一つ戻す
    /// </summary>
    void Prev()
    {
        Assert.IsTrue(index > 0);
        index--;
    }

    /// <summary>
    /// "," に相当する
    /// 1 バイト読み込む
    /// </summary>
    void Input()
    {
    }
}
