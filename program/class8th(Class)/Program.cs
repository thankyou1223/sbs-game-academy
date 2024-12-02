namespace class8th_Class_
{
    class GameObject
    {
        #region 접근 지정자
        // 클래스 내부의 포함되어 있는 속성에 접근 번윌ㄹ
        // 제한하는 지정자입니다.

        // public    : 클래스에 있는 데이터를 클래스 외부에서도
        //             접근을 허용하는 지정자입니다.

        // protected : 클래스에 있는 데이터를 클래스 내부와 자기가
        //             상속하고 있는 클래스에게만 접근을 허용하는 지정자입니다.

        // private   : 클래스에 있는 데이터를 클래스 내부에서만 접근
        //             을 허용하는 지정자입니다.
        #endregion

        // 접근 지정장를 설정하지 않으면 private로 설정됩니다.
        private int x;
        private int y;
        private int z;

        public void Position(int x, int y, int z)
        {
            // this Pointr
            // 자기 자신을 가리키는 포인터입니다
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void Information()
        {
            Console.WriteLine("x의 값 : " + x);
            Console.WriteLine("y의 값 : " + y);
            Console.WriteLine("z의 값 : " + z);

            Console.WriteLine();
        }
    }

    class Vitamin
    {
        private float b6;
        private float c;
        private float d;
    }

    class Item
    {
        public int price;

        public Item()
        {
            price = 1000;

            Console.WriteLine("Create Item");
        }
    }

    class Unit
    {
        public int health;
        public int attack;
        public int[] score;

        public Unit()
        {
            Console.WriteLine("복사 생성자");

            health = clone.health;
            attack = clone.atteck;

            score = new int[3];
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 클래스
            // 사용자 정의 데이터 유형으로 속성과 함수가
            // 포함되어 있으며, 클래스를 통해 객체를 생성하여
            // 접근하고 사용할 수 있는 집합체입니다.

            GameObject gameObject1 = new GameObject();
            GameObject gameObject2 = new GameObject();
            GameObject gameObject3 = new GameObject();

            gameObject1.Position(5, 5, 5);
            gameObject2.Position(2, 2, 2);
            gameObject3.Position(1, 1, 1);

            gameObject1.Information();
            gameObject2.Information();
            gameObject3.Information();

            // 클래스의 경우 클래스 내부에 있는 변수는 클래스 메모리
            // 영역에 포함되지만, 정적 변수와 함수의 메모리는 클래스
            // 영역에 포함되지 않습니다.
            #endregion

            #region 바이트 패딩
            // 멤버 변수를 메모리에서 CPU로 읽을 때 한 번에
            // 읽을 수 있도록, 컴파일러가 레지스터의 블록에 맞추어
            // 바이트를 패딩해주는 최적화 작업입니다.

            Vitamin vitamen = new Vitamin();

            // 클래스의 인스턴트가 생성되는 시점에서 자동으로
            // 호출되는 특수한 멤버 함수입니다.

            Item item = new Item();

            // 생성자의 경우 객체가 생성될 때 단 한 번만 호출되며,
            // 생성자는 반환형이 존재하지 않기 때문에 생성자가 호출되기
            // 전에는 객체에 대한 메모리는 할당하지 않습니다.
            #endregion

            #region 얕은 복사
            // 객체를 복사할 때 주소 값을 복사하여 같은 메모리를
            // 가리키게 하는 복사입니다.

            Item item1 = new Item();

            Item item2 = item1;

            item2.price = 999;

            Console.WriteLine("item1의 price 값 : " + item1.price);
            Console.WriteLine("item2의 price 값 : " + item2.price);

            // 복사 생성자를 정의하지 않고, 객체를 복사하게 되면
            // 기본 복사 생성자가 호출되기 때문에 얕은 복사로 
            // 객체가 복사됩니다.
            #endregion

            #region 깊은 복사
            // 객체를 복사할 떄, 참조 값이 아닌 인스턴트 자체를
            // 새로 복사하여 서로 다른 메모리를 생성하는 복사입니다.

            Unit unit = new Unit();

            unit1.health = 100;
            uint1.attack = 10;

            uint.score[0] = 5;
            uint.score[1] = 10;
            uint.score[2] = 15;

            Unit unit2 = new Unit();

            uint.score[0] = 3;
            uint.score[1] = 3;
            uint.score[2] = 3;


            for(int i = 0; i < unit.score.Length; i++)
            {
                Console.WriteLine("unit1의 score[" + i + "]" + " : " + unit.score[i]);
            }

            for (int i = 0; i < unit2.score.Length; i++)
            {
                Console.WriteLine("unit2의 score[" + i + "]" + " : " + unit2.score[i]);
            }

            #endregion


        }
    }
}