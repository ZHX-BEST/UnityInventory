/*
 * 方格元素类
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {
    public int id;
    public string title;
    public string description;
    public Sprite icon;//使用sprite图片格式
    public Dictionary<string, int> stats = new Dictionary<string, int>();

    /// <summary>
    /// 构造方法
    /// </summary>
    /// <param name="id">编号</param>
    /// <param name="title">名称</param>
    /// <param name="description">描述</param>
    /// <param name="stats">数字属性</param>
    public Item(int id, string title, string description, Dictionary<string, int> stats)
    {
        this.id = id;
        this.title = title;
        this.description = description;
        this.icon = Resources.Load<Sprite>("Sprites/Items/" + title);
        this.stats = stats;
    }

    public Item(Item item)
    {
        this.id = item.id;
        this.title = item.title;
        this.description = item.description;
        this.icon = Resources.Load<Sprite>("Sprites/Items/" + item.title);
        this.stats = item.stats;
    }
}
