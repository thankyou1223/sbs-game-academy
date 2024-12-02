using System.ComponentModel;

namespace class12th_캡슐화_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 캡슐화
            // 관련성 있는 데이터와 그 데이터를 다루는 함수를
            // 객체 안에 구현하고, 객체 밖에서 알아야 할 필요가
            // 없는 속성들은 숨기는 것입니다.

            Vitamin vitamin = new Vitamin();

            vitamin.Protein = 30;

            Console.WriteLine("Protein의 값 : " + vitamin.Protein);

            vitamin.Protein = 999;

            #endregion

            #region 일반화 프로그래밍
            // 데이터 형식에 의존하지 않고, 하나의 값이 여러 다른
            // 자료형들을 가질 수 있는 기술에 중점울 두어 재사용성을 
            // 높일 수 있는 프로그래밍 방식입니다.

            Container<char> containerChar = new Container<char>0;

            for (int i = 0; i < 10; i++)
            {
                containerChar[i] = 'A';

                Console.WriteLine(containerChar[i]);
            }

            for (int i = 0; i < 10; i++)
            {
                containerInt32[i] = i;

                Console.Write(containerInt32[i]);
            }

            Container.WriteLine();

            #endregion

        }
    }
}
