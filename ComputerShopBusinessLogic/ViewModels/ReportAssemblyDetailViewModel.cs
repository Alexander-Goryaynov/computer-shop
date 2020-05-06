﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerShopBusinessLogic.ViewModels
{
    public class ReportAssemblyDetailViewModel
    {
        public string AssemblyName { get; set; }
        public int TotalCount { get; set; }
        public List<(string, int)> Details { get; set; }
    }
}
