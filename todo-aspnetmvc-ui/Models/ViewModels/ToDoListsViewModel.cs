﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todo_domain_entities;

namespace todo_aspnetmvc_ui.Models.ViewModels
{
    public class ToDoListsViewModel
    {
        public IEnumerable<ToDoList> ToDoLists { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public int TotalToDoListsCount { get; set; }
        public int CompletedToDoListsCount { get; set; }
    }
}