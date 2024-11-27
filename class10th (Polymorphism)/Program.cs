using System;

namespace class10th__Polymorphism_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Use Potion");
        }
    }
    class Knife : Item
    {
        public void Use()
        {
            Console.WriteLine("Use ")
            }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 다형성
            // 여러 개의 서로 다른 객체다 동일한 기능을 서로 다른 방법으로
            // 처리할 수 있는 작업입니다.

            #region 함수의 오버로딩
            // 같은 이름의 함수를 매개 변수의 자료형과 매개 변수의
            // 수로 구분하여 여러 개를 선언할 수 있는 기능입니다.

            Coordinate coordonate = new Coordinate();

            coordonate.position(10, 10);
            coordonate.position(5, 75f, 8.725f);
            coordonate.position(1.325f, 2.785f, 3.125f);

            // 함수의 오버로딩의 경우 함수의 매개 변수에 전달하는
            // 인수의 형태를 보고 호출하므로, 반환형으로 함수의
            // 오버로딩은 생성할 수 없습니다.
            #endregion

            #region 함수 오버라이딩
            // 상위 클래수에 있는 함수를 하위 클래스에서 재정의하여]
            // 사용하는 기능입니다.

            Vehicle vehicle = new Vehicle();

            vehicle.Behavior();

            Bicycle.bicycle = new Bicycle();

            bicycle.Behavior();

            // 함수의 오버라이드는 상속 관계에서만 이루어지며, 하위
            // 클래스에서 함수를 재정의할 때 클래스의 함수
            // 형태외 일치해야 합니다.
            #endregion

            #region 가상 함수
            // 상속하는 클래스 내에서 같은 형태의 함수로 재정의
            // 될 수 있는 함수입니다.

            Item item = null;
            Potion potion = new Potion();

            item = potion;

            item.Use();

            // 가상 함수의 경우 가상 함수 테이블을 사용하여
            // 호출되는 함수를 실행 시간에 결정하며,정적으로

            Knife knife = new Knife();

            item = knife;

            item.Use();

            Grenade grenade = new Grenade();

            item = grenade;


            // 가상 함수 실행 시간에 상위 클래스에 대한 참조로
            // 하위 클래스에 재정의된 함수를 호출할 수 있습니다.
            #endregion

        }
    }
}
