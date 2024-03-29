﻿using IFridge.Abstractions;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFridge.MVVM.Models
{
    public class Drink: TableData
    {
        public string name { get; set; }
        public int quantity { get; set; }
        public string drinkImage {  get; set; } 

        [ForeignKey(typeof(Fridge))]
        public int FridgeId { get; set; }

        [ManyToOne(CascadeOperations = CascadeOperation.CascadeInsert)]
        public Fridge fridge { get; set; }
    }
}
