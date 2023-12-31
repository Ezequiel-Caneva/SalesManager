﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class Search
    {
        public string TextToSearch { get; set; }
        public string? TextToSearch2 { get; set; }

        [DefaultValue(10)]
        public int PageSize { get; set; }

        [DefaultValue(1)]
        public int PageIndex { get; set; }
        public int num {  get; set; }   
       
        public bool IsValid
        {
            get
            {

                if (PageSize <= 0)
                {
                    return false;
                }

                if (PageIndex <= 0)
                {
                    return false;
                }

                return true;

            }
        }
        public string ResultMessage()
        {
            return $"Ventas {PageIndex * PageSize} - {PageIndex * PageSize + PageSize}";
        }

        public Search()
        {
            PageIndex = 1;
            PageSize = 10;
        }

    }
}