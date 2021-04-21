using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeTestingAPI.Models.Entities
{
    public class ResponseTest
    {
        public ResponseTest(Test test)
        {
            ID_Test = test.ID_Test;
            Test_Title = test.Test_Title;
            Passing_Points = test.Passing_Points.HasValue ? test.Passing_Points.Value : 0;
            Test_Result_Count = test.Test_Result.Count;
        }
        public int ID_Test { get; set; }
        public string Test_Title { get; set; }
        public int Passing_Points { get; set; }
        public int Test_Result_Count { get; set; }
    }
}