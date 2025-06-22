public class Solution {
    public string IntToRoman(int num) 
    {

        var sym = new Dictionary<int,string>(){
            {1,"I" },
            {5 ,"V"},
            {10, "X"},
            {50, "L" },
            {100, "C" },
            {500,"D"},
            {1000,"M"}
        };
        var res = "";

        while(num>0)
        {
            Console.WriteLine(num);
            var str = num.ToString();
            if(str[0]== '4')
            {
                if(str.Count() == 3)
                {
                    num = num - 400;
                    res += "CD";
                }
                else if(str.Count()  == 2)
                {
                    num = num - 40;
                    res += "XL";
                }
                else
                {
                    num = num - 4;
                    res += "IV";
                }
                continue;
            }

            if(str[0]== '9')
            {
                if(str.Count() == 3)
                {
                    num = num - 900;
                    res += "CM";
                }
                else if(str.Count()  == 2)
                {
                    num = num - 90;
                    res += "XC";
                }
                else
                {
                    num = num - 9;
                    res += "IX";
                }
                continue;
            }

            switch (num)
            {
                case int n when n >= 1000:
                    num = num - 1000;
                    res += sym[1000];
                    break;
                case int n when n >= 500:
                    num = num - 500;
                    res += sym[500];
                    break;
                case int n when n >= 100:
                    num = num - 100;
                    res += sym[100];
                    break;
                case int n when n >= 50:
                    num = num - 50;
                    res += sym[50];
                    break;
                case int n when n >= 10:
                    num = num - 10;
                    res += sym[10];
                    break;
                case int n when n >= 5:
                    num = num - 5;
                    res += sym[5];
                    break;
                case int n when n >= 1:
                    num = num - 1;
                    res += sym[1];
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
            
        }
        return res;
        
    }
}