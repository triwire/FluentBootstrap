﻿using FluentBootstrap.Labels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBootstrap
{
    public static class LabelExtensions
    {
        public static Label<THelper> Label<THelper>(this ILabelCreator<THelper> creator, string text)
        {
            return new Label<THelper>(creator).SetText(text);
        }

        public static Label<THelper> SetState<THelper>(this Label<THelper> label, LabelState state)
        {
            label.ToggleCss(state);
            return label;
        }
    }
}
