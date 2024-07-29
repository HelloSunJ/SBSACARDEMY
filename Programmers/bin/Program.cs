internal class Program
{    // 문자 반복 출력하기 0719
    private static void Main(string[] args)
    {
        // string str = "hello";

        string str = solution0719("hello", 3);
        Console.WriteLine(str);

    }

    public static string solution0719(string my_string, int n)
    {   // my_string에 들어있는 각 문자를 처음부터 돌면서 하나씩 얻어와서
        // n번만큼 돌려서
        // 그걸 answer애 담는다.

        string answer = "";

        foreach (var item in my_string)
        {
            for (var i = 0; i < n; i++)
            {
                answer += item; // string연산을 할 경우엔 StringBuilder를 사용하면 효율적이다!!
            }
        }

        return answer;

    }

}