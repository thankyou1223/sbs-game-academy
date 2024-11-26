using System.ComponentModel;

namespace Classth8_class1_
{ 

       class Terran
        {
            protected int health;
            protected int attack;

            public Terran()
            {
                Console.WriteLine("Created Terran")

            }

            class Marine : Terran
            {
                private int defense;

                public Marined()
                {
                    health = 40;
                    attack = 6;
                    defense = 0;

                    Console.WriteLine("Created Marine");
                }
            }
        internal class program
        {
            static float Add(float x, float y)
            {
                return x + y;

            }
            static float 
                Subtraction(float x, float y)
            {
                return 
            }
        }
        }
        static void Main(string[] args)
        {
            #region 상속
            // 상위 클래스의 속성을 하위 클래스가 사용할 수있도록
            // 설정해주는 기능입니다.

            Marine marine = new Marine();

            marine.Stats();

            // 클래스의 상속 관계에서는 상위 클래스는 하위 클래스의
            // 속성을 사용할 수 없으며, 하위 클래스는 상위 클래스의
            // 메모리를

            #endregion

            #region 가비지 컬렉터
            // 메모리 관리를 담당하는 시스템이며, 메모리에서 더 이상 사용되지
            // 객체를 탐색하여 메모리를 회수하는 기법입니다.

            // Mark 과정 : Root Space로 부터 그래프 순회를 통해 연결된 객체들을
            //             찾아 각각 어떤 객체를 참조하고 있는 지 찾아냅니다.
            // Sweep     : 참조하고 있지 않은 객체를 Unreachable 객체들을 Managed
            //           : Heap에서 제거합니다.

            // Compact   : Sweep 이후에 분산된 객체들을 Managed Heap의 시작 주소로
            //             모아 메모리가 할당된 부분과 그렇지 않은 부분으로 압축합니다.
            #endregion

            #region 대지자
            // 함수에 대한 참조 함수의 주소 값을 가지고 있어서 함수를
            // 대신 호출 수 있는 기능입니다.

            Calculator calculator;

            calculator = Add;

            Console.WriteLine("Add : " + calculator(1.57, 10.0f);

            calculator = Subtractin;






            #endregion
        }
    }
}
