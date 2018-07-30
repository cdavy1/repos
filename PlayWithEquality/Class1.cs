using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace PlayWithEquality
{ 
public class NonBlankStringList : Collection<string>
{
            protected override void InsertItem(int index, string item)
    {
        if (string.IsNullOrWhiteSpace(item))
            throw new ArgumentException("string is null or blank");
        base.InsertItem(index, item);
    }
        protected override void SetItem(int index, string item)
        {
            if (string.IsNullOrWhiteSpace(item))
                throw new ArgumentException("string is null or blank");
            base.SetItem(index, item);
        }
    }

}