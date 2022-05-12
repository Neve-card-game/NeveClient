<<<<<<< HEAD
﻿//----------------------------------------------
//            NGUI: Next-Gen UI kit
// Copyright © 2011-2020 Tasharen Entertainment
//----------------------------------------------

using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Create and equip a random item on the specified target.
/// </summary>

[AddComponentMenu("NGUI/Examples/Equip Random Item")]
public class EquipRandomItem : MonoBehaviour
{
	public InvEquipment equipment;

	void OnClick()
	{
		if (equipment == null) return;
		List<InvBaseItem> list = InvDatabase.list[0].items;
		if (list.Count == 0) return;

		int qualityLevels = (int)InvGameItem.Quality._LastDoNotUse;
		int index = Random.Range(0, list.Count);
		InvBaseItem item = list[index];

		InvGameItem gi = new InvGameItem(index, item);
		gi.quality = (InvGameItem.Quality)Random.Range(0, qualityLevels);
		gi.itemLevel = NGUITools.RandomRange(item.minItemLevel, item.maxItemLevel);
		equipment.Equip(gi);
	}
=======
﻿//----------------------------------------------
//            NGUI: Next-Gen UI kit
// Copyright © 2011-2020 Tasharen Entertainment
//----------------------------------------------

using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Create and equip a random item on the specified target.
/// </summary>

[AddComponentMenu("NGUI/Examples/Equip Random Item")]
public class EquipRandomItem : MonoBehaviour
{
	public InvEquipment equipment;

	void OnClick()
	{
		if (equipment == null) return;
		List<InvBaseItem> list = InvDatabase.list[0].items;
		if (list.Count == 0) return;

		int qualityLevels = (int)InvGameItem.Quality._LastDoNotUse;
		int index = Random.Range(0, list.Count);
		InvBaseItem item = list[index];

		InvGameItem gi = new InvGameItem(index, item);
		gi.quality = (InvGameItem.Quality)Random.Range(0, qualityLevels);
		gi.itemLevel = NGUITools.RandomRange(item.minItemLevel, item.maxItemLevel);
		equipment.Equip(gi);
	}
>>>>>>> 0803b0379f9681b21ef2903850e2288c306242e9
}