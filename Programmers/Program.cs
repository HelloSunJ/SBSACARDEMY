using System.Dynamic;

internal class Program
{

    private static void Main(string[] args)

    {

        /*      int [] inputvalue = new int[] {1,2,3,4,5,6,7,8,9,10};
                int [] inputvalue2 = new int[] {89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99};

                double answer = 0;
                answer = solution(inputvalue);
                Console.WriteLine(answer);
         */

        //중복된 숫자의 갯수 0722 프로그래머스
        /*      int[] num_list = new int[] { 1, 1, 2, 3, 4, 5 };
                int[] num_list2 = new int[] { 0, 2, 3, 4 };

                int val = 1;
                int answer = solution(num_list, val);
         */


        // 중앙 값 구하기 0723
        /* int[] num_list = new int[] { 1, 2, 7, 10, 11 };
        int[] num_list2 = new int[] { 9, -1, 0 };
        int answer = solution(num_list);
        Console.WriteLine(answer); */


        // 숫자 비교하기 0724
        /*       int num1 =1 , num2 =2;
                 int answer = solution (num1, num2);
                 Console.WriteLine(answer);  */
 
        // 피자 나눠먹기 0724
        /*        int num1 = 15, num2 = 99;
                 int answer = solution(num1);
                //int answer = solution(answer);
                Console.WriteLine(answer); */

        // 배열 원소의 길이 0725
        /*       var strl = new string[] { "We", "are", "the", "world!" };
                 int[] answer = solution(strl);
                 PrintArray(answer); */

        //각도기

        int answer = solution0729(10);
        Console.WriteLine(answer);

    }

    private static void PrintArray(int[] answer)
   
    {  
        for (int i = 0; i<answer.Length; i++)
        {
            Console.Write(answer[i]);
            if (i != answer.Length - 1)
                Console.Write(".");
        }
        Console.WriteLine();
    }

    public static int solution(int[] array, int n) // double (int[] numbers int)

    {
        //double answer = 0;

        /*    for (var i = 0; i < 10; i++)
              {
                  answer += numbers[1];
              }
              answer = answer / 10; */

        int answer = 0;
        // for 문 사용
        // 배열의 크기만큼 반복한다.
        /*  for (int i = 0; i < array.Length; i++)
         {
             // 배열 안에 있는 값을 하나씩 가져온다 
             int nn = array[i]; //int n으로 하면 오류남 이미 정의했기때문에


             // 두개의 값이 같으면,가져온 값과 주어진 수와 비교한다. 
             if (nn == n)
             {
                 // 넘겨주는 값에 1을 더한다
                 answer++;
             }


         } */

        // foreach

        foreach (int i in array)

            if (i == n)
            {
                answer++;

            }

        return answer;


    }


    static int solution(int[] array)//0723
    {
        int answer = 0;
        /*         List<int> list = new List<int>(array);
                list.Sort();
                //array.Length
                int index = list.Count / 2;
                answer = list[index];
         */
        for (int i = 0; i < array.Length - 1; i++)
        {

            for (int j = i + 1; i < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        answer = array[(array.Length - 1) / 2];


        return answer;

    }


    static int solution(int num1, int num2) //0724
    {
        int answer = 0;

        if (num1 == num2)
        {
            answer = 1;
        }
        else //(num1 != num2)
        {
            answer = -1;

        }
        answer = (num1 == num2) ? 1 : -1;

        return answer;
    }

    static int solution(int n) //0724
    {
        int answer = 0;
        int piz = n / 7;
        int res = (n % 7 == 0) ? 0 : 1;
        answer = piz + res;




        return answer;

    }

    static int[] solution(string[] strlist)//0725
    {

        int[] answer = new int[strlist.Length];

        // 주어진 string 배열의 크기만큼 반복한다.
        for (int i = 0; i < strlist.Length; i++)

        {
            //Console.WriteLine(strlist.GetLength(string));

            string str = strlist[i];
            //strlist 중에 index idp 해당하는 string 의 길이
            int len = str.Length;
            // answer 배열의 index의 해당하는 위치에 넣는다.
            answer[i] = len;

        }
        return answer;

        // return answer;


        /*         int val = 0;


                foreach (var item in strlist)
                {
                    answer[val] = item.Length;
                    val++;

                }
         */
    }

static int solution0726(int angle)//0726
{
    int answer = 0;

    if (angle == 90)
    {
        answer = 2;
    }
    else if (angle == 180)
    {
        answer = 4;
    }
    else if ((0<angle) && (angle <90))
    {
         answer = 1;
    }
    else //노조건 생략 가능한 if ... 복잡한 식을 여기에..
    {
        answer = 3;
    }
    
  // angle = (angle == 90) ? 2 : (angle == 180) ? 4 : ((0<angle) && (angle<90)) ? 1 : 3; 좋은 코드 아님
        
     return answer;
}


static int solution0729(int n) //짝수의 합 구하기
{
        int answer = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                answer += i;
            }
/*             else
            {
                continue;
            }
 */    
        }
        return answer;
    }
}

