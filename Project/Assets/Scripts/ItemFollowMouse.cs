/*
 * 鼠标操作类
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFollowMouse : MonoBehaviour {
	// Update is called once per frame
	/// <summary>
	/// 获取鼠标点击位置为transform位置
	/// </summary>
	void LateUpdate() {
        transform.position = Input.mousePosition;
	}
}
