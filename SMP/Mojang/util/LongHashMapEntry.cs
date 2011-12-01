﻿using System;
using System.Text;

namespace SMP
{
    public class LongHashMapEntry
    {
        public LongHashMapEntry(int i, long l, Object obj, LongHashMapEntry longhashmapentry)
        {
            value = obj;
            nextEntry = longhashmapentry;
            key = l;
            field_1026_d = i;
        }

        public long func_736_a()
        {
            return key;
        }

        public object func_735_b()
        {
            return value;
        }

        public override bool Equals(object obj)
        {
            if(!(obj is LongHashMapEntry))
            {
                return false;
            }
            LongHashMapEntry longhashmapentry = (LongHashMapEntry)obj;
            long long1 = func_736_a();
            long long2 = longhashmapentry.func_736_a();
            if(long1 == long2 || long1 != null && long1.Equals(long2))
            {
                object obj1 = func_735_b();
                object obj2 = longhashmapentry.func_735_b();
                if(obj1 == obj2 || obj1 != null && obj1.Equals(obj2))
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            return LongHashMap.GetHashCode(key);
        }

        public override string ToString()
        {
            return (new StringBuilder()).Append(func_736_a()).Append("=").Append(func_735_b()).ToString();
        }

        internal readonly long key;
        internal object value;
        internal LongHashMapEntry nextEntry;
        internal readonly int field_1026_d;
    }
}
