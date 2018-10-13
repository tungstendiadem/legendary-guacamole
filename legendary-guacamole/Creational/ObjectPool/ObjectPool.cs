using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.ObjectPool
{
    public class Poolable
    {
        public DateTime CreatedAt { get; } = DateTime.Now;
        public object Member { get; set; }
    }

    public static class Pool
    {
        private static List<Poolable> _available = new List<Poolable>();
        private static List<Poolable> _occupied = new List<Poolable>();

        public static Poolable GetObject()
        {
            lock(_available)
            {
                if (_available.Count !=0)
                {
                    Poolable obj = _available[0];
                    _occupied.Add(obj);
                    _available.RemoveAt(0);
                    return obj;
                }
                else
                {
                    Poolable obj = new Poolable();
                    _occupied.Add(obj);
                    return obj;
                }
            }
        }
        private static void Clean(Poolable obj)
        {
            obj.Member = null;
        }
        public static void Release(Poolable obj)
        {
            Clean(obj);
            lock (_available)
            {
                _available.Add(obj);
                _occupied.Remove(obj);
            }
        }
    }


}