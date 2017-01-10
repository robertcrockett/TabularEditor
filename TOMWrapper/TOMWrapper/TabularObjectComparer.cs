﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AnalysisServices.Tabular;
using TabularEditor.TOMWrapper;

namespace TabularEditor.TOMWrapper
{
    public class TabularObjectComparer : IComparer<ITabularNamedObject>, IComparer
    {
        private TabularTree tree;

        public TabularObjectComparer(TabularTree tree)
        {
            this.tree = tree;
        }

        public int Compare(object x, object y)
        {
            return Compare(x as ITabularNamedObject, y as ITabularNamedObject);
        }
        
        public int Compare(ITabularNamedObject x, ITabularNamedObject y)
        {
            var c = x.ObjectType.CompareTo(y.ObjectType);
            if (c == 0)
            {
                if (x.ObjectType == ObjectType.Level && y.ObjectType == ObjectType.Level)
                    return (x as Level).Ordinal.CompareTo((y as Level).Ordinal);

                return string.Compare(x.GetName(tree.Culture), y.GetName(tree.Culture), true);
            }
            return c;
        }
    }
}
