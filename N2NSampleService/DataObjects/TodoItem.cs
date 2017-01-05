﻿using Microsoft.Azure.Mobile.Server;

namespace N2NSample.Service.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}