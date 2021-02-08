/*
 * 元素源类
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour {
    public List<Item> items = new List<Item>();

    void Awake()
    {
        BuildDatabase();
    }

    /// <summary>
    /// 根据编号查找
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Item GetItem(int id)
    {
        return items.Find(item=> item.id == id);
    }

    /// <summary>
    /// 根据名称查找
    /// </summary>
    /// <param name="itemName"></param>
    /// <returns></returns>
    public Item GetItem(string itemName)
    {
        return items.Find(item => item.title == itemName);
    }

    /// <summary>
    /// 生成元素（后期改为自动生成并加载数据库文件）
    /// </summary>
    void BuildDatabase()
    {
        items = new List<Item>() {
            new Item(0, "Diamond Sword", "A sword made of diamond.",
            new Dictionary<string, int> {
                { "Power", 15 },
                { "Defence", 10 }
            }),
            new Item(1, "Diamond Ore", "A pretty diamond.",
            new Dictionary<string, int> {
                { "Value", 300 }
            }),
            new Item(2, "Silver Pick", "A pick that could kill a vampire.",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            })
        };
    }
}
