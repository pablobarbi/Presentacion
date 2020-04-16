using System;
using System.Collections.Generic;
using System.Text;

namespace AppDTO
{
    public class ResultResponseStore
    {
        public StoresDto[] stores { get; set; }
        public bool Success { get; set; }
        public int total_elements { get; set; }
    }
}
