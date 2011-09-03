using System;

namespace SMP
{
	public class Windows
	{
		byte type; //This holds type information, used in deciding which kind of window we need to send.
		Point3 pos; //The pos of the block that this window is attached to
		World level;
		Item[] items = new Item[0]; //Hold all the items this window has inside it.

		Windows(byte Type, Point3 Pos, World Level)
		{
			type = Type;
			pos = Pos;
			level = Level;

			
			//Create a new window class based on the type
		}

		bool AddItem(Item item)
		{
			byte slot = FindEmptySlot();
			if (slot == 255) return false;

			return AddItem(item, slot);
		}
		bool AddItem(Item item, byte slot)
		{
			return false;
		}

		void RemoveItem(short id)
		{
			RemoveItem(id, 1);
		}
		void RemoveItem(short id, byte count)
		{

		}

		byte FindEmptySlot()
		{
			return 255;
		}
	}

	public enum WindowSlots
	{
		Chest = 63,
		LargeChest = 90,
		Crafting = 46,
		Dispenser = 45
	}
	public enum WindowID
	{
		Chest = 0,
		WorkBench = 1,
		Furnace = 2,
		Dispenser = 3
	}
}

