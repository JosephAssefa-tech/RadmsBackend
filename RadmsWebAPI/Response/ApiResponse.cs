﻿namespace RadmsWebAPI.Response
{
    public class ApiResponse<T>
    {
        public T Data { get; set; }
        public int TotalCount { get; set; }
    }
}
