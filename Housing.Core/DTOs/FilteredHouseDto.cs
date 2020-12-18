﻿using Housing.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Housing.Core.DTOs
{
   public class FilteredHouseDto
    {
        public double Price { get; set; }
        public HouseType Type { get; set; }
        public string Street { get; set; }
        public bool HasAllDefaultValues()
        {
            return Price == default && Type == HouseType.Ничего && Street == default;
        }
    }
}
