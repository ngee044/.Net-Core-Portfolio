using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookManager.Engine
{
    //듀이 십진 분류 체계를 위한 클래스 정의
    //듀이 십진 분류 법이란??
    //https://ko.wikipedia.org/wiki/%EB%93%80%EC%9D%B4_%EC%8B%AD%EC%A7%84%EB%B6%84%EB%A5%98%EB%B2%95

    public class DeweyDecimal
    {
        public string ComputerScience { get; set; } = "000";
        public string DataProcessing { get; set; } = "004";
        public string ComputerProgramming { get; set; } = "005";
    }
}
