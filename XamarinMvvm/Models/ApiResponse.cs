using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMvvm.Models
{
    public class ApiResponse
    {
        public List<ProductsResponse> Products { get; set; }
        public int Total { get; set; }
        public int Skip { get; set; }
        public int Limit { get; set; }
    }
}
