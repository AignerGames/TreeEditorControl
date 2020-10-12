﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeEditorControl.Utility;

namespace TreeEditorControl.Example
{
    public class StringViewModel : ObservableObject
    {
        private string _value;

        public string Value
        {
            get => _value;
            set => SetAndNotify(ref _value, value);
        }

        public override string ToString() => Value;
    }
}