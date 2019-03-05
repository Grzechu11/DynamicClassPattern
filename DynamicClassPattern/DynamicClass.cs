using System;
using System.Collections.Generic;
using System.Dynamic;

namespace DynamicClassPattern
{
    public class DynamicClass : DynamicObject
    {
        private Dictionary<string, Object> props =
        new Dictionary<string, object>();

        public DynamicClass() { }

        public override bool TryGetMember(GetMemberBinder binder,
        out object result)
        {
            string name = binder.Name.ToLower();
            return props.TryGetValue(name, out result);

        }

        public override bool TrySetMember(SetMemberBinder binder,
        object value)
        {
            props[binder.Name.ToLower()] = value;
            return true;
        }
    }
}
