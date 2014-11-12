﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBootstrap.Typography
{
    public interface IAbbrCreator<THelper> : IComponentCreator<THelper>
    {
    }

    public class AbbrWrapper<THelper> : TagWrapper<THelper>
    {
    }

    internal interface IAbbr : ITag
    {
    }

    public class Abbr<THelper> : Tag<THelper, Abbr<THelper>, AbbrWrapper<THelper>>, IAbbr, IHasTextContent, IHasTitleAttribute
    {
        internal Abbr(IComponentCreator<THelper> creator)
            : base(creator, "abbr")
        {
        }
    }
}
